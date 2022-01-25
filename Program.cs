using System;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Built Data Types Calculated In Min Max
            /*
               int i= 0;
               Console.WriteLine("Min={0}",int.MinValue);
               Console.WriteLine("Max={0}", int.MaxValue);
            */

            //Escape Squence
            /*
            string Name = "One\nTwo\nThree";
            Console.WriteLine(Name);
            */

            /*bool? Areyoustudent = null;
            if (Areyoustudent == true)
            {
                Console.WriteLine("Yes");
            }
            else if (Areyoustudent == false)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("Not Selected");
            }
            */


            //Null Coalescing Operator

            /*
             int? TicketonSales = null;
            int AvailableTickets = TicketonSales ?? 0;
            Console.WriteLine("AvailableTickets ={0}", AvailableTickets);
            */

            //parse method
            /*
            string strnumber = "100";

            int i = int.Parse(strnumber);

            Console.WriteLine(i);
            */

            //try parse method

            String strnumber = "100ST";

            int Result = 0;

            bool IsconversionSucessful = int.TryParse(strnumber,out Result);

            if (IsconversionSucessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Number");
            }

        }
    }
}
