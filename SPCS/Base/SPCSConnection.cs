using System;
using System.Runtime.InteropServices;

namespace SPCS
{
    /// <summary>
    /// Summary description for SPCSConnection
    /// </summary>
    [ComVisible(true), GuidAttribute("27d4ea88-6a8b-11dc-8314-0800200c9a66")]
    [ProgId("SPCS.Connection")]
    [ClassInterface(ClassInterfaceType.None)]
    public class SPCSConnection : IDisposable
    {
        #region +++ Constants +++
        
        private static readonly string SPCS_DEFAULT_DB_PATH = @"C:\ProgramData\SPCS\SPCS Administration\Företag\Ovnbol";
        private static readonly string SPCS_DEFAULT_LIB_PATH = @"C:\ProgramData\SPCS\SPCS Administration\Gemensamma filer"; 
        
        #endregion
        
        #region +++ Contructors +++
        
        public SPCSConnection() { }
        
        #endregion
        
        #region +++ Functions: Connectivity +++
        
        [ComVisible(true)]
        public void Open()
        {
            this.Open(SPCS_DEFAULT_DB_PATH, SPCS_DEFAULT_LIB_PATH);
        }
        
        [ComVisible(true)]
        public void Open(string databasePath)
        {
            this.Open(databasePath, SPCS_DEFAULT_LIB_PATH);
        }
        
        [ComVisible(true)]
        public void Open(string databasePath, string libraryPath)
        {
            if (this.IsConnected)
            {
                this.Close();
            }
            
            this.LibraryPath = libraryPath;
            this.DatabasePath = databasePath;
            
            try
            {
                SPCSAPI.ADKERROR error;
                error = SPCSAPI.AdkOpen(this.LibraryPath, this.DatabasePath);
                SPCSAPI.SPCSTry(error, "Anslutning till SPCS");
            }
            catch
            {
                this.IsConnected = false;
                return;
            }
            this.IsConnected = true;
        }
        
        [ComVisible(true)]
        public void Close()
        {
            SPCSAPI.AdkClose();
            this.IsConnected = false;
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
        
        private string _LibraryPath = string.Empty;
        [ComVisible(true)]
        public string LibraryPath
        {
            get { return _LibraryPath; }
            set { _LibraryPath = value; }
        }
        
        private string _DatabasePath = string.Empty;
        [ComVisible(true)]
        public string DatabasePath
        {
            get { return _DatabasePath; }
            set { _DatabasePath = value; }
        }
        
        private bool _IsConnected;
        [ComVisible(true)]
        public bool IsConnected
        {
            get { return _IsConnected; }
            set { _IsConnected = value; }
        }
        
        #endregion
        
        #region +++ IDisposable Members +++
        
        [ComVisible(true)]
        public void Dispose()
        {
            if (this.IsConnected)
            {
                this.Close();
            }
            
            GC.SuppressFinalize(this);
        }
        
        #endregion
    }
}
