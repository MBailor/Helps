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


            //List<string> ranStrings = new List<string>();
            //ranStrings.Add("Pancakes");
            //ranStrings.Add("French Toast");
            //ranStrings.Add("Chicken Fried Steak");
            //ranStrings.Add("Bacon");
            //ranStrings.Add("Oatmeal");
            //ranStrings.Add("Fruit Cup");

            //Console.WriteLine("Please enter a Breakfast item to see if it's available");
            //string entFood = Console.ReadLine();
            //string ranStrings1 = Convert.ToString(ranStrings);
            //int getFoodIndex = ranStrings.FindIndex(s => String.Equals(s, entFood));
            //bool getFoodString = Convert.ToBoolean(getFoodIndex);
            //bool isMatch = false;

            //do
            //{
            //    if (ranStrings.Contains(entFood))
            //    {
            //        Console.WriteLine("Yum! You chose: " + entFood + " Excellant choice! This is Item #: " + getFoodIndex + "");
            //        isMatch = true;
            //        Console.ReadLine();
            //        return;
            //    }
            //    else if (!ranStrings.Contains(entFood))
            //    {
            //        Console.WriteLine("You have selected a food item that is unavailable.");
            //        Console.WriteLine("Please enter a Breakfast item to see if it's available");
            //        entFood = Console.ReadLine();
            //        ranStrings1 = Convert.ToString(ranStrings);
            //        getFoodIndex = ranStrings.FindIndex(s => String.Equals(s, entFood));
            //        getFoodString = Convert.ToBoolean(getFoodIndex);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yum! You chose: " + entFood + " Excellant choice! This is Item #: " + getFoodIndex + "");
            //        isMatch = true;
            //        Console.ReadLine();
            //        return;
            //    }
            //} while (isMatch == false);



            List<string> officeSupplies = new List<string>();
            officeSupplies.Add("Pencil");
            officeSupplies.Add("Pen");
            officeSupplies.Add("Scissor");
            officeSupplies.Add("Hole Punch");
            officeSupplies.Add("Pen");
            officeSupplies.Add("Paper");

            Console.WriteLine("Please enter an office supply item to see if it's available");
            string entSearch = Console.ReadLine();
            string stringSearch1 = Convert.ToString(officeSupplies);
            int getStringIndex = officeSupplies.FindIndex(s => String.Equals(s, entSearch));
            bool getIndexString = Convert.ToBoolean(getStringIndex);
            bool isAMatch = false;
            int index = 0;

            
            

                foreach (string supply in officeSupplies)
                {
                    Console.WriteLine($"{index}: {supply}");
                    

                    if (officeSupplies.Contains(entSearch))
                    {

                        Console.WriteLine("You have chosen the office supply, " + entSearch + "Which has an idex of:" + getStringIndex + "");
                        Console.WriteLine("You have chosen the office supply, " + entSearch + " Which has an idex of:" + getStringIndex + "");
                        index++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You have chosen an office supply that is currently unavailable.");
                        Console.ReadLine();
                    }
                }

        }
    }
}
