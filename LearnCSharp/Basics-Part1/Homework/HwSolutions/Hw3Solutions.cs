using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part1.Homework.HwSolutions
{
    class Hw3Solutions
    {
        // Below this line, write a method called Add that takes in 4 parameters: 1 List of type string and 3 strings input1, input2, and input 3
        // The method should return a List of type string
        // The method should add all of the strings into the List, and return the List
        public List<string> Add(List<string> items, string input1, string input2, string input3)
        {
            items.Add(input1);
            items.Add(input2);
            items.Add(input3);
            return items;
        }

        //Uncomment the below to debug the DoWork Method to test
        public void Run()
        {
            DoWork();
        }

        public void DoWork()
        {
            // Initialize a new variable of type List of string that is empty called items.
            var items = new List<string>();

            // Initialize 3 new strings with the following values: "sword", "shield", and "potion"
            string sword = "sword";
            string shield = "shield";
            string potion = "potion";

            // Call the Add method you created, and pass in your list + 3 strings and assign it to your items variable.
            Add(items, sword, shield, potion);


            // Create an int variable called count, and do items.Count on it
            int count = items.Count;

            // Check the value of count? It should be 3. If it isn't see what could have gone wrong. 


            // Add 3 more Swords to your List called items by using your Add() method.
            Add(items, sword, sword, sword);

            // *Create a new boolean called IsSword and set it to true
            //bool isSword = true;

            // *Create a new int called count and set it to 0.
            //int count = 0;

            // *Use a foreach loop to go over your List called items.
            // *When the item is a sword, increase the count by 1
            //foreach (var item in items)
            //{
            //    if (item == sword)
            //    {
            //        count++;
            //    }
            //}

            // Refactor!
            // Comment out your code for all the steps with an asterik (*) on it
            // Create a new method called CountSwords outside of the Main method, it should return an int.
            // Re-write the code from the steps with the asterik (*) in your CountSwords method
            // Create a new int below called numSwords.
            // Your method CountSwords should return the total # of swords it finds and assign it to numSwords.
            int numSword = CountSwords(items, sword);
        }
        public int CountSwords(List<string> items, string sword)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item == sword)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

