using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMS_Definitive
{
    class currency
    {
        public static string toCurrency(double val)
        {
            decimal value = Convert.ToDecimal(val);
            return value.ToString("F2");
        }

        public static string toCurrency(string val)
        {
            decimal value = Convert.ToDecimal(val);
            return value.ToString("F2");
        }
    }
}
