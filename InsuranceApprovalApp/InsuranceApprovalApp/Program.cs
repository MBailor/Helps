using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string entAge = Console.ReadLine();
            
            Console.WriteLine("Have you ever had a DUI? Please answer \" True \" or \" False \"");
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string entTix = Console.ReadLine();
            
            int ageNum = Convert.ToInt32(entAge);
            bool isTrue = true;
            bool isFalse = false;
            int tixNum = Convert.ToInt32(entTix);

            if (ageNum >= 15 && isFalse == true && tixNum <= 3)
                {
                    Console.WriteLine("Congratulations, you have been approved for car insurance!");
                }
                else
                {
                    Console.WriteLine("We're sorry, you do not currently qualify for car insurance.");
                }
            Console.ReadLine();
        }
    }
}
