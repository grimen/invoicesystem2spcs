using System;
using System.Collections.Generic;
using System.Text;

namespace SPCS
{
    public class SPCSCustomer : SPCSIReferenceRecordObject
    {
        public SPCSCustomer() { }
        
        #region +++ SPCSIReferenceRecordType +++
        
        public bool SaveIfNotAvailable()
        {
            bool save = !this.Exists();
            
            Console.Write("CUSTOMER exists?...");
            
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
            Console.WriteLine("Saving CUSTOMER...");
            
            int pCustomer = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_CUSTOMER);
            {
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_NUMBER, this.CustomerNr, "CustomerNr " + this.CustomerNr);
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_REFERENCE, this.CustomerReference, "CustomerReference " + this.CustomerReference);
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_NAME, this.CustomerName, "CustomerName " + this.CustomerName);
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_MAILING_ADDRESS, this.CustomerPostalAdress, "CustomerPostalAdress ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_MAILING_ADDRESS2, this.CustomerPostalAdress2, "CustomerPostalAdress2 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_ZIPCODE, this.CustomerPostalCode, "CustomerPostalCode ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_CITY, this.CustomerPostalCity, "CustomerPostalCity ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_COUNTRY, this.CustomerPostalCountry, "CustomerPostalCountry ");
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_TELEPHONE, this.CustomerPhone, "CustomerPhone ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_TELEPHONE2, this.CustomerPhone2, "CustomerPhone2 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_TELEPHONE3, this.CustomerPhone3, "CustomerPhone3 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_FAX, this.CustomerFax, "CustomerFax ");
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_DELIVERY_NAME, this.CustomerDeliveryName, "CustomerDeliveryName ");
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_MAILING_ADDRESS, this.CustomerDeliveryPostalAdress, "CustomerDeliveryPostalAdress ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_MAILING_ADDRESS2, this.CustomerDeliveryPostalAdress2, "CustomerDeliveryPostalAdress2 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_ZIPCODE, this.CustomerDeliveryPostalCode, "CustomerDeliveryPostalCode ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_CITY, this.CustomerDeliveryPostalCity, "CustomerDeliveryPostalCity ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_COUNTRY, this.CustomerDeliveryPostalCountry, "CustomerDeliveryPostalCountry ");
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_DELIVERY_TELEPHONE, this.CustomerDeliveryPhone, "CustomerDeliveryPhone ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_DELIVERY_TELEPHONE2, this.CustomerDeliveryPhone2, "CustomerDeliveryPhone2 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_DELIVERY_TELEPHONE3, this.CustomerDeliveryPhone3, "CustomerDeliveryPhone3 ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_DELIVERY_FAX, this.CustomerDeliveryFax, "CustomerDeliveryFax ");
                
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_ORGANISATION_NUMBER, this.CustomerOrganisationNr, "CustomerOrganisationNr ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_VAT_NUMBER, this.CustomerVATNr, "CustomerVATNr ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_SHORT_NAME, this.CustomerShortName, "CustomerShortName ");
                SPCSAPI.SPCSWriteString(pCustomer, SPCSAPI.ADK_CUSTOMER_EMAIL, this.CustomerEmail, "CustomerEmail ");
                
            }
            
            // Write to SPCS
            SPCSAPI.SPCSAdd(pCustomer, "Save CUSTOMER as " + this.CustomerNr);
            
            // Clean up
            SPCSAPI.SPCSDeleteStruct(pCustomer, "Clean up KUND");
            
            return true;
        }
        
        public bool Exists()
        {
            int pCustomer = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_CUSTOMER);
            
            SPCSAPI.AdkResetStruct(pCustomer);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetSortOrder(pCustomer, SPCSAPI.ADK_SORT_ORDER.eCustomerNr);
            result = SPCSAPI.AdkFirst(pCustomer);
            
            string customerName = null;
            
            while (result.lRc != SPCSAPI.ADKE_NO_DB_OPEN && result.lRc != SPCSAPI.ADKE_EOF)
            {
                customerName = SPCSAPI.SPCSGetString(pCustomer, SPCSAPI.ADK_CUSTOMER_NAME);
                
                if (this.CustomerName.Equals(customerName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
                    
                result = SPCSAPI.AdkNext(pCustomer);
            }
            
            SPCSAPI.AdkDeleteStruct(pCustomer);
            
            return false;
        }
        
        public string GetId()
        {
            int pCustomer = SPCSAPI.AdkCreateData(SPCSAPI.ADK_DB_CUSTOMER);
            
            SPCSAPI.AdkResetStruct(pCustomer);
            
            SPCSAPI.ADKERROR result;
            result = SPCSAPI.AdkSetSortOrder(pCustomer, SPCSAPI.ADK_SORT_ORDER.eCustomerNr);
            result = SPCSAPI.AdkFirst(pCustomer);
            
            string customerName = null;
            
            while (result.lRc != SPCSAPI.ADKE_NO_DB_OPEN && result.lRc != SPCSAPI.ADKE_EOF)
            {
                customerName = SPCSAPI.SPCSGetString(pCustomer, SPCSAPI.ADK_CUSTOMER_NAME);
                
                if (this.CustomerName.Equals(customerName, StringComparison.InvariantCultureIgnoreCase))
                    return SPCSAPI.SPCSGetString(pCustomer, SPCSAPI.ADK_CUSTOMER_NUMBER);
                    
                result = SPCSAPI.AdkNext(pCustomer);
                
                if (result.lRc == SPCSAPI.ADKE_NO_DB_OPEN)
                    return null;
            }
            
            string customerNrString = SPCSAPI.SPCSGetString(pCustomer, SPCSAPI.ADK_CUSTOMER_NUMBER);
            SPCSAPI.AdkDeleteStruct(pCustomer);
            
            double customerNr = int.Parse(customerNrString) + 1;
            customerNrString = ((result.lRc != SPCSAPI.ADKE_NOT_FOUND) ? customerNr.ToString() : null);
            
            return customerNrString;
        }
        
        #endregion
        
        #region +++ Properties +++
        
        private string _CustomerNr = null;
        public string CustomerNr
        {
            get { return _CustomerNr; }
            set { _CustomerNr = value; }
        }
        
        private string _CustomerName = null;
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        
        private string _CustomerPostalAdress = null;
        public string CustomerPostalAdress
        {
            get { return _CustomerPostalAdress; }
            set { _CustomerPostalAdress = value; }
        }
        
        private string _CustomerPostalAdress2 = null;
        public string CustomerPostalAdress2
        {
            get { return _CustomerPostalAdress2; }
            set { _CustomerPostalAdress2 = value; }
        }
        
        private string _CustomerPostalCode = null;
        public string CustomerPostalCode
        {
            get { return _CustomerPostalCode; }
            set { _CustomerPostalCode = value; }
        }
        
        private string _CustomerPostalCity = null;
        public string CustomerPostalCity
        {
            get { return _CustomerPostalCity; }
            set { _CustomerPostalCity = value; }
        }
        
        private string _CustomerPostalCountry = null;
        public string CustomerPostalCountry
        {
            get { return _CustomerPostalCountry; }
            set { _CustomerPostalCountry = value; }
        }
        
        private string _CustomerPhone = null;
        public string CustomerPhone
        {
            get { return _CustomerPhone; }
            set { _CustomerPhone = value; }
        }
        
        private string _CustomerPhone2 = null;
        public string CustomerPhone2
        {
            get { return _CustomerPhone2; }
            set { _CustomerPhone2 = value; }
        }
        
        private string _CustomerPhone3 = null;
        public string CustomerPhone3
        {
            get { return _CustomerPhone3; }
            set { _CustomerPhone3 = value; }
        }
        
        private string _CustomerFax = null;
        public string CustomerFax
        {
            get { return _CustomerFax; }
            set { _CustomerFax = value; }
        }
        
        private string _CustomerDeliveryName = null;
        public string CustomerDeliveryName
        {
            get { return _CustomerDeliveryName; }
            set { _CustomerDeliveryName = value; }
        }
        
        private string _CustomerDeliveryPostalAdress = null;
        public string CustomerDeliveryPostalAdress
        {
            get { return _CustomerDeliveryPostalAdress; }
            set { _CustomerDeliveryPostalAdress = value; }
        }
        
        private string _CustomerDeliveryPostalAdress2 = null;
        public string CustomerDeliveryPostalAdress2
        {
            get { return _CustomerDeliveryPostalAdress2; }
            set { _CustomerDeliveryPostalAdress2 = value; }
        }
        
        private string _CustomerDeliveryPostalCode = null;
        public string CustomerDeliveryPostalCode
        {
            get { return _CustomerDeliveryPostalCode; }
            set { _CustomerDeliveryPostalCode = value; }
        }
        
        private string _CustomerDeliveryPostalCity = null;
        public string CustomerDeliveryPostalCity
        {
            get { return _CustomerDeliveryPostalCity; }
            set { _CustomerDeliveryPostalCity = value; }
        }
        
        private string _CustomerDeliveryPostalCountry = null;
        public string CustomerDeliveryPostalCountry
        {
            get { return _CustomerDeliveryPostalCountry; }
            set { _CustomerDeliveryPostalCountry = value; }
        }
        
        private string _CustomerDeliveryPhone = null;
        public string CustomerDeliveryPhone
        {
            get { return _CustomerDeliveryPhone; }
            set { _CustomerDeliveryPhone = value; }
        }
        
        private string _CustomerDeliveryPhone2 = null;
        public string CustomerDeliveryPhone2
        {
            get { return _CustomerDeliveryPhone2; }
            set { _CustomerDeliveryPhone2 = value; }
        }
        
        private string _CustomerDeliveryPhone3 = null;
        public string CustomerDeliveryPhone3
        {
            get { return _CustomerDeliveryPhone3; }
            set { _CustomerDeliveryPhone3 = value; }
        }
        
        private string _CustomerDeliveryFax = null;
        public string CustomerDeliveryFax
        {
            get { return _CustomerDeliveryFax; }
            set { _CustomerDeliveryFax = value; }
        }
        
        private string _CustomerReference = null;
        public string CustomerReference
        {
            get { return _CustomerReference; }
            set { _CustomerReference = value; }
        }
        
        private string _CustomerOrganisationNr = null;
        public string CustomerOrganisationNr
        {
            get { return _CustomerOrganisationNr; }
            set { _CustomerOrganisationNr = value; }
        }
        
        private string _CustomerVATNr = null;
        public string CustomerVATNr
        {
            get { return _CustomerVATNr; }
            set { _CustomerVATNr = value; }
        }
        
        private string _CustomerShortName = null;
        public string CustomerShortName
        {
            get { return _CustomerShortName; }
            set { _CustomerShortName = value; }
        }
        
        private string _CustomerEmail = null;
        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
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
