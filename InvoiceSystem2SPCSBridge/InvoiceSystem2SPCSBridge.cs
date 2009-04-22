using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Forms;

using SPCS;
using InvoiceSystem;

namespace InvoiceSystem2SPCS
{
    #region +++ Enums +++
    
    public enum ProcressAction
    {
        ReadFromDB,
        WriteToSPCS
    }
    
    #endregion
    
    // Interface needed to make the InvoiceSystem2SPCSBridge-class COM-visible (i.e. available from ASP 1.0, etc.)
    [ComVisible(true), GuidAttribute("2556218e-6aed-11dc-8314-0800200c9a66")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface _InvoiceSystem2SPCSBridge
    {
        [DispId(1)]
        string DatabasePath { get; set; }
        [DispId(2)]
        string DatabaseName { get; set; }
        [DispId(3)]
        string DatabaseUserId { get; set; }
        [DispId(4)]
        string DatabaseUserPassword { get; set; }
        
        [DispId(5)]
        string SPCSLibraryPath { get; set; }
        [DispId(6)]
        string SPCSDatabasePath { get; set; }
        [DispId(7)]
        string SPCSDatabaseName { get; set; }
        
        //[DispId(8)]
        //void PerformTransaction();
        [DispId(8)]
        void PerformTransaction(string invoiceId);
    }
    
    [ComVisible(true), GuidAttribute("6a29217a-6a8a-11dc-8314-0800200c9a66")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId(".SPCSBridge")]
    public class InvoiceSystem2SPCSBridge : _InvoiceSystem2SPCSBridge, IDisposable
    {
        #region +++ Constructors +++
        
        public InvoiceSystem2SPCSBridge() { }
        
        #endregion
        
        #region +++ IDisposable Members +++
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
        #endregion
        
        #region +++ Functions: Transaction +++
        
        public void PerformTransaction()
        {
            this.Transaction();
        }
        
        public void PerformThreadedTransaction()
        {
            new Thread(new ThreadStart(this.Transaction)).Start();
        }
        
        private void Transaction()
        {
            List<SPCSInvoice> invoices = this.ReadFromDatabase();
            this.WriteToSPCS(invoices);
        }
        
        public void PerformTransaction(string invoiceId)
        {
            this.Transaction(invoiceId);
        }
        
        public void PerformThreadedTransaction(string invoiceId)
        {
            // Not working for COM:
            new Thread(new ParameterizedThreadStart(this.Transaction)).Start(invoiceId);
        }
        
        private void Transaction(object invoiceId)
        {
            SPCSInvoice invoice = this.ReadFromDatabase(invoiceId as string);
            List<SPCSInvoice> invoices = new List<SPCSInvoice>();
            invoices.Add(invoice);
            this.WriteToSPCS(invoices);
        }
        
        #endregion
        
        #region +++ Functions:  +++
        
        private List<SPCSInvoice> ReadFromDatabase()
        {
            List<SPCSInvoice> invoices = null;
            
            using (Connection c = new Connection())
            {
                c.DatabasePath = string.Format("{0}{1}{2}{3}", this.DatabasePath.TrimEnd('\\'), '\\', this.SPCSDatabaseName, ".mdb");
                c.DatabaseUserId = this.DatabaseUserId;
                c.DatabaseUserPassword = this.DatabaseUserPassword;
                c.Open();
                
                if (c.IsConnected)
                {
                    invoices = this.ReadInvoices(c);
                }
            }
            
            return invoices;
        }
        
        private SPCSInvoice ReadFromDatabase(string invoiceId)
        {
            SPCSInvoice invoice = null;
            
            using (Connection c = new Connection())
            {
                c.DatabasePath = string.Format("{0}{1}{2}{3}", this.DatabasePath.TrimEnd('\\'), '\\', this.DatabaseName, ".mdb");
                c.DatabaseUserId = this.DatabaseUserId;
                c.DatabaseUserPassword = this.DatabaseUserPassword;
                c.Open();
                
                if (c.IsConnected)
                {
                    invoice = this.ReadInvoice(c, invoiceId);
                }
            }
            
            return invoice;
        }
        
        private SPCSInvoice ReadInvoice(Connection connection, string invoiceId)
        {
            SPCSInvoice invoice = null;
            SPCSCustomer customer = null;
            SPCSProject project = null;
            
            using (TypedDataReader reader = connection.GetInvoiceReader(int.Parse(invoiceId)))
            {
                using (SPCSConnection c = new SPCSConnection())
                {
                    c.LibraryPath = this.SPCSLibraryPath;
                    c.DatabasePath = string.Format("{0}{1}{2}", this.SPCSDatabasePath.TrimEnd('\\'), '\\', this.SPCSDatabaseName);
                    c.Open();
                    
                    if (c.IsConnected)
                    {
                        bool result = reader.Read();
                        
                        if (result)
                        {
                          
                            customer = new SPCSCustomer();
                            {
                                customer.CustomerName = reader.GetString(DataBase.InvoiceColumnNameCustomerName);
                                customer.CustomerNr = customer.GetId();
                                customer.CustomerReference = string.Format("{0} {1}", reader.GetString(DataBase.InvoiceColumnNameCustomerReferenceFirstName),
                                                                    reader.GetString(DataBase.InvoiceColumnNameCustomerReferenceLastName));
                                                                    
                            }
                            
                            project = new SPCSProject();
                            {
                                project.ProjectName = reader.GetString(DataBase.InvoiceColumnNameOurProject);
                                project.ProjectNr = project.GetId();
                                project.ProjectCustomerNr = customer.CustomerNr;
                                project.ProjectStartTime = DateTime.Today;
                                project.ProjectEndTime = DateTime.Today;
                            }
                            
                            invoice = new SPCSInvoice();
                            {
                                invoice.Customer = customer;
                                invoice.Project = project;
                                
                                invoice.InvoiceDate = reader.GetDateTime(DataBase.InvoiceColumnNameDate);
                                
                                invoiceId = reader.GetString(DataBase.InvoiceRowColumnNameInvoiceId);
                                invoice.InvoiceCustomerOrderNr = reader.GetString(DataBase.InvoiceColumnNameCustomerOrderNr);
                                invoice.InvoiceOurReferenceName = string.Format("{0} {1}", reader.GetString(DataBase.InvoiceColumnNameOurReferenceFirstName),
                                                                    reader.GetString(DataBase.InvoiceColumnNameOurReferenceLastName));
                            }
                            
                            this.ReadInvoiceRows(connection, invoice, int.Parse(invoiceId));
                            Console.WriteLine(invoice.ToString());
                            
                            MessageBox.Show(invoice.ToString());
                        }
                    }
                }
            }
            return invoice;
        }
        
        private List<SPCSInvoice> ReadInvoices(Connection connection)
        {
            int rowCount = connection.GetInvoiceCount();
            int rowNr = 0;
            
            List<SPCSInvoice> invoices = new List<SPCSInvoice>(rowCount);
            
            using (TypedDataReader reader = connection.GetInvoiceReader())
            {
                 using (SPCSConnection c = new SPCSConnection())
                {
                    c.Open();
                    
                    if (c.IsConnected)
                    {
                        SPCSInvoice invoice = null;
                        SPCSCustomer customer = null;
                        SPCSProject project = null;
                        
                        int invoiceId = 0;
                        
                        // For each invoice
                        while (reader.Read())
                        {
                            customer = new SPCSCustomer();
                            {
                                customer.CustomerName = reader.GetString(DataBase.InvoiceColumnNameCustomerName);
                                customer.CustomerNr = customer.GetId();
                                customer.CustomerReference = string.Format("{0} {1}", reader.GetString(DataBase.InvoiceColumnNameCustomerReferenceFirstName),
                                                                    reader.GetString(DataBase.InvoiceColumnNameCustomerReferenceLastName));
                            }
                            
                            project = new SPCSProject();
                            {
                                project.ProjectName = reader.GetString(DataBase.InvoiceColumnNameOurProject);
                                project.ProjectNr = project.GetId();
                                project.ProjectCustomerNr = customer.CustomerNr;
                                project.ProjectStartTime = DateTime.Today;
                                project.ProjectEndTime = DateTime.Today;
                            }
                            
                            // Get invoice-head
                            invoice = new SPCSInvoice();
                            {
                                invoice.Customer = customer;
                                invoice.Project = project;
                                
                                string date = reader.GetString(DataBase.InvoiceColumnNameDate);
                                if (!string.IsNullOrEmpty(date))
                                    invoice.InvoiceDate = DateTime.Parse(date);
                                    
                                invoiceId = reader.GetInt(DataBase.InvoiceRowColumnNameInvoiceId);
                                invoice.InvoiceCustomerOrderNr = reader.GetString(DataBase.InvoiceColumnNameCustomerOrderNr);
                                invoice.InvoiceOurReferenceName = string.Format("{0} {1}", reader.GetString(DataBase.InvoiceColumnNameOurReferenceFirstName),
                                                                    reader.GetString(DataBase.InvoiceColumnNameOurReferenceLastName));
                            }
                            
                            // Get all invoice-rows
                            this.ReadInvoiceRows(connection, invoice, invoiceId);
                            
                            invoices.Add(invoice);
                            
                            Console.WriteLine(invoice.ToString());
                            this.OnProcessValueChanged(++rowNr, rowCount, ProcressAction.ReadFromDB);
                        }
                    }
                }
            }
            return invoices;
        }
        
        private void ReadInvoiceRows(Connection connection, SPCSInvoice invoice, int invoiceId)
        {
            using (TypedDataReader reader = connection.GetInvoiceRowReader(invoiceId))
            {
                SPCSInvoiceRow invoiceRow = null;
                
                // For each invoice-row
                while (reader.Read())
                {
                    invoiceRow = new SPCSInvoiceRow();
                    {
                        invoiceRow.InvoiceRowArticleText = reader.GetString(DataBase.InvoiceRowColumnNameArticleText);
                        invoiceRow.InvoiceRowPriceEach = reader.GetDouble(DataBase.InvoiceRowColumnNamePriceEach);
                        invoiceRow.InvoiceRowQuantity = reader.GetDouble(DataBase.InvoiceRowColumnNameQuantity);
                        invoiceRow.InvoiceRowUnit = "TimAnt";
                    }
                    
                    invoice.InvoiceRows.Add(invoiceRow);
                }
            }
        }
        
        #endregion
        
        #region +++ Functions: SPCS +++
        
        private void WriteToSPCS(List<SPCSInvoice> invoices)
        {
            int invoiceNr = 0;
            int invoiceCount = invoices.Count;
            bool saved = false;
            
            using (SPCSConnection c = new SPCSConnection())
            {
                c.DatabasePath = this.SPCSDatabasePath;
                c.LibraryPath = this.SPCSLibraryPath;
                c.Open();
                
                if (c.IsConnected)
                {
                    foreach (SPCSInvoice invoice in invoices)
                    {
                        try
                        {
                            //saved = invoice.SaveIfNotAvailable();
                            saved = invoice.Save();
                            
                            if (saved)
                                this.OnStatusMessageChanged("Faktura överförd", ProcressAction.WriteToSPCS);
                            else
                                this.OnStatusMessageChanged("Faktura ej överförd - finns redan i SPCS.", ProcressAction.WriteToSPCS);
                                
                            this.OnProcessValueChanged(++invoiceNr, invoiceCount, ProcressAction.WriteToSPCS);
                        }
                        catch (Exception e)
                        {
                            this.OnStatusMessageChanged(string.Format("ERROR: {0}", e.Message), ProcressAction.WriteToSPCS);
                            break;
                        }
                    }
                }
            }
        }
        
        #endregion
        
        #region +++ Events +++
        
        public delegate void ProcessValueChangedEventHandler(int value, int maxValue, ProcressAction action);
        public event ProcessValueChangedEventHandler ProcessValueChanged;
        protected virtual void OnProcessValueChanged(int value, int maxValue, ProcressAction action)
        {
            if (this.ProcessValueChanged != null)
                this.ProcessValueChanged(value, maxValue, action);
        }
        
        public delegate void StatusMessageChangedEventHandler(string message, ProcressAction action);
        public event StatusMessageChangedEventHandler StatusMessageChanged;
        protected virtual void OnStatusMessageChanged(string message, ProcressAction action)
        {
            if (this.StatusMessageChanged != null)
                this.StatusMessageChanged(message, action);
        }
        
        public delegate void SessionLogEventHandler(string message);
        public event SessionLogEventHandler LogMessage;
        protected virtual void OnLogMessage(string message)
        {
            if (this.LogMessage != null)
                this.LogMessage(message);
        }
        
        #endregion
        
        #region +++ Properties +++
        
        private string _DatabasePath = string.Empty;
        public string DatabasePath
        {
            get { return _DatabasePath; }
            set { _DatabasePath = value; }
        }
        
        private string _DatabaseName = string.Empty;
        public string DatabaseName
        {
            get { return _DatabaseName; }
            set { _DatabaseName = value; }
        }
        
        private string _DatabaseUserId = string.Empty;
        public string DatabaseUserId
        {
            get { return _DatabaseUserId; }
            set { _DatabaseUserId = value; }
        }
        
        private string _DatabaseUserPassword = string.Empty;
        public string DatabaseUserPassword
        {
            get { return _DatabaseUserPassword; }
            set { _DatabaseUserPassword = value; }
        }
        
        private string _SPCSDatabasePath = string.Empty;
        public string SPCSDatabasePath
        {
            get { return _SPCSDatabasePath; }
            set { _SPCSDatabasePath = value; }
        }
        
        private string _SPCSDatabaseName = string.Empty;
        public string SPCSDatabaseName
        {
            get { return _SPCSDatabaseName; }
            set { _SPCSDatabaseName = value; }
        }
        
        private string _SPCSLibraryPath = string.Empty;
        public string SPCSLibraryPath
        {
            get { return _SPCSLibraryPath; }
            set { _SPCSLibraryPath = value; }
        }
        
        #endregion
        
        #region +++ Test Functions +++
        
        private List<SPCSInvoice> TestInvoices()
        {
            List<SPCSInvoice> invoices = new List<SPCSInvoice>();
            
            SPCSConnection connection = new SPCSConnection();
            {
                connection.Open();
                
                if (connection.IsConnected)
                {
                    SPCSCustomer c = new SPCSCustomer();
                    {
                        c.CustomerName = "FooBar AB";
                        c.CustomerNr = c.GetId();
                        c.CustomerReference = "Jonas Grimfelt";
                        c.SaveIfNotAvailable();
                        Console.WriteLine("Customer-nr: " + c.CustomerNr);
                    }
                    
                    SPCSProject p = new SPCSProject();
                    {
                        p.ProjectName = "ABC-123";
                        p.ProjectNr = p.GetId();
                        p.ProjectCustomerNr = c.CustomerNr;
                        p.ProjectStartTime = DateTime.Today;
                        p.ProjectEndTime = DateTime.Today;
                        p.SaveIfNotAvailable();
                        Console.WriteLine("Project-nr: " + p.ProjectNr);
                    }
                    
                    SPCSInvoice i = new SPCSInvoice();
                    {
                        i.InvoiceDate = DateTime.ParseExact("2007-07-14", "yyyy-MM-dd", null);
                        
                        //i.InvoiceCustomerNr = c.CustomerNr;
                        i.Customer = c;
                        i.InvoiceCustomerOrderNr = "123AABB1234";
                        
                        //i.InvoiceOurProject = p.ProjectNr;
                        i.Project = p;
                        i.InvoiceOurReferenceName = "Foo Bar";
                        
                        SPCSInvoiceRow r1 = new SPCSInvoiceRow();
                        {
                            r1.InvoiceRowArticleText = "Lorem ipsum A";
                            r1.InvoiceRowPriceEach = 3.51;
                            r1.InvoiceRowQuantity = 425;
                            r1.InvoiceRowUnit = "Pieces";
                        }
                        SPCSInvoiceRow r2 = new SPCSInvoiceRow();
                        {
                            r2.InvoiceRowArticleText = "Lorem ipsum B";
                            r2.InvoiceRowPriceEach = 3.51;
                            r2.InvoiceRowQuantity = 300;
                            r2.InvoiceRowUnit = "Hr";
                        }
                        i.InvoiceRows.Add(r1);
                        i.InvoiceRows.Add(r2);
                    }
                    
                    invoices.Add(i);
                }
                
                connection.Close();
                connection.Dispose();
            }
            
            return invoices;
        }
        
        #endregion
    }
}
