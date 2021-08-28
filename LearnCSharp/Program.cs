using LearnCSharp.Basics_Part2.Homework.HwSolutions.Hw3;
using LearnCSharp.Basics_Part2.Projects.BlackJack;
using LearnCSharp.Basics_Part2.Projects.RockClimbingRoutes;
using LearnCSharp.Basics_Part2.Projects.WaterTracker;
using LearnCSharp.Part2.Homework;
using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    /// <summary>
    /// This project is broken into BASICS PART 1 and BASICS PART 2.
    /// Complete all of BASICS PART 1 before moving on to BASICS PART 2.
    /// Complete everything in the order outlined below in the Main() method.
    /// CTRL + SHIFT + B to build the projct.
    /// You can replace each class name like "FizzBuzz" with "FizzBuzzSln" to run the completed solution version.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------
            // BASICS PART 1
            // --------------------------------------------------------

            // Project 1: Intro and Fizz Buzz Problem
            //FizzBuzzSln fizzBuzz = new FizzBuzzSln();
            FizzBuzz fizzBuzz = new FizzBuzz();
            int num = 100;
            fizzBuzz.Run(num);

            //// Project 2a: Simple Calculator to Add, Subtract, Divide, Multiply 2 numbers
            //// No separate methods and expanded variable assignment
            //CalculatorSimpleSln calcSimple = new CalculatorSimpleSln();
            //CalculatorSimple calcSimple = new CalculatorSimple();
            //calcSimple.Run();

            //// Project 2b: Simple Calculator to Add, Subtract, Divide, Multiply 2 numbers
            //// Added methods and shortened variable assignment
            //CalculatorSln calc = new CalculatorSln();
            //Calculator calc = new Calculator();
            //calc.Run();

            //// Project 3: Rock Paper Scissors Game
            //RockPaperScissors rockPaperScissors = new RockPaperScissors();
            //rockPaperScissors.Run();

            //// Project 4: Tic Tac Toe (TTT) Game
            //TicTacToe ticTacToe = new TicTacToe();
            //ticTacToe.Run();

            //// Work on HW 1, see solution class if needed
            //// Work on HW 2, see solution class if needed

            //// Project 5: Intro to Collections with Bags of Marbles
            //Marbles marbles = new Marbles();
            //marbles.Run();

            //// Work on HW 3, see solution class if needed

            //// Project 6: Simple Blackjack, no classes and Ace = 1 only
            //BlackJackSimple blackJackSimple = new BlackJackSimple(); // **NEED TO ADD CONSOLE READLINES
            //blackJackSimple.Run();

            //// Project 7: Refactor Project 4 Tic Tac Toe
            //// See how a method was created to avoid replicating work. 
            //// Lines with refactor are marked with comments.
            //TicTacToeRefactor tttRefactor = new TicTacToeRefactor();
            //tttRefactor.Run();

            //// Project 8: Water Tracker
            //WaterTrackerSimple waterTracker = new WaterTrackerSimple();
            //waterTracker.Run();

            // Work on HW 3, see solution class if needed

            // --------------------------------------------------------
            // BASICS PART 2: Classes and Object Oriented Programming
            // --------------------------------------------------------

            // Project 1: Rock climbing
            //RockClimbing rockClimbing = new RockClimbing();
            //rockClimbing.Run();

            // Project 2: Water Tracker
            //WaterTracker waterTracker = new WaterTracker();
            //waterTracker.Run();

            // Project 3: BlackJack with classes
            //BlackJack blackJack = new BlackJack();
            //blackJack.Run();


            //Hw3GameLogic gameLogic = new Hw3GameLogic();
            //gameLogic.StartGame();

            //Hw5Solution hw5 = new Hw5Solution();
            //hw5.Run();

            // --------------------------------------------------------
            // C# Back-end with Domain Driven Design & full unit testing
            // --------------------------------------------------------
            // Project 1: ShoeStore
            // See ShoeStore and ShoeStore.Test projects under solution explorer
        }
    }
}
