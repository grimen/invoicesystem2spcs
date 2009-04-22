
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace SPCS
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class SPCSInvoiceRow : IDisposable
    {
        #region +++ Constructors +++
        
        public SPCSInvoiceRow()
        {
        }
        
        #endregion
        
        #region +++ Properties +++
        
        private string _InvoiceRowArticleNr = null;
        public string InvoiceRowArticleNr
        {
            get { return _InvoiceRowArticleNr; }
            set { _InvoiceRowArticleNr = value; }
        }
        
        private string _InvoiceRowArticleText = null;
        public string InvoiceRowArticleText
        {
            get { return _InvoiceRowArticleText; }
            set { _InvoiceRowArticleText = value; }
        }
        
        private double _InvoiceRowQuantity = double.NaN;
        public double InvoiceRowQuantity
        {
            get { return _InvoiceRowQuantity; }
            set { _InvoiceRowQuantity = value; }
        }
        
        private double _InvoiceRowPriceEach = double.NaN;
        public double InvoiceRowPriceEach
        {
            get { return _InvoiceRowPriceEach; }
            set { _InvoiceRowPriceEach = value; }
        }
        
        private string _InvoiceRowUnit = null;
        public string InvoiceRowUnit
        {
            get { return _InvoiceRowUnit; }
            set { _InvoiceRowUnit = value; }
        }
        
        private string _InvoiceRowProject = null;
        public string InvoiceRowProject
        {
            get { return _InvoiceRowProject; }
            set { _InvoiceRowProject = value; }
        }
        
        #endregion
        
        #region +++ IDisposable Members +++
        
        public void Dispose()
        {
        }
        
        #endregion
        
        #region +++ Overridden Functions +++
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            {
                //Output.AppendIfAvailable(sb, this.InvoiceRowArticleNr);
                sb.Append(" ");
                Output.AppendIfAvailable(sb, this.InvoiceRowQuantity);
                sb.Append("\t\t");
                Output.AppendIfAvailable(sb, this.InvoiceRowUnit);
                sb.Append("\t\t");
                Output.AppendIfAvailable(sb, this.InvoiceRowPriceEach);
                sb.Append("\t\t");
                Output.AppendIfAvailable(sb, this.InvoiceRowArticleText);
                sb.Append("\n");
            }
            return sb.ToString();
        }
        
        #endregion
    }
}