using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionLibrary
{
    public class Calculate
    {
        public static double CalculateTuition(double tuition, double percentIncrease, int years)
        {
            for (int i = 1; i <= years; i++)
            {
                tuition += tuition * percentIncrease;

                return tuition;
            }
            return tuition;
        }
    }
}
