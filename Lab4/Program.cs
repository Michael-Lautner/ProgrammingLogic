namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1
        //For loop to print integers 1 -> 10

        for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        
        // Problem 2
        // Printing even numbers 1 -> 20

        for (int n = 1; n < 21; n++)
            {if (n % 2 ==0)
                {Console.WriteLine(n);
                }
            
            }
        
        // Problem 3 
        // Whie Loop Countdown

        int x =5;
        while (x > 0)
            {Console.WriteLine(x);
            x--;
            }

        // Problem 4
        // do/while user input
            
        int y = 0;
        do
            {
            Console.WriteLine("Enter a number greater than 100");
            y = Convert.ToInt32(Console.ReadLine());
        
            }
        while (y <= 100);
        
        Console.WriteLine("Thank you");

        //Problem 5 
        // Multiples of 10 from 10 to 1000

        int z = 10;
        while (z<1001)
            {Console.WriteLine(z);
           z= z + 10;
            }

        //Problem 6
        //Pattern Printer 
        
        
        for (int a = 1; a < 11; a++)
        {
            for (int b = 1; b <= a; b++)
                {
             Console.Write("*");
                 }
    Console.WriteLine();
        }
    }
}
