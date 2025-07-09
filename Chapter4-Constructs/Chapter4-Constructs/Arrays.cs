using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Constructs
{
    public class Arrays
    {
        public static void SimpleArrays()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            //Print value
            foreach (int myInt in myInts)
            {
                Console.WriteLine(myInt); 
            }
        }
    }
}
