using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool ValidateIntInput(string input)
        {
            if (Int32.TryParse(input, out int answer) && !string.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateStringInput(string input)
        {
            if (!ValidateIntInput(input) && !string.IsNullOrEmpty(input))
                return true;
            else return false;
        }
    }
}
