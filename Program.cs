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

            /*String strnumber = "100ST";

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
            */

            //Switch Statement || if statement

            Console.WriteLine("Please enter a number");
                int usernumber = int.Parse(Console.ReadLine());
            /*if (usernumber== 10)
            {
                Console.WriteLine("your number is 10");
            }
            else if (usernumber == 20)
            {
                Console.WriteLine("your number is 20");
            }
            else if (usernumber == 30)
            {
                Console.WriteLine("your number is 30");
            }
            else
            {
                Console.WriteLine("your number is not 10,20,& 30");
            }
            */

            switch (usernumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("your number is {0}", usernumber);
                    break;
                default:
                    Console.WriteLine("your number is not 10,20,& 30");
                    break;
            }


        }
    }
}
