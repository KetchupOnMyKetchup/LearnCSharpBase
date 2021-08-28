using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Basics_Part1.Homework.HwSolutions
{
    class Hw2Solutions
    {
        // Below this line, write a method called ChangeNum that returns an int of value 2 and takes in no parameteres
        public static int ChangeNum()
        {
            return 2;
        }

        // Below this line, write a method called ChangeNum2 that returns an int of value 3 and takes in one int parameter called input
        public static int ChangeNum2(int input)
        {
            return 3;
        }

        //Uncomment the below to debug the DoWork Method to test
        public void Run()
        {
            DoWork();
        }

        public static void DoWork()
        {
            // Initialize a new variable called num of type integer to 1
            int num = 1;

            // What value is num now?
            // Answer: 1


            // Call your method called ChangeNum, do not assign the method to the variable num
            ChangeNum();

            // What value will num be now?
            // Answer: 1


            // Set your exisiting variable num (do NOT create a new variable) equal to the ChangeNum method
            num = ChangeNum();
            // What value will num be now?
            // Answer: 2 


            // Write a variable called num2 and set it equal to 4
            int num2 = 4;

            // Call your ChangeNum2 method and pass in num2 as a parameter, do not assign the method to a variable
            ChangeNum2(num2);
            // What value will num be now?
            // Answer: num will still be equal to ChangeNum which is 2. num2 value will now be 3.


            // Set your variable num equal to the ChangeNum2 method
            num = ChangeNum2(num);
            // What value will num be now?
            // Answer: 3


            // Write a variable called num3 and set it equal to 5
            int num3 = 5;

            // Set your variable num equal to num3. 
            num = num3;
            // What value will num be now?
            // Answer: 5
        }
    }
}
