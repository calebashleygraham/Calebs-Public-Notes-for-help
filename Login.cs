
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IF_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //Used for the name of the console
            Console.Title = "Login";
            // In the context of the login system we use strings to hold information like words 
            // This will be our Username meaning once the computer asks for the username it will want the information it is holding that is in this case "User"
            string Username = "User";
            // This string is empty so we can do a check to see if our entered information matchs the information of the username 
            string EnteredUsername;
            string Password = "password";
            string EnteredPassword;
            // prints lines to the console
            Console.WriteLine("\n Welcome to the jungle");
            Console.WriteLine("\n \n Press any key to login");
            /*Console.ReadKey() Method makes the program wait for a key press and it prevents the screen until a key is pressed. In short,
             * it obtains the next character or any key pressed by the user. 
             * The pressed key is displayed in the console window(if any input process will happen).*/
            Console.ReadKey();
            /*The following example uses the Clear method to clear the console before it executes a loop, 
             * prompts the user to select a foreground and background color and to enter a string to display. 
             * If the user chooses not to exit the program,
             * the console's original foreground and background colors are restored and the Clear method is called again before re-executing the loop.*/
            Console.Clear();
            Console.WriteLine("Please enter a user name");
            /*This method is used to read the next line of characters from the standard input stream.
             * It comes under the Console class(System Namespace). If the standard input device is the keyboard, 
             * the ReadLine method blocks until the user presses the Enter key. 
             * And if standard input is redirected to a file, then this method reads a line of text from a file. */
            EnteredUsername = Console.ReadLine();
            Console.Clear();
            // Console.WriteLine(EnteredUsername);
            Console.ReadKey();
            Console.WriteLine("Please enter a password");
            EnteredPassword = Console.ReadLine();
            Console.ReadKey();
            /*C# supports the usual logical conditions from mathematics:
            Less than: a < b
            Less than or equal to: a <= b
            Greater than: a > b
            Greater than or equal to: a >= b
            Equal to a == b
            Not Equal to: a != b
            You can use these conditions to perform different actions for different decisions.
            C# has the following conditional statements:
            Use if to specify a block of code to be executed, if a specified condition is true
            Use else to specify a block of code to be executed, if the same condition is false
            Use else if to specify a new condition to test, if the first condition is false
            Use switch to specify many alternative blocks of code to be executed*/
            if (EnteredUsername == Username && EnteredPassword == Password)
            {
               Console.WriteLine("Username and passwor correct");
            }
            else
            {
                Console.WriteLine("Try again");
            }
            Console.ReadKey();

        } //All code must go into the main

    }

}
