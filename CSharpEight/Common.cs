using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net5Demo.CSharpEight
{
    public class Common
    {
        public bool IsNumber(string strNumber) {
            string Rx = @"^[1-9]\d*$";
            if (Regex.IsMatch(strNumber, Rx))
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}
