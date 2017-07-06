using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            // Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue

            //For Loops allow for the repeated execution of a group of code
            //can be used for both counting and/or ITERATING(move to the next) through an array (or other collection type)
            //looks like this:
            //for(initializer; condition; updater)
            //{
            //    Do something
            //}
            //Foreach Loops
            //While Loops
            //Do-while loops

            //for (int i = 15; i > 0; i--) 
            //{
            //    Console.WriteLine(i);
            //}
            //// or you can use counter as the variable
            //for (int counter = 15; counter > 0; counter--)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            ////The .Split() method takes a string and turns it into an array of smaller strings (substrings). It defaults the split on splaces.
            //string[] wordsInGreeting = greeting.Split();

            ////for loop tp print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //      }
            //Create an array called days with the elements Monday, Tuesday, Wednesday.
            //Using a For Loop, print the elements of the days array.
            //string[] days = { "Monday", "Tuesday", "Wednesday" };

            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}
            //Start with the string "Once Upon a time" and create an array called storyWords using the Split method.  Reverse the order of the elements in the array and using a For Loop, print each word.
            string storyWords = "Once Upon a time";
            string[] wordsInStory = storyWords.Split();
            Array.Reverse(wordsInStory);
            for (int i = 0; i < wordsInStory.Length; i++)
            {
              Console.WriteLine(wordsInStory[i]);
            }

            //Add the product (multiplication) of 1 through 10 using a For Loop.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //Print the product to the screen.



        }




    }
}
