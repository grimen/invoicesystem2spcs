using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace InvoiceSystem
{
    [ComVisible(true), GuidAttribute("000717ae-6a8b-11dc-8314-0800200c9a66")]
    [ProgId("InvoiceSystem.DB")]
    [ClassInterface(ClassInterfaceType.None)]
    public static class DataBase
    {
        #region +++ Read-Only Properties +++
        
        public static string TableNameInvoice
        {
            get { return "spcs_invoice"; }
        }
        
        public static string TableNameInvoiceRow
        {
            get { return "spcs_invoice"; }
        }
        
        public static string InvoiceColumnNameCustomerNr
        {
            get { return "company_id"; }
        }
        
        public static string InvoiceColumnNameCustomerName
        {
            get { return "company_name"; }
        }
        
        public static string InvoiceColumnNameCustomerReferenceFirstName
        {
            get { return "your_reference_first_name"; }
        }
        
        public static string InvoiceColumnNameCustomerReferenceLastName
        {
            get { return "your_reference_last_name"; }
        }
        
        public static string InvoiceColumnNameCustomerOrderNr
        {
            get { return "order_nr"; }
        }
        
        public static string InvoiceColumnNameOurReferenceFirstName
        {
            get { return "our_reference_first_name"; }
        }
        
        public static string InvoiceColumnNameOurReferenceLastName
        {
            get { return "our_reference_last_name"; }
        }
        
        public static string InvoiceColumnNameDate
        {
            get { return "invoice_date"; }
        }
        
        public static string InvoiceColumnNameOurProject
        {
            get { return "project_name"; }
        }
        
        public static string InvoiceRowColumnNameArticleText
        {
            get { return "row_text"; }
        }
        
        public static string InvoiceRowColumnNamePriceEach
        {
            get { return "row_price_each"; }
        }
        
        public static string InvoiceRowColumnNameQuantity
        {
            get { return "row_quantity"; }
        }
        
        public static string InvoiceRowColumnNameTotalAmount
        {
            get { return "row_amount"; }
        }
        
        public static string InvoiceRowColumnNameInvoiceId
        {
            get { return "invoice_id"; }
        }
        
        public static string InvoiceRowColumnNameFkInvoiceId
        {
            get { return "invoice_id"; }
        }
        
        #endregion
    }
}
