using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    /*
     Code did nit handle double and decimal values for 1. Cases fpr double and decimal were added.         
    */

    public static class TESTModule
    {
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);
                case float floatValue when floatValue == 1.0f:
                    return leveler(floatValue);

                case double doubleValue when doubleValue == 1.0d:
                    return leveler(doubleValue);
                case decimal decimalValue when decimalValue == 1.0m:
                    return levelerM(decimalValue);

                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;

            decimal levelerM(decimal amount) => amount - 0.1m * 10m;
            double leveler(double amount) => amount - 0.1f * 10f;            
        }

        public static object Test(double amount)
        {
            var test = amount - 0.1f * 10f;
            return test;
        }
    }

}
