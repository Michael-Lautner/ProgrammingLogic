using System.Reflection;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1, Variable Declaration, declaring and printing variables

        int favNum = 9;
        Console.WriteLine(favNum);

        double longNum = 9.0000000001;
        Console.WriteLine(longNum);

        float myDecimal = 13.9F;
        Console.WriteLine(myDecimal);

        char myLetter = 'M';
        Console.WriteLine(myLetter);

        bool thisIs_easy = false;
        Console.WriteLine(thisIs_easy);

        string myName = "Michael";
        Console.WriteLine(myName);

        //Part 2, Type casting

        double newDouble = 9.78;
        Console.WriteLine("Double "+ newDouble);

        int newInt = (int) newDouble;
        Console.WriteLine("Integer " + newInt);

        int newNum = 13;
        Console.WriteLine("Integer "+ newNum);

        Convert.ToString(newNum);
        Console.WriteLine("String " + newNum);

        bool this_is_fun = true;
        Convert.ToString(this_is_fun);
        Console.Write("Is C# fun? " + this_is_fun);

        //Part 3 User input and type conversion

        //Console.WriteLine("What is your name?");
        //string userName = Console.ReadLine();
        //Console.WriteLine("How old are you?");
        //string userAge = Console.ReadLine();
        //Convert.ToInt32(userAge);

        //Console.WriteLine("Hello " + userName + ", age " + userAge);

        //Part 4 Arithmetic Operators

        int num1 = 4;
        int num2 = 8;

        Console.WriteLine("num1 =4");
        Console.WriteLine("num2 =8");

        Console.WriteLine("num1 + 10 =");
        Console.WriteLine(num1 +10);

        Console.WriteLine("num2 - 2 =");
        Console.WriteLine(num2 -2);

        Console.WriteLine("num1 x 3 =");
        Console.WriteLine(num1 *3);

        Console.WriteLine("num2 / 2 =");
        Console.WriteLine(num2/2);

        Console.WriteLine("num1 % 2 =");
        Console.WriteLine(num1 %2);

        //Part 5 Floting point precision

        float myFloat = 1.123456789F;
        double myDouble = 1.123456789;

        Console.WriteLine(myFloat);
        Console.WriteLine(myDouble);

        //the float is less precise than the double 

        //Part 6 Increment and Decrement 

        int partSix = 10;
        partSix++;
        Console.WriteLine(partSix);
        
        partSix--;
        Console.WriteLine(partSix);

    }
}
