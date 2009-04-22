using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Runtime.InteropServices;
using System.Reflection;

namespace InvoiceSystem
{
    [ComVisible(true), GuidAttribute("75a97496-6a8a-11dc-8314-0800200c9a66")]
    [ProgId("InvoiceSystem.Connection")]
    [ClassInterface(ClassInterfaceType.None)]
    public class DataBaseConnection : IDisposable
    {
        private readonly string DATABASE_PROVIDER = "Microsoft.Jet.OLEDB.4.0";
        private readonly string DATABASE_PERSIST_SECURITY_INFO = "False";
        
        private OleDbConnection _DataBaseConnection = null;
        
        #region +++ Constructors +++
        
        public DataBaseConnection()
        {
            _DataBaseConnection = new OleDbConnection();
        }
        
        #endregion
        
        #region +++ IDisposable Members +++
        
        public void Dispose()
        {
            this.Close();
            _DataBaseConnection.Dispose();
            
            GC.SuppressFinalize(this);
        }
        
        #endregion
        
        #region +++ Functions: Connectivity +++
        
        public void Open()
        {
            if (this.IsConnected)
            {
                this.Close();
            }
            
            _DataBaseConnection.ConnectionString = this.GetConnectionString();
            
            try
            {
                this.OnStatusMessageChanged(string.Format("Connecting to database \"{0}\"...", this.DatabasePath));
                _DataBaseConnection.Open();
                this.OnStatusMessageChanged(string.Format("Connected to database: \"{0}\"", this.DatabasePath));
            }
            catch (OleDbException e)
            {
                this.OnStatusMessageChanged(string.Format("ERROR: {0}", e));
                _DataBaseConnection.Close();
            }
        }
        
        public void Close()
        {
            _DataBaseConnection.Close();
            this.OnStatusMessageChanged(string.Format("Disconnected from database \"{0}\"...", this.DatabasePath));
        }
        
        #endregion
        
        #region +++ Functions: DataBase Commands +++
        
        private readonly string INVOICE_QUERY = "SELECT * FROM {0}";
        private readonly string INVOICE_ROW_QUERY = "SELECT * FROM {0} WHERE {1} = {2}";
        
        public int GetInvoiceCount()
        {
            string invoiceQuery = string.Format(INVOICE_QUERY, WorderDataBase.TableNameInvoice);
            OleDbCommand countCommand = new OleDbCommand(invoiceQuery.Replace("*", "COUNT(*)"), _DataBaseConnection);
            return (int)countCommand.ExecuteScalar();
        }
        
        public TypedDataReader GetInvoiceReader()
        {
            string invoiceQuery = string.Format(INVOICE_QUERY, WorderDataBase.TableNameInvoice);
            OleDbCommand getCommand = new OleDbCommand(invoiceQuery, _DataBaseConnection);
            return new TypedDataReader(getCommand.ExecuteReader());
        }
        
        public TypedDataReader GetInvoiceReader(int invoiceId)
        {
            string invoiceRowQuery = string.Format(INVOICE_ROW_QUERY, WorderDataBase.TableNameInvoice, WorderDataBase.InvoiceRowColumnNameInvoiceId, invoiceId);
            OleDbCommand getCommand = new OleDbCommand(invoiceRowQuery, _DataBaseConnection);
            return new TypedDataReader(getCommand.ExecuteReader());
        }
        
        public int GetInvoiceRowCount(int invoiceId)
        {
            string invoiceRowQuery = string.Format(INVOICE_ROW_QUERY, WorderDataBase.TableNameInvoiceRow, WorderDataBase.InvoiceRowColumnNameInvoiceId, invoiceId);
            OleDbCommand countCommand = new OleDbCommand(invoiceRowQuery.Replace("*", "COUNT(*)"), _DataBaseConnection);
            return (int)countCommand.ExecuteScalar();
        }
        
        public TypedDataReader GetInvoiceRowReader(int invoiceId)
        {
            string invoiceRowQuery = string.Format(INVOICE_ROW_QUERY, WorderDataBase.TableNameInvoiceRow, WorderDataBase.InvoiceRowColumnNameInvoiceId, invoiceId);
            OleDbCommand getCommand = new OleDbCommand(invoiceRowQuery, _DataBaseConnection);
            return new TypedDataReader(getCommand.ExecuteReader());
        }
        
        #endregion
        
        #region +++ Functions: Helpers +++
        
        private string GetConnectionString()
        {
            // Guide: http://www.connectionstrings.com/?carrier=access
            
            StringBuilder connectionString = new StringBuilder();
            
            connectionString.Append("Provider=").Append(this.DATABASE_PROVIDER).Append(";");
            connectionString.Append("Data Source=").Append(this.DatabasePath).Append(";");
            connectionString.Append("Persist Security Info=").Append(this.DATABASE_PERSIST_SECURITY_INFO).Append(";");
            
            if (!String.IsNullOrEmpty(this.DatabaseUserId))
                connectionString.Append("User Id=").Append(this.DatabaseUserId).Append(";");
                
            if (!String.IsNullOrEmpty(this.DatabaseUserPassword))
                connectionString.Append("Password=").Append(this.DatabaseUserPassword).Append(";");
                
            return connectionString.ToString();
        }
        
        #endregion
        
        #region +++ Events +++
        
        public delegate void StatusMessageChangedEventHandler(string message);
        public event StatusMessageChangedEventHandler StatusMessageChanged;
        protected virtual void OnStatusMessageChanged(string message)
        {
            if (this.StatusMessageChanged != null)
                this.StatusMessageChanged(message);
        }
        
        public delegate void LogMessageEventHandler(string message);
        public event LogMessageEventHandler LogMessage;
        protected virtual void OnLogMessage(string message)
        {
            if (this.LogMessage != null)
                this.LogMessage(message);
        }
        
        #endregion
        
        #region +++ Properties +++
        
        private string _DatabasePath = @"";
        public string DatabasePath
        {
            get { return _DatabasePath; }
            set { _DatabasePath = value; }
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
        
        #endregion
        
        #region +++ Read-Only Properties +++
        
        public bool IsConnected
        {
            get { return ((_DataBaseConnection != null) ? (_DataBaseConnection.State == ConnectionState.Open) : false); }
        }
        
        #endregion
    }
}
