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

        public static void ArrayInitialization()
        {
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has a length of {0}", stringArray.Length);

            bool[] boolArray = new bool[] { false, true, false, true };
            Console.WriteLine("boolArray has a length of {0}", boolArray.Length);

            foreach (string strArray in stringArray)
            {
                Console.WriteLine(strArray);
            }
        }

        public static void ImplicitlyTypedArrays()
        {
            var a = new[] { 1, 2, 5, 10 };
            var b = new[] { "h", "k" };
            var c = new[] { false, true, true };

            foreach (var array1 in a)
            {
                Console.WriteLine(array1);
            }
        }

        //elements of object arrays can be varied data types
        public static void ArrayOfObjects()
        {
            object[] myObjects = new object[] { 1, "hello", false, 34.5466 };
            foreach (object i in myObjects)
            {
                Console.WriteLine(i);
            }
        }

        //Multidimensional arrays - Jagged
        public static void RectangularMultidimensionalArray()
        {
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            //populate 3x4 array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }

            }

            //Print 3x4 array
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");       
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Multidimensional arrays - Jagged
        public static void JaggedMultidimensionalArray()
        {
            int[][] jaggedArray = new int[5][]; //Array of five different arrays

        }
    }
}
