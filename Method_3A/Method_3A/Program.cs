/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of Method Statements after getting an input from users. 
*/

using System;



namespace Method

{

    class Program

    {

        static void User()
        {
            // Ask the user for input

            

        }
        private static void Main(string[] args)

        {


            try

            {

                // This variable will gather the user input

                string input = Console.ReadLine();
                Console.WriteLine("Please enter your First Name...then press Enter " );
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your Last Name...then press Enter ");
                string name1 = Console.ReadLine();
                //Here is the the user input 
                Console.WriteLine("Hello"+ " " + name + " " + name1 +" "+ "GoBus!");

            }// End of try

            /*
  Use the cath block to validate user input.
  */
            catch

            {
                // Pause the program and wait for the user to press a key to end the program
                Console.WriteLine("Press any key to exit the program...");

                Console.ReadKey(true);

            }// End of catch

        }// End of Main

    }// End of Class

}// End of namesplace

       


