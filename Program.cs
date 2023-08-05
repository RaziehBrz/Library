internal class Program
{
    private static void Main(string[] args)
    {
        Book[] libraryCatalog = new Book[]
                                {
                                    new FictionBooks ("The Great Gatsby" , "F . scott Fitzgrald" , 180 , "Classic") ,
                                    new FictionBooks ("Dune" , "Frank Herbert" , 412 , "Science Fiction") ,
                                    new NonFictionBooks ("Sapiens" , "Yuval Nuah Harari" , 512 , "History") ,
                                    new NonFictionBooks ("Atomic Habits" , "James Clear" , 320 , "Self-help") ,
                                };

        library.printLibraryCatalog(libraryCatalog);
    }
}
abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
    public abstract void GenreOrTopic();
    public void BasicInfo()
    {
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"Pages : {Pages}");
    }
}
class FictionBooks : Book
{
    public string Genre { get; set; }
    public FictionBooks(string title, string author, int pages, string genre) : base(title, author, pages)
    {
        Genre = genre;
    }
    public override void GenreOrTopic()
    {
        Console.WriteLine($"Genre : {Genre}");
    }
}
class NonFictionBooks : Book
{
    public string Topic { get; set; }
    public NonFictionBooks(string title, string author, int pages, string topic) : base(title, author, pages)
    {
        Topic = topic;
    }
    public override void GenreOrTopic()
    {
        Console.WriteLine($"Topic : {Topic}");
    }
}
class ArtBook : Book
{
    public string Style { get; set; }
    public ArtBook(string title, string author, int pages, string style) : base(title, author, pages)
    {
        Style = style;
    }
    public override void GenreOrTopic()
    {
        Console.WriteLine($"Style : {Style}");
    }
}
class library
{
    public static void printLibraryCatalog(Book[] librarycatalog)
    {
        foreach (var book in librarycatalog)
        {
            Console.WriteLine("----------");
            book.BasicInfo();
            book.GenreOrTopic();
            Console.WriteLine("----------");
        }
    }
}
