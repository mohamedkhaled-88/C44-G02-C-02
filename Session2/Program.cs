using System.Drawing;

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

        //Int32 X = 29;
        //int x = 29;//alise [C# KEYWORD]
        //Int16 S=19;
        //String name= "Mohamed Khaled"; //String variable
        //string name2 = "Mohamed Khaled";
        #region ValueTypes
        //String name= "Mohamed Khaled"; //alise [C# KEYWORD]
        //string name2 = "Mohamed Khaled";//[BCL]

        //Single number = 10;
        //float number2 = 10.5f; //Single is a 32-bit floating point type
        //int x;
        ////Allocate 4 Byets in Stack memory[Uninializted]
        //x = 5;
        ////Assign value to x
        //Console.WriteLine(x);
        //int y = 10;
        //Console.WriteLine(y);
        //Console.WriteLine();
        //y = x;//y=x=5
        //Console.WriteLine(x);
        //Console.WriteLine(y);

        //y++; //y = y + 1; //Increment y by 1
        //Console.WriteLine();
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //int x = 10; 
        //string name = "Mohamed Khaled";
        //Console.Write(x);
        //Console.WriteLine(name);
        #endregion
        #region Reference types
        //Point P1;
        //Allocate 4 bytes in Stack memory
        //Allocate 0 bytes in Heap memory
        //P1 = new Point();
        //new
        //Allocate 8 bytes in Heap memory for Point object
        //intialize each field with the deafult value based on datatype
        //Call user defined constructor if exists
        //Assign the reference to the object in the heap
        //Console.WriteLine(P1.x);
        //Console.WriteLine(P1.y);
        //Point P2 = new Point() { x = 5, y = 10 };
        //Console.WriteLine(P2.x);
        //Console.WriteLine(P2.y);
        //Console.WriteLine();
        //P1 = P2;
        //Console.WriteLine(P1.x);
        //Console.WriteLine(P1.y);
        //Console.WriteLine(P2.x);
        //Console.WriteLine(P2.y);

        //P1.x = 30;
        //Console.WriteLine();
        //Console.WriteLine(P1.x);
        //Console.WriteLine(P2.x);
        #endregion

    }
}


