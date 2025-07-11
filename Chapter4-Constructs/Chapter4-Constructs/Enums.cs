using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Constructs
{
    public class Enums
    {
        //Enums a custom data type of name-value pairs
        public enum EmpTypeEnum
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            Veep = 9
        }

        //Enums as parameters
        public static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:Console.WriteLine("Stock options?");
                    break;
                case EmpTypeEnum.Grunt: Console.WriteLine("No dice");
                    break;
                case EmpTypeEnum.Contractor: Console.WriteLine("Ask again");
                    break;
                case EmpTypeEnum.Veep: Console.WriteLine("Good day!");
                    break;

            }
        }



    }
}
