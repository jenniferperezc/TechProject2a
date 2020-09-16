using System;

namespace TechProject2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for input
            Console.Write("Enter an integer value between 1 and 25 to execute Iterative statement");
            /*
              Use the try catch block to validate user input. If the user provides incorrect input,
              the catch block will handle the error and a message will be displayed.
            */
            try
            {
                //This variable will gather data from user input
                string input = Console.ReadLine();
                //This variable performs various Iterative statements
                int value_of_input = int.Parse(input);
                /*
                 
                 This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                Depending on the value of the user input between 1 and 25, a different type of 
                Iterative statement will execute
                
                */
                //If value inputed is between 1 and 5
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop");
                    Console.WriteLine("The For Loop will iterate" + value_of_input.ToString() + "times");
                    //For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have enetered " + value_of_input + ". This is the current integer value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    //Pause the program and await the user to press a key to end program
                }
                else
                {
                    //Error Message if integer is less than 1 or greater than 25
                    Console.WriteLine("Please enter an integer between 1 and 25");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }//End of Try

            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit porogram...");
                Console.ReadKey(true);
            }//End of catch
                
                
                
             
        }//End of Main
    }//End of class
}//End of name
