using System;
using System.Collections.Generic;
using System.Text;
using LearnCSharp;

namespace LearnCSharp.Part2.Homework
{
    /// <summary>
    /// Intro to classes practice!
    /// </summary>
    class Hw1
    {
        // -----------------------------------------------------------
        // Create a class called Car with properties
        // -----------------------------------------------------------
        public class NewClass1
        {
            // Add properties: MaxSpeed, Model, Make, Year, MaxGas, CurrentGas
            // Add property GasTankIsEmpty which is false if Gas > 1

            // Add a method called Drive() 
            
            // Add a method AddGas() to the Car. It should take in a parameter for gallons and edit the CurrentGas property

            // Add a method called GetGasLevelPercent(), it should return the current gas / max gas

            // Add a method called GetSummary() will print out all of the properties of this car
        }

        // -----------------------------------------------------------
        // Create a class called Model.
        // It should have properties Name, Description
        // -----------------------------------------------------------
        public class NewClass3
        {
        }

        // -----------------------------------------------------------
        // Create a class called Make.
        // It should have properties Name, Description, and Model
        // Create a constructor that requires a Model as a parameter, and assigns the model passed in to the Model property
        // -----------------------------------------------------------
        public class NewClass2
        { 
        }


        // In the Car class, replace the string Make with the type Make. Remove the property Model
        
        public void Run()
        {
            // Create a Model called Civic

            // Create a Model called ES330

            // Create a Make called Honda and pass in the Model Civic

            // Create a Make called Lexus and pass in the Model ES3330

            // Create an object honda1 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on honda1

            // Create an object honda2 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on honda2

            // Create an object lexus1 that is a Car and assign values to all of its properties, make sure to assign it the right Model
            // Call the GetSummary() method on lexus1
        }

        // -----------------------------------------------------------
        // Unrelated to the Car exercise above..
        // Create a class called Cat with 4 properties of cats and 2 methods of actions cats do
        // -----------------------------------------------------------
        public class NewClass4
        {

        }
    }
}