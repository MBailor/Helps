using System;
using System.Collections.Generic;


namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "War and Peace, Written by: ", "Casa Blanca, Written by: ", "To Kill A Mockingbird, Written by: ", "Gone With The Wind, Written by: " };
            //Console.WriteLine("Please enter your name!");
            //string entName = Console.ReadLine();

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j] + entName);
            //}
            //Console.ReadLine();

            ////This code creates an infinite loop
            ////for (int a = 0; a < 50; a--)
            ////{
            ////    Console.WriteLine("value : {0}", a);
            ////}
            ////Console.ReadLine(); 

            ////This code loops and stops where the code above should have stopped It also uses a "<" oporator
            //for (int k = 0; k < 50; k++)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.ReadLine();


            //for (int t = 4500; t >= 450; t--)
            //{
            //    Console.WriteLine(t);
            //}
            //Console.ReadLine();

            //// This code uses the <= oporator
            //for (int e = 200; e <= 375; e++)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadLine();


                List<string> ranStrings = new List<string>();
                ranStrings.Add("Pancakes");
                ranStrings.Add("French Toast");
                ranStrings.Add("Chicken Fried Steak");
                ranStrings.Add("Bacon");
                ranStrings.Add("Oatmeal");
                ranStrings.Add("Fruit Cup");

                Console.WriteLine("Please enter a Breakfast item to see if it's available");
                string entFood = Console.ReadLine();
                string ranStrings1 = Convert.ToString(ranStrings);
                int getFoodIndex = ranStrings.FindIndex(s => String.Equals(s, entFood));
                bool getFoodString = Convert.ToBoolean(getFoodIndex);



                if (ranStrings.Contains(entFood))
                {
                    Console.WriteLine("Yum! You chose: " + entFood + " Excellant choice! This is Item #: " + getFoodIndex + "");
                }
                else 
                {
                    Console.WriteLine("You have selected a food item that is unavailable.");
                    Console.WriteLine("Please enter a Breakfast item to see if it's available");
                    entFood = Console.ReadLine();
                    ranStrings1 = Convert.ToString(ranStrings);
                }
            Console.ReadLine();
        }

    }
}
