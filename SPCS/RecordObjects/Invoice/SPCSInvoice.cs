using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SPCS
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class SPCSInvoice : SPCSIRecordObject, IDisposable
    {
        #region +++ Constructors +++
        
        public SPCSInvoice()
        {
        }
        
        #endregion
        
        public bool SaveIfNotAvailable()
        {
            Console.WriteLine("INVOICE EXISTS?...");
            
            if (!this.Exists())
            {
                Console.WriteLine("NO");
                return this.Save();
            }
            else
            {
                Console.WriteLine("YES");
                return false;
            }
        }
        
        // Save invoice to SPCS
        public bool Save()
        {
            Console.WriteLine("Saving INVOICE...");
            
            try
            {
                // Save associated customer if not available
                if (this.Customer != null)
                    this.Customer.SaveIfNotAvailable();
                    
                // Save associated project if not available
                if (this.Project != null)
                    this.Project.SaveIfNotAvailable();
                    
                int pInvoice = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_INVOICE_HEAD);
                {
                    // General
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_TYPE_OF_INVOICE, this.InvoiceType, "InvoiceType");
                    
                    DateTime date = this.InvoiceDate;
                    SPCSAPI.SPCSWriteDate(pInvoice, SPCSAPI.ADK_OOI_HEAD_DOCUMENT_DATE1, date, "InvoiceDate " + date);
                    
                    // Customer
                    string customerNr = (this.Customer != null) ? this.Customer.CustomerNr : this.InvoiceCustomerNr;
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_CUSTOMER_NUMBER, customerNr, "InvoiceCustomerNr " + customerNr);
                    
                    string customerName = (this.Customer != null) ? this.Customer.CustomerName : this.InvoiceCustomerName;
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_CUSTOMER_NAME, customerName, "InvoiceCustomerName " + customerName);
                    
                    string customerOrderNr = this.InvoiceCustomerOrderNr;
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_CUSTOMER_ORDER_NUMBER, customerOrderNr, "InvoiceCustomerOrderNr " + customerOrderNr);
                    
                    // Non-customer
                    string ourReferenceName = this.InvoiceOurReferenceName;
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_OUR_REFERENCE_NAME, ourReferenceName, "InvoiceOurReferenceName " + ourReferenceName);
                    
                    string ourProjectCode = (this.Project != null) ? this.Project.ProjectNr : this.InvoiceOurProject;
                    SPCSAPI.SPCSWriteString(pInvoice, SPCSAPI.ADK_OOI_HEAD_PROJECT_CODE, ourProjectCode, "InvoiceOurProject " + ourProjectCode);
                    
                    this.WriteInvoiceRows(pInvoice);
                    
                }
                
                // ADK_OOI_HEAD_PENALTY_LONGEREST_RATE
                // ADK_OOI_HEAD_TOTAL_AMOUNT
                // ADK_OOI_HEAD_CODE_OF_TERMS_OF_PAYMENT
                // ADK_OOI_HEAD_DELIVERY_NAME
                // ADK_OOI_HEAD_DELIVERY_MAILING_ADDRESS1
                // ADK_OOI_HEAD_DELIVERY_MAILING_ADDRESS2
                // ADK_OOI_HEAD_DELIVERY_ZIPCODE
                // ADK_OOI_HEAD_DELIVERY_CITY
                
                
                Console.WriteLine(this.ToString());
                // Add current invoice to SPCS
                SPCSAPI.SPCSAdd(pInvoice, "Spara faktura");
                
                // Clean up
                SPCSAPI.SPCSDeleteStruct(pInvoice, "Rensa upp faktura");
            }
            catch
            {
                return false;
            }
            
            return true;
        }
        
        private void WriteInvoiceRows(int pInvoice)
        {
            // Create rows structure
            int pInvoiceRows = SPCSAPI.AdkCreateDataRow(SPCSAPI.ADK_DB_INVOICE_ROW, this.InvoiceRows.Count);
            
            int pInvoiceRow = 0;
            int rowNr = 0;
            
            // Loop through all invoice-rows and save to SPCS
            foreach (SPCSInvoiceRow r in this.InvoiceRows)
            {
                // Fetch a row
                pInvoiceRow = SPCSAPI.AdkGetDataRow(pInvoiceRows, rowNr++);
                {
                    // Write row data
                    SPCSAPI.SPCSWriteString(pInvoiceRow, SPCSAPI.ADK_OOI_ROW_ARTICLE_NUMBER, r.InvoiceRowArticleNr, "InvoiceRowArticleNr");
                    SPCSAPI.SPCSWriteString(pInvoiceRow, SPCSAPI.ADK_OOI_ROW_TEXT, r.InvoiceRowArticleText, "InvoiceRowArticleText");
                    SPCSAPI.SPCSWriteDouble(pInvoiceRow, SPCSAPI.ADK_OOI_ROW_PRICE_EACH_CURRENT_CURRENCY, r.InvoiceRowPriceEach, "InvoiceRowPriceEach");
                    SPCSAPI.SPCSWriteDouble(pInvoiceRow, SPCSAPI.ADK_OOI_ROW_QUANTITY1, r.InvoiceRowQuantity, "InvoiceRowQuantity");
                    SPCSAPI.SPCSWriteString(pInvoiceRow, SPCSAPI.ADK_OOI_ROW_UNIT, r.InvoiceRowUnit, "InvoiceRowUnit");
                }
            }
            
            // Write rows-structure
            SPCSAPI.SPCSWriteStruct(pInvoice, SPCSAPI.ADK_OOI_HEAD_ROWS, pInvoiceRows, "Spara faktura-rad");
            
            // Set number of rows in the current invoice
            SPCSAPI.SPCSWriteDouble(pInvoice, SPCSAPI.ADK_OOI_HEAD_NROWS, this.InvoiceRows.Count, "S‰tt antal rader");
        }
        
        public bool Exists()
        {
            int pInvoice = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_INVOICE_HEAD);
            
            SPCSAPI.AdkResetStruct(pInvoice);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetSortOrder(pInvoice, SPCSAPI.ADK_SORT_ORDER.eInvoiceNr);
            result = SPCSAPI.AdkFirst(pInvoice);
            
            string invoiceCustomerNr = null;
            string invoiceCustomerOrderNr = null;
            DateTime invoiceDate;
            
            while (result.lRc != SPCSAPI.ADKE_NO_DB_OPEN && result.lRc != SPCSAPI.ADKE_EOF)
            {
                invoiceCustomerNr = SPCSAPI.SPCSGetString(pInvoice, SPCSAPI.ADK_OOI_HEAD_CUSTOMER_NUMBER);
                invoiceCustomerOrderNr = SPCSAPI.SPCSGetString(pInvoice, SPCSAPI.ADK_OOI_HEAD_CUSTOMER_ORDER_NUMBER);
                invoiceDate = SPCSAPI.SPCSGetDate(pInvoice, SPCSAPI.ADK_OOI_HEAD_DOCUMENT_DATE1);
                
                if (this.InvoiceCustomerNr.Equals(invoiceCustomerNr, StringComparison.InvariantCultureIgnoreCase) &&
                    this.InvoiceCustomerOrderNr.Equals(invoiceCustomerOrderNr, StringComparison.InvariantCultureIgnoreCase) &&
                    this.InvoiceDate.Equals(invoiceDate))
                    return true;
                    
                result = SPCSAPI.AdkNext(pInvoice);
            }
            
            SPCSAPI.AdkDeleteStruct(pInvoice);
            
            return false;
        }
        
        #region +++ General Properties +++
        
        private List<SPCSInvoiceRow> _InvoiceRows = new List<SPCSInvoiceRow>();
        public List<SPCSInvoiceRow> InvoiceRows
        {
            get { return _InvoiceRows; }
            set { _InvoiceRows = value; }
        }
        
        private string _InvoiceType = "F";
        public string InvoiceType
        {
            get { return _InvoiceType; }
            set { _InvoiceType = value; }
        }
        
        private DateTime _InvoiceDate = DateTime.MinValue;
        public DateTime InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }
        
        #endregion
        
        #region +++ Company Properties +++
        
        private string _InvoiceOurReferenceName = null;
        public string InvoiceOurReferenceName
        {
            get { return _InvoiceOurReferenceName; }
            set { _InvoiceOurReferenceName = value; }
        }
        
        private string _InvoiceOurProject = null;
        public string InvoiceOurProject
        {
            get { return _InvoiceOurProject; }
            set { _InvoiceOurProject = value; }
        }
        
        #endregion
        
        #region +++ Customer Properties +++
        
        private string _InvoiceCustomerNr = null;
        public string InvoiceCustomerNr
        {
            get {
                string val = (this.Customer != null) ? this.Customer.CustomerNr : null;
                return (val != null) ? val : _InvoiceCustomerNr;
            }
            set { _InvoiceCustomerNr = value; }
        }
        
        private string _InvoiceCustomerName = null;
        public string InvoiceCustomerName
        {
            get {
                string val = (this.Customer != null) ? this.Customer.CustomerName : null;
                return (val != null) ? val : _InvoiceCustomerName;
            }
            set { _InvoiceCustomerName = value; }
        }
        
        private string _InvoiceCustomerOrderNr = null;
        public string InvoiceCustomerOrderNr
        {
            get { return _InvoiceCustomerOrderNr; }
            set { _InvoiceCustomerOrderNr = SPCSAPI.PreProcessString(value, 20); }
        }
        
        private string _InvoiceCustomerReference = null;
        public string InvoiceCustomerReference
        {
            get { return _InvoiceCustomerReference; }
            set { _InvoiceCustomerReference = value; }
        }
        
        private string _InvoiceCustomerReferenceNr = null;
        public string InvoiceCustomerReferenceNr
        {
            get { return _InvoiceCustomerReferenceNr; }
            set { _InvoiceCustomerReferenceNr = value; }
        }
        
        private string _InvoiceCustomerReferenceName = null;
        public string InvoiceCustomerReferenceName
        {
            get {
                string val = (this.Customer != null) ? this.Customer.CustomerReference : null;
                return (val != null) ? val : _InvoiceCustomerReferenceName;
            }
            set { _InvoiceCustomerReferenceName = value; }
        }
        
        #endregion
        
        private SPCSCustomer _Customer = null;
        public SPCSCustomer Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        
        private SPCSProject _Project = null;
        public SPCSProject Project
        {
            get { return _Project; }
            set { _Project = value; }
        }
        
        
        #region +++ IDisposable Members +++
        
        public void Dispose()
        {
            this.InvoiceRows.Clear();
            this.InvoiceRows = null;
            this.Customer = null;
            this.Project = null;
        }
        
        #endregion
        
        #region +++ Overridden Functions +++
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Output.GenerateLine("FAKTURA", 70));
            {
                Output.AppendLineIfAvailable(sb, "Invoice Date", this.InvoiceDate);
                Output.AppendLineIfAvailable(sb, "Order Nr", this.InvoiceCustomerOrderNr);
                Output.AppendLineIfAvailable(sb, "Customer Nr", this.InvoiceCustomerNr);
                Output.AppendLineIfAvailable(sb, "Customer Name", this.InvoiceCustomerName);
                Output.AppendLineIfAvailable(sb, "Your Reference", this.InvoiceCustomerReferenceName);
                Output.AppendLineIfAvailable(sb, "Our Project", this.InvoiceOurProject);
                Output.AppendLineIfAvailable(sb, "Our Reference", this.InvoiceOurReferenceName);
                
                sb.AppendLine("\n Fakturarader:\n");
                sb.AppendLine("\n Antal\t\tEnhet\t\t¡-pris\t\tText\n");
                
                foreach (SPCSInvoiceRow r in this.InvoiceRows)
                {
                    sb.Append(r.ToString());
                }
                
                if (this.InvoiceRows.Count == 0)
                    sb.AppendLine(" (None)");
                    
                sb.Append(Output.GenerateLine("", 70));
                sb.Append("\n");
                
                sb.Append(this.Customer.ToString());
                sb.Append(this.Project.ToString());
                
                sb.Append(Output.GenerateLine("", 70));
            }
            return sb.ToString();
        }
        
        #endregion
    }
}
