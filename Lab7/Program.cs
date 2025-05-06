using System.Net;

namespace Lab7;

class Book
{
    private string title;
    private string author;

    public Book()  // Default Constructor
    {
        title = "Unknown Title";
        author = "Unknown Author"; //setting default author
    }
    public Book(string myTitle) //Problem 2 parameterized constructor
    {
        title = myTitle;
    }

    public Book(string title2, string author2) //Problem 3: Constructor Overloading
    {
        title = title2;
        author = author2;
    }

    public string getTitle()
    {
        return title;
    }

    public void setTitle(string newTitle)
    {
        title = newTitle;
    }

    public string getAuthor() // returns author name
    {
        return author;
    }

    public void setAuthor(string newAuthor)  // sets new author name 
    {
        author = newAuthor;
    }
}




class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.getTitle());  // Output: Unknown Title

        book1.setTitle("C# Fundamentals");
        Console.WriteLine(book1.getTitle());  // Output: C# Fundamentals

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.getTitle());

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine(book3.getTitle());
        Console.WriteLine(book3.getAuthor());

        Book book4 = new Book(); // Problem 4: Updating fields using setter metods 
        book4.setTitle("Mastering C#");
        book4.setAuthor("Jane Smith");
        Console.WriteLine(book4.getTitle());
        Console.WriteLine(book4.getAuthor());

    

    

    }
}