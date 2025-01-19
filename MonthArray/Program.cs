/*/
* FILE : MonthArray.csproj
* PROJECT : SENG1385 - Assignment 1 - Program 2
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025-1-16
* DESCRIPTION : Creates an Array of 12 strings and displays the contents 
* of an arbitrarily selected index of that array based on a predefined variable
* Returns: Void 
/*/

namespace MonthArray
{
    ///<class> Program </class>
    /// <summary>
    /// Container for calendar month array access and usability
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            //Predefined variables
            int month = 12;
            string[] AnnualMonths = { "January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December" };

            //Method Logic
            string chosenMonth = AnnualMonths[month - 1];

            //Output of Process Result
            Console.WriteLine("The month listed in the array that corresponds to " + month.ToString() + " is " + chosenMonth + '.');
        }
    }
}
