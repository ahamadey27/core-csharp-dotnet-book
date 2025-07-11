using Chapter4_Constructs;

class Program
{
    static void Main(string[] args)
    {
        //Arrays.SimpleArrays();
        //Arrays.ArrayInitialization();
        //Arrays.ImplicitlyTypedArrays();
        //Arrays.ArrayOfObjects();
        //Arrays.RectangularMultidimensionalArray();
        //Arrays.JaggedMultidimensionalArray();

        //var addResult = Methods.Add(1, 2);
        //Console.WriteLine(addResult);

        //Methods.AddUsingOutputParameter(1, 2, out int ans);
        //Console.WriteLine(ans);

        //Methods.MultipleOuts(out int a, out string b, out bool c);
        //Console.Write("{0} {1} {2}", a, b, c);

        //double average;
        //average = Methods.CalculatorAverage(4.0, 5.4, 6.8, 12.45);
        //Console.WriteLine($"Average of data is {average}");

        //Methods.EnterOptionalParameters("oh no");

        //Console.WriteLine(AddOperations.Add(10, 10));
        //Console.WriteLine(AddOperations.Add(8999999999999999, 99999999));
        //Console.WriteLine(AddOperations.Add(45.7, 35.7));

        //Methods.CheckForNullData("bill");

        //Make EmpTypeEnum variable
        //Enums.EmpTypeEnum emp = Enums.EmpTypeEnum.Contractor;
        //Enums.AskForBonus(emp);

        //Return string name of enum value
        Enums.EmpTypeEnum emp = Enums.EmpTypeEnum.Contractor;
        Console.WriteLine($"emp is a {emp.ToString()}");

    }

}
