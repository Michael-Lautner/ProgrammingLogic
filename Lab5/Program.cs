using System.Runtime.CompilerServices;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Seasons of the Year

        string[] seasons = new string[4] {"Spring", "Summer", "Fall", "Winter"};

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        //Problem 2: Days of the Week

        string[] days = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        int day = 0;
        
        do
            {
            Console.WriteLine("Enter a number 1 - 7");
            day = Convert.ToInt32(Console.ReadLine());
        
            }
        while (day >= 8);

        Console.WriteLine("That day is: " + days[day-1]);


        //Problem 3: Favorite Book and Authors

        string[] books = new string[3] {"Angela's Ashes", "The Indifferent Stars Above", "The Faithful Executioner"};
        string[] authors = new string[3] {"Frank McCourt", "Daniel Brown", "Joel Harrington"};

        for (int i = 0; i <3; i++)
            {
                Console.WriteLine(books[i] + " by " + authors[i]);
            }

            //Problem 4

            int[] temperatures = new int[5] {65, 72, 78, 70, 68};

            Array.Sort(temperatures);

            for (int i = 0; i<5; i++)
            {  
                Console.WriteLine(temperatures[i]);
            }
            
        

            Console.WriteLine(temperatures[0]);
            Console.WriteLine(temperatures[temperatures.Length-1]);
            

        //Problem 5: Reverse Countdown

        int[] countdown = new int[5] { 5,4,3,2,1};

        Array.Reverse(countdown);

        for (int i = 0; i<5; i++)
        {
            Console.WriteLine(countdown[i]);
        }





    }
}
