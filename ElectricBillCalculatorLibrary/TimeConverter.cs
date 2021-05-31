using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerConsumptionCalculatorLibrary
{
    public static class TimeConverter
    {
        public static double ConvertTime(object choice, double timeDuration)
        {
            double output = 0.0;

            switch(choice)
            {
                case "Second":
                    output = timeDuration / 3600;
                    break;
                case "Minute":
                    output = timeDuration / 60;
                    break;
                case "Hour":
                    output = timeDuration / 60;
                    break;
            }

            return output;
        }
    }
}
