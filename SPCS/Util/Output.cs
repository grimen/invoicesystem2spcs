using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SPCS
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Output
    {
        public static void AppendIfAvailable(StringBuilder sb, object value)
        {
            if (value != null && !String.IsNullOrEmpty(value.ToString()))
            {
                sb.Append(value.ToString());
            }
            else sb.Append("-");
        }
        
        public static void AppendLineIfAvailable(StringBuilder sb, string label, string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                sb.Append(" ").Append(label).Append(": ").Append(' ', 25 - label.Length);
                sb.Append("").AppendLine(value);
            }
        }
        
        public static void AppendLineIfAvailable(StringBuilder sb, string label, double value)
        {
            if (!double.IsNaN(value))
            {
                sb.Append(" ").Append(label).Append(": ").Append(' ', 25 - label.Length);
                sb.Append("").AppendLine(value.ToString());
            }
        }
        
        public static void AppendIfAvailable(StringBuilder sb, bool value, string trueValue, string falseValue)
        {
            sb.Append("").Append(value);
        }
        
        public static void AppendLineIfAvailable(StringBuilder sb, string label, bool value)
        {
            Output.AppendLineIfAvailable(sb, label, value, "TRUE", "FALSE");
        }
        
        public static void AppendLineIfAvailable(StringBuilder sb, string label, bool value, string trueValue, string falseValue)
        {
            sb.Append(" ").Append(label).Append(": ").Append(' ', 25 - label.Length);
            sb.Append("").AppendLine((value ? trueValue : falseValue));
        }
        
        public static void AppendIfAvailable(StringBuilder sb, DateTime value)
        {
            if (value != DateTime.MinValue)
            {
                sb.Append(", ").Append(value.ToString().Substring(0, 10));
            }
        }
        
        public static void AppendLineIfAvailable(StringBuilder sb, string label, DateTime value)
        {
            if (value != DateTime.MinValue)
            {
                sb.Append(" ").Append(label).Append(": ").Append(' ', 25 - label.Length);
                sb.Append("").AppendLine(value.ToString().Substring(0, 10));
            }
        }
        
        public static string GenerateLine(string label, int width)
        {
            StringBuilder sb = new StringBuilder("\n");
            const char lineChar = '_';
            
            sb.Append(lineChar, 3);
            
            int labelLength = label.Length;
            if (!String.IsNullOrEmpty(label))
            {
                sb.Append(" ").Append(label).Append(" ");
                labelLength += 2;
            }
            
            sb.Append(lineChar, width - (3 + labelLength));
            sb.Append("\n\n");
            
            return sb.ToString();
        }
    }
}
