using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTestEx
{
    public class HTMLFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}
