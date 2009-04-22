---------------------------------
 InvoiceSystem2SPCS
---------------------------------

SUMMARY:
  A fully functional C# implementation of a generic database-to-SPCS export of invoices, customers, projects, units, etc from an existing database to Visma SPCS Admin 1000/2000. Quite efficient; managed to export 15,000 invoices (with data such as projects/customers/units) within a minute.
  
REQUIREMENTS:
  
  In path: "C:\Windows\System32\"
  
  SPCS-libraries:
    
    * Adk.dll (from Visma SPCS 1000/2000 Development Kit)
    
  From thi implementation:
    
    * SPCSImplementation.dll
    * InvoiceSystem2SPCSBridge.dll
    * InvoiceSystem.dll

NOTES:
  
  * No unit/functional testing, but basic sample programs testing with dummy data, but it should very well.
  * Code contains instructions to COM-enable the libraries for use with older versions of ASP, but never tested this thoroughly - *should* work.
    