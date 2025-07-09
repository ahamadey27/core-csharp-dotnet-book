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
       
    }
}
