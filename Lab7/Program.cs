namespace Lab7;

class Program
{
    static void Main(string[] args)
    {
        ook book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals
    }
}

class Book
{
    private string title;

    public Book();
    {
        title = "Unknown title";

    }

    public string getTitle()
    {
        return title;
    }

    public setTitle(string newTitle)
    {
        title = newTitle;
    }
}
