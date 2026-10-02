class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

class HomeLibrary
{
    private System.Collections.Generic.List<Book> books = new System.Collections.Generic.List<Book>();

    public void AddBook(string title, string author, int year)
    {
        books.Add(new Book { Title = title, Author = author, Year = year });
    }

    public void RemoveBook(string title)
    {
        for (int i = books.Count - 1; i >= 0; i--)
        {
            if (books[i].Title == title) books.RemoveAt(i);
        }
    }

    public void SearchByAuthor(string author)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Author == author)
                System.Console.WriteLine(books[i].Title + " " + books[i].Year);
        }
    }

    public void SortByYear()
    {
        for (int i = 0; i < books.Count - 1; i++)
        {
            for (int j = i + 1; j < books.Count; j++)
            {
                if (books[i].Year > books[j].Year)
                {
                    Book temp = books[i];
                    books[i] = books[j];
                    books[j] = temp;
                }
            }
        }
    }

    public void PrintAll()
    {
        for (int i = 0; i < books.Count; i++)
        {
            System.Console.WriteLine(books[i].Title + " " + books[i].Author + " " + books[i].Year);
        }
    }
}

class Program
{
    static void Main()
    {
        HomeLibrary lib = new HomeLibrary();
        lib.AddBook("Абай жолы", "Мухтар Ауэзов", 1942);
        lib.AddBook("Көшпенділер", "Ильяс Есенберлин", 1976);

        lib.PrintAll();
        lib.SearchByAuthor("Мухтар Ауэзов");
        lib.SortByYear();
        lib.PrintAll();
    }
}