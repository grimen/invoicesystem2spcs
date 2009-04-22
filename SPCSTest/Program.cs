using System;
using System.Collections.Generic;
using System.Text;

using SPCS;

namespace SPCSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SPCSConnection c = new SPCSConnection())
            {
                c.Open();
                
                if (c.IsConnected)
                {
                    SPCSInvoice i = new SPCSInvoice();
                    {
                        i.InvoiceCustomerNr = "101";
                        i.InvoiceDate = DateTime.Parse("2007-01-01");
                        
                        SPCSInvoiceRow r = new SPCSInvoiceRow();
                        {
                            r.InvoiceRowArticleNr = "101";
                            r.InvoiceRowArticleText = "Artikel1";
                            r.InvoiceRowQuantity = 20;
                            //r.PriceEach = 50;
                            r.InvoiceRowUnit = "St";
                        }
                        
                        i.InvoiceRows.Add(r);
                        
                        i.Save();
                        
                    }
                    c.Close();
                }
                else
                {
                    Console.WriteLine("NOT CONNECTED");
                }
            }
            
            Console.Read();
        }
    }
}
