using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ValidateStringInput
    {
        public bool validateStringInput(String arg)
        {
            if (arg.Contains(' ') || arg.Contains("'"))
                return false;
            else if (arg.Length < 8 || arg.Length > 30)
                return false;
            else if (!arg.Any(c => char.IsUpper(c)))
                return false;
            else
                return true;
        }
    }
}
