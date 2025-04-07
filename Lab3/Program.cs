using System.Runtime.CompilerServices;

namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Operator Practice
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine("Is a > b?");
        Console.WriteLine(a > b);
        
        Console.WriteLine("Is a < c?");
        Console.WriteLine(a < c);

        Console.WriteLine("Is a > b and c?");
        Console.WriteLine(a > b && a > c);

        Console.WriteLine("Is a > b or c?");
        Console.WriteLine(a > b || a > c);

        //Part 2: Boolean Logic

        bool isRaining = true;
        
        bool haveUmbrella = false;

        if (isRaining == true && haveUmbrella == false)

            {Console.WriteLine("Take an umbrella");
            }
        else   
            {Console.WriteLine("You're good to go");
            }

        //Part 3: Conditional Logic

        //assigning a ticket price based on the age of the customer

        Console.WriteLine("What is your age?");
        int userAge = Convert.ToInt32(Console.ReadLine());
    
        
        if (userAge < 5)
            { Console.WriteLine("Ticket is free!");
            }
        else if (userAge >= 5 && userAge<= 12)
            {Console.WriteLine("Child ticket: $5");
            }
        else if (userAge >= 13 && userAge<= 64)
            {Console.WriteLine("Standard ticket: $10");
            }
        else
        //logical test not needed, if no other conditions were satisfied, userAge must be 65 or older
        //My thought is that this is more efficient?
            {Console.WriteLine("Senior ticket: $6");
            }

        //Part 4: Using a Switch Statement 

        Console.WriteLine("Pick a day 1-7");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) 
        {
            case 1:
                 Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }



    }
}
