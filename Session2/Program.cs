namespace Session2;//Main namespace for the project
class Program
{
    //Class, Struct, Enum, and Interface definitions can go here
    #region XMLComments
    /// <summary>
    /// This method sums two integers and returns the result.
    /// </summary>
    /// <param name="num1">this is the first num</param>
    /// <param name="num2">This is the secend num</param>
    /// <returns>The result will be the sum of two num1+num2</returns>
    //static int Sum(int num1, int num2)
    //{
    //    return num1 + num2;
    //}
    /// <summary>
    /// This method prints an integer to the console.
    /// </summary>
    /// <param name="x">thid id integer num</param>
    //static void Print (int x)
    //{
    //    Console.WriteLine(x);
    //}
    #endregion 

    static void Main(string[] args) //Entry point for the program
    {
        Console.WriteLine("Hello, World!");
        Console.ReadLine(); //Waits for user input before closing the console window
                            //Console :Class is used to output text to the console
                            //WriteLine: method prints the text followed by a new line
        #region Comments and Regions
        // This is a single-line comment
        //int x== 5;
        //int y = 5;
        /* 
         * This is a multi-line comment
         * int x== 5;
         * int y = 5;
         */
        #endregion

        #region Qusation 01
        //int x = 10;
        //int y = 20;
        //Console.WriteLine(x+y);
        //Console.WriteLine("Hello");
        #endregion

        //int x = 5;//4 bytes

        #region Variable Declaration and naming conventions
        //int studentAge = 20; //4 bytes in Stack[value=20]
        //Console.WriteLine(studentAge);
        //Datetype   name [camelCase]    value 
        //int 9number = 20; //Invalid variable name, cannot start with a digit
        //int _number = 20; //Valid variable name, starts with an underscore
        //int @class = 200;//valid
        //int @struct = 200;//valid
        //PascalCase[C#]==>Mohamed Khaled[C# Code [Project name, Solution name] ]
        //camelCase[Js]==>mohamedKhaled[ Variables]
        //snake_case[Python]==>mohamed_khaled
        //kebab-case[Angular]==>mohamed-khaled

        //int number = 10,number02=200;
        //    //int x, y;
        //    Console.WriteLine(number);

        //string myName = "Mohamed Khaled"; //String variable
        String myName = new string("Mohamed Khaled"); //String variable using constructor
        #endregion
    }
}


