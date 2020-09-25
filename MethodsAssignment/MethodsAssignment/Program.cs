using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodsAssignment
{
    class Program
    {

        public static void Math_ods()
        { 


            Console.WriteLine("Welcome to Math Time!\n\n The Show Where You Do\n\n Math With A Secret Number!!!");
            Console.ReadLine();
            Console.WriteLine("Let's get this game started!\n\n Pleace enter a number you'd\n\n Like to multiply!");
            Console.ReadLine();
            string entNums = Console.ReadLine();
            int entNum = Convert.ToInt32(entNums);
             
            
            
            Console.WriteLine("Your number, " + entNum + "Time the secreat number is;");
            Console.ReadLine();

            Console.WriteLine("Your answer is..........");
            Console.WriteLine(Math_od1 * entNum);
            Console.ReadLine();

        }
        Console.ReadLine();
     } }  
    }
} 
