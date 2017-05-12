using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wen.OurOfficeConverter.WinForm.Main.Helpers
{
    public static class ExtendsMethod
    {
        public static bool IsEqual(this string a, string b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
