using System;
using System.Collections.Generic;
using System.Text;

namespace SPCS
{
    public class SPCSProject : SPCSIReferenceRecordObject
    {
        public SPCSProject() { }
        
        public bool SaveIfNotAvailable()
        {
            bool save = !this.Exists();
            Console.Write("PROJECT exists?...");
            
            if (save)
            {
                Console.WriteLine("NO");
                this.Save();
            }
            else Console.WriteLine("YES");
            
            return save;
        }
        
        public bool Save()
        {
            Console.WriteLine("Saving PROJECT...");
            
            int pProject = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_PROJECT);
            {
                SPCSAPI.SPCSWriteString(pProject, SPCSAPI.ADK_PROJECT_CODE_OF_PROJECT, this.ProjectNr, string.Format("ProjectNr = {0}", this.ProjectNr));
                SPCSAPI.SPCSWriteString(pProject, SPCSAPI.ADK_PROJECT_NAME, this.ProjectName, string.Format("ProjectName = {0}", this.ProjectName));
                SPCSAPI.SPCSWriteString(pProject, SPCSAPI.ADK_PROJECT_CUSTOMER_NUMBER, this.ProjectCustomerNr, string.Format("ProjectCustomerNr = {0}", this.ProjectCustomerNr));
                SPCSAPI.SPCSWriteDate(pProject, SPCSAPI.ADK_PROJECT_DATE_OF_BEGINNING, this.ProjectStartTime, string.Format("ProjectStartTime = {0}", this.ProjectStartTime));
                SPCSAPI.SPCSWriteDate(pProject, SPCSAPI.ADK_PROJECT_DATE_OF_END, this.ProjectEndTime, string.Format("ProjectEndTime = {0}", this.ProjectEndTime));
            }
            
            // Write to SPCS
            SPCSAPI.SPCSAdd(pProject, "Save PROJECT as " + this.ProjectNr);
            
            // Clean up
            SPCSAPI.SPCSDeleteStruct(pProject, "Clean up PROJECT");
            
            return true;
        }
        
        public bool Exists()
        {
            int pProject = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_PROJECT);
            
            SPCSAPI.AdkResetStruct(pProject);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetSortOrder(pProject, SPCSAPI.ADK_SORT_ORDER.eProjectCode);
            result = SPCSAPI.AdkFirst(pProject);
            
            string projectName = null;
            
            while (result.lRc != SPCSAPI.ADKE_NO_DB_OPEN && result.lRc != SPCSAPI.ADKE_EOF)
            {
                projectName = SPCSAPI.SPCSGetString(pProject, SPCSAPI.ADK_PROJECT_NAME);
                
                if (this.ProjectName.Equals(projectName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
                    
                result = SPCSAPI.AdkNext(pProject);
            }
            
            SPCSAPI.AdkDeleteStruct(pProject);
            
            return false;
        }
        
        public string GetId()
        {
            int pProject = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_PROJECT);
            
            SPCSAPI.AdkResetStruct(pProject);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetSortOrder(pProject, SPCSAPI.ADK_SORT_ORDER.eProjectCode);
            result = SPCSAPI.AdkFirst(pProject);
            
            string projectName = null;
            
            while (result.lRc != SPCSAPI.ADKE_NO_DB_OPEN && result.lRc != SPCSAPI.ADKE_EOF)
            {
                projectName = SPCSAPI.SPCSGetString(pProject, SPCSAPI.ADK_PROJECT_NAME);
                
                if (this.ProjectName.Equals(projectName, StringComparison.InvariantCultureIgnoreCase))
                    return SPCSAPI.SPCSGetString(pProject, SPCSAPI.ADK_PROJECT_CODE_OF_PROJECT);
                    
                result = SPCSAPI.AdkNext(pProject);
                
                if (result.lRc == SPCSAPI.ADKE_NO_DB_OPEN)
                    return null;
            }
            
            string projectNrString = SPCSAPI.SPCSGetString(pProject, SPCSAPI.ADK_PROJECT_CODE_OF_PROJECT);
            SPCSAPI.AdkDeleteStruct(pProject);
            
            double projectNr = int.Parse(projectNrString) + 1;
            projectNrString = ((result.lRc != SPCSAPI.ADKE_NOT_FOUND) ? projectNr.ToString() : null);
            
            return projectNrString;
        }
        
        #region +++ Properties +++
        
        private string _ProjectNr = null;
        public string ProjectNr
        {
            get { return _ProjectNr; }
            set { _ProjectNr = value; }
        }
        
        private string _ProjectCustomerNr = null;
        public string ProjectCustomerNr
        {
            get { return _ProjectCustomerNr; }
            set { _ProjectCustomerNr = value; }
        }
        
        private string _ProjectName = null;
        public string ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = SPCSAPI.PreProcessString(value, 50); }
        }
        
        private DateTime _ProjectStartTime = DateTime.MinValue;
        public DateTime ProjectStartTime
        {
            get { return _ProjectStartTime; }
            set { _ProjectStartTime = value; }
        }
        
        private DateTime _ProjectEndTime = DateTime.MinValue;
        public DateTime ProjectEndTime
        {
            get { return _ProjectEndTime; }
            set { _ProjectEndTime = value; }
        }
        
        #endregion
        
        #region +++ Overridden Functions +++
        
        public override string ToString()
        {
            return string.Empty;
        }
        
        #endregion
    }
}
