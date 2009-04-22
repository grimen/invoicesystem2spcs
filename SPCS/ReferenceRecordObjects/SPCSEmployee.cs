using System;
using System.Collections.Generic;
using System.Text;

namespace SPCS.ReferenceTypes
{
    public class SPCSEmployee : SPCSIReferenceRecordObject
    {
        public SPCSEmployee() { }
        
        #region +++ SPCSIDataEntry Members +++
        
        public bool SaveIfNotAvailable()
        {
            //throw new Exception("The method or operation is not implemented.");
            return false;
        }
        
        public bool Save()
        {
            //throw new Exception("The method or operation is not implemented.");
            return false;
        }
        
        public bool Exists()
        {
            //throw new Exception("The method or operation is not implemented.");
            return false;
        }
        
        public string GetId()
        {
            //throw new Exception("The method or operation is not implemented.");
            return null;
        }
        
        #endregion
    }
}
