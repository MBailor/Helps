using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int[] numArray = new int[6];
        numArray[0] = 1;
        numArray[1] = 2;
        numArray[2] = 3;
        numArray[3] = 4;
        numArray[4] = 5;
        numArray[5] = 6;


        try
        {
            Console.WriteLine("Please select an index of the number array(0-5)");
            int number = Convert.ToInt32(Console.ReadLine());
            bool number1 = Convert.ToBoolean(numArray[number]);

            if (number1)
            {
                Console.WriteLine(numArray[number]);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("You have selected an index that doesn't exist.");
        }

        Console.ReadLine();

        try
        {
            string[] strArray = new string[] { "Happy", "Elephant", "Linguini", "Levitate", "Open", "Nacho", "Earwig", "Wall", "Map", "Alpine", "N" };
            Console.WriteLine("Please select and index of the string array(0-10)");
            int word = Convert.ToInt32(Console.ReadLine());
            bool entWord = Convert.ToBoolean(word);

            if (entWord)
            {
                Console.WriteLine(strArray[word]);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("You have selected an index that doesn't exist.");
        }
        Console.ReadLine();

        try
        {
            List<string> strList = new List<string>();
            strList.Add("Snare Drum");
            strList.Add("Baseball");
            strList.Add("Bong");
            strList.Add("Fish");
            strList.Add("Pancake");
            strList.Add("Kitten");
            strList.Add("Slide");
            strList.Add("Triangle");
            strList.Add("Eggplant");

            Console.WriteLine("Chose and item from the list by it's index number(0-8)");
            int choseItem = Convert.ToInt32(Console.ReadLine());
            bool itemChose = Convert.ToBoolean(choseItem);

            if (itemChose)
            {
                Console.WriteLine(strList);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("You have selected an index that doesn't exist.");
        }
        Console.ReadLine();
            
        }
} 

