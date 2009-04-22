using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using InvoiceSystem2SPCS;

namespace InvoiceSystem2SPCSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceSystem2SPCSBridge b = new InvoiceSystem2SPCSBridge();
            {
                b.ProcessValueChanged += new Worder2SPCSBridge.ProcessValueChangedEventHandler(b_ProcessValueChanged);
                
                //b.WorderDatabasePath = @"c:\Inetpub\wwwroot\intranet\db\my_database.mdb";
                b.WorderDatabasePath = @"C:\Users\grimen\Documents\";
                b.WorderDatabaseName = "my_database";
                b.WorderDatabaseUserId = "";
                b.WorderDatabaseUserPassword = "";
                
                //b.SPCSLibraryPath = @"C:\Documents and Settings\All Users\Application Data\SPCS\SPCS Administration\Gemensamma filer\";
                //b.SPCSDatabasePath = @"C:\Documents and Settings\All Users\Application Data\SPCS\SPCS Administration\Företag\";
                b.SPCSLibraryPath = @"C:\ProgramData\SPCS\SPCS Administration\Gemensamma filer";
                b.SPCSDatabasePath = @"C:\ProgramData\SPCS\SPCS Administration\Företag\";
                b.SPCSDatabaseName = "Ovnbol";
                
                b.PerformTransaction("102");
                
                b = null;
            }
            
            Console.Read();
            Process.GetCurrentProcess().Kill();
        }
        
        static void b_ProcessValueChanged(int value, int maxValue, ProcressAction action)
        {
            if (action == ProcressAction.ReadFromDB)
                Console.WriteLine(string.Format("Reading: Invoice {0} of {1}", value, maxValue));
            else
                Console.WriteLine(string.Format("Writing: Invoice {0} of {1}", value, maxValue));
        }
    }
}
