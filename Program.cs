using System;

namespace Method_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("Please enter your name..");
            /*
              Use the cath block to validate user input. 
            */
            try
            {
                // This variable will gather the user input 
                string input = Console.ReadLine();

                int nameof = int.Parse(input);



                {


                    Console.WriteLine("Hello" + String.Format("  ", int.Parse(input) + "Go Bus!"));
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);


                }
            }// end of try 
            catch
            {
                Console.WriteLine("Please enter your name and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }// End of catch 
        }// End of Main 
    }// End of Class 
}// End of namesplace

