using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTracking
{
    public class General
    {
        public static bool isNumber(KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
