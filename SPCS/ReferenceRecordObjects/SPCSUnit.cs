using System;
using System.Collections.Generic;
using System.Text;

namespace SPCS
{
    public class SPCSUnit : SPCSIReferenceRecordObject
    {
        public SPCSUnit() { }
        
        public bool SaveIfNotAvailable()
        {
            bool save = !this.Exists();
            if (save)
            {
                this.Save();
            }
            return save;
        }
        
        public bool Save()
        {
            int pUnit = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_CODE_OF_UNIT);
            {
                SPCSAPI.SPCSWriteString(pUnit, SPCSAPI.ADK_CODE_OF_UNIT_CODE, this.UnitCode, "UnitCode");
                SPCSAPI.SPCSWriteString(pUnit, SPCSAPI.ADK_CODE_OF_UNIT_TEXT, this.UnitText, "UnitText");
                SPCSAPI.SPCSWriteString(pUnit, SPCSAPI.ADK_CODE_OF_UNIT_DECIMALS, this.UnitDecimalPrecision.ToString(), "UnitDecimalPrecision");
            }
            
            // Write to SPCS
            SPCSAPI.SPCSAdd(pUnit, "Spara enhet");
            
            // Clean up
            SPCSAPI.SPCSDeleteStruct(pUnit, "Rensa upp enhet");
            
            return true;
        }
        
        public bool Exists()
        {
            int pUnit = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_CODE_OF_UNIT);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetStr(pUnit, SPCSAPI.ADK_CODE_OF_UNIT_CODE, this.UnitCode);
            result = SPCSAPI.AdkSetSortOrder(pUnit, SPCSAPI.ADK_SORT_ORDER.eCodeOfUnit);
            result = SPCSAPI.AdkFind(pUnit);
            
            SPCSAPI.AdkDeleteStruct(pUnit);
            
            return (result.lRc != SPCSAPI.ADKE_NOT_FOUND);
        }
        
        public string GetId()
        {
            return null;
        }
        
        #region +++ Properties +++
        
        private string _UnitCode = null;
        public string UnitCode
        {
            get { return _UnitCode; }
            set { _UnitCode = value; }
        }
        
        private string _UnitText = null;
        public string UnitText
        {
            get { return _UnitText; }
            set { _UnitText = value; }
        }
        
        private double _UnitDecimalPrecision = 0;
        public double UnitDecimalPrecision
        {
            get { return _UnitDecimalPrecision; }
            set { _UnitDecimalPrecision = value; }
        }
        
        #endregion
    }
}
