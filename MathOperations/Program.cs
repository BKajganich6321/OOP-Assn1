/*/
* FILE : MathOperations.csproj
* PROJECT : SENG1385 - Assignment 1 - Program 1
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025-1-16
* DESCRIPTION : Performs rudimentary mathematical operations on various variables and
* outputs the process and results to the screen for review.
* Returns: Void 
/*/

namespace MathOperations
{
    /// <class> Program </class>
    /// <summary> Class to demonstrate arithmetic method usability </summary>
    internal class Program
    {
        static void Main()
        {
            //Necessary baseline variables
            double Pi = 3.14159;
            int firstInteger = 5;
            int secondInteger = 17;
            double firstDouble = 2.1457;
            double secondDouble = 7.2345;
            
            //Method calls for logic calculation
            long product = MultiplyInt(firstInteger, secondInteger); 
            double quotient = DivideDouble(firstDouble, secondDouble);

            //This was a little tricky. MultiplyInt() was not usable with Pi due to integer 
            //parameters. Instead, using DivideDouble with the inverse of the chosen double 
            //accomplishes the desired operation.
            double inverseProduct = DivideDouble(1, firstDouble);  
            double radians = DivideDouble(Pi, inverseProduct);             
            double sineValue = GetSine(radians);                       
            
            //Calculations, Processes and Results Confirmed and Output to Screen
            Console.WriteLine("The declared integers are " + firstInteger.ToString() + " and " + secondInteger.ToString());
            Console.WriteLine("The product of the declared integers is " + product.ToString());

            Console.WriteLine("\nThe declared doubles are " + firstDouble.ToString() + " and " + secondDouble.ToString());
            Console.WriteLine("The quotient of the " + firstDouble.ToString() + " over " + secondDouble.ToString() + " is " + quotient.ToString());

            Console.WriteLine("\nThe radian value used in the Sine Value Method is the product of the first double and Pi, equal to  " + radians.ToString());
            Console.WriteLine("The Sine function value calculated is equal to " + sineValue.ToString());
        }


        /// <method> MultiplyInt </method>
        /// <summary> Takes two integers as parameters and calculates 
        /// their product as a long-form integer. </summary>
        /// <param name="factor1"> Multiplied Factor </param>
        /// <param name="factor2"> Multiplied Factor </param>
        /// <returns> long product : Product of Factors </returns>
        static long MultiplyInt(int factor1, int factor2)
        {
            long product = (long)factor1 * (long)factor2;
            return product;
        }

        /// <method> DivideDouble </method>
        /// <summary> Takes two doubles as parameters and calculates 
        /// their quotient as a double. </summary>
        /// <param name="dividend"> Dividend of fraction</param>
        /// <param name="divisor"> Divisor of fraction</param>
        /// <returns> double Quotient : dividend over divisor </returns>
        static double DivideDouble(double dividend, double divisor) 
        { 
            double quotient = dividend / divisor;
            return quotient;
        }

        /// <method> GetSine </method>
        /// <summary> Takes a measure of radians as a double and returns 
        /// the corresponding sin value. </summary>
        /// <param name="radians"> Radian value </param>
        /// <returns> double sinRatio : Calculated ratio of Sin(radians) </returns>
        static double GetSine(double radians)
        {
            double sinRatio = Math.Sin(radians);
            return sinRatio;
        }

    }
}

