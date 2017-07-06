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

            for(int i = 50; i<= 100; i++)
            {
                Console.WriteLine(i);
            }


        }




    }
}
