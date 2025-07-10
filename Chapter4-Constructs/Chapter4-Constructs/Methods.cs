using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Constructs
{
    public class Methods
    {
        //Expression bodied member
        public static int Add(int x, int y) => x + y;

        //Output parameters must be assigned by the called method
        public static void AddUsingOutputParameter(int x, int y, out int ans)
        {
            ans = x + y;
        }

        //Returning multiple output parameters
        public static void MultipleOuts(out int a, out string b, out bool c)
        {
            a = 9;
            b = "hellp";
            c = false;
        }

        //Using params modifier
        //Return average of some number of parameters
        public static double CalculatorAverage(params double[] values)//params allows variable number of identically typed parameters 
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

        //Enter optional parameters
        public static void EnterOptionalParameters(string message, string owner = "alex") //define parameter to make optional
        {
            Console.WriteLine($"Error: {message}");
            Console.WriteLine($"Owner of error: {owner}");
        }

        //Check parameters for null
        public static void CheckForNullData(string message, string owner = "alex")
        {
            ArgumentNullException.ThrowIfNull(message);
            Console.WriteLine($"Error: {message}");
            Console.WriteLine($"Owner of error: {owner}");

        }




    }
}
