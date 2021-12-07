using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailCalculatorLibrary
{
    public class Calculate
    {
        public static double CalculateRetail(double wholesale, double markup)
        {
            double markupPercent = markup / 100;
            double retailPrice;

            retailPrice = wholesale + (wholesale * markupPercent);
            return retailPrice;
        }
    }
}
