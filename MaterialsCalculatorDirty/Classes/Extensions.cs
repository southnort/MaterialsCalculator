using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsCalculatorDirty.Classes
{
    public static class Extensions
    {
        public static DateTime ToDateTime(this int unixTime)
        {
            try
            {
                DateTime result = new DateTime(unixTime);
                return result;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return DateTime.MinValue;
            }
        }
    }
}
