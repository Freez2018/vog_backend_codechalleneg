using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey"
        };
        public static void TestQuestion()
        {
            foreach (var item in NamesList)
            {
                Console.WriteLine(item);
            }
        }
    }

}
