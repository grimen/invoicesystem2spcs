using System;
using System.Data.OleDb;
using System.Globalization;

namespace InvoiceSystem
{
    public sealed class TypedDataReader : IDisposable
    {
        private OleDbDataReader _DataReader = null;
        
        public TypedDataReader(OleDbDataReader reader)
        {
            this._DataReader = reader;
        }
        
        public int GetInt(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (ordinal < 0) return 0;
            int data = (_DataReader.IsDBNull(ordinal)) ? 0 : int.Parse(_DataReader[column].ToString());
            return data;
        }
        
        public float GetFloat(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (ordinal < 0 || _DataReader.IsDBNull(ordinal)) return 0f;
            string value = _DataReader[column].ToString().Replace(',', '.');
            float data;
            float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out data);
            return data;
        }
        
        public double GetDouble(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (ordinal < 0 || _DataReader.IsDBNull(ordinal)) return 0d;
            string value = _DataReader[column].ToString().Replace(',', '.');
            double data;
            double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out data);
            return data;
        }
        
        public bool GetBool(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (ordinal < 0) return false;
            bool data;
            bool.TryParse(_DataReader[column].ToString(), out data);
            //bool data = (_DataReader.IsDBNull(ordinal)) ? false : bool.Parse(_DataReader[column].ToString
            return data;
        }
        
        public String GetString(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (!this.HasData(ordinal)) return string.Empty;
            String data = _DataReader[column].ToString();
            return data;
        }
        
        public DateTime GetDateTime(String column)
        {
            int ordinal = this.GetOrdinal(column);
            if (!this.HasData(ordinal)) return DateTime.MinValue;
            DateTime data = (_DataReader.IsDBNull(ordinal)) ? DateTime.MinValue : DateTime.Parse(_DataReader[column].ToString());
            return data;
        }
        
        public int GetOrdinal(string columnName)
        {
            try
            {
                int ordinal = _DataReader.GetOrdinal(columnName);
                return ordinal;
            }
            catch (IndexOutOfRangeException)
            {
                return -1;
            }
        }
        
        public bool HasColumn(string columnName)
        {
            try {
                int ordinal = _DataReader.GetOrdinal(columnName);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
        
        public bool HasData(int ordinal) {
            return (_DataReader.HasRows && !_DataReader.IsDBNull(ordinal) && ordinal > -1);
        }
        
        public bool Read()
        {
            return this._DataReader.Read();
        }
        
        #region +++ IDisposable Members +++
        
        public void Dispose()
        {
            this._DataReader.Close();
            this._DataReader.Dispose();
            this._DataReader = null;
        }
        
        #endregion
    }
}
