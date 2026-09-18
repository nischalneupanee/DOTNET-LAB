using System;

// File 1: Properties of partial class Book
public partial class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsIssued { get; private set; }

    public Book(int id, string title, string author)
    {
        BookID = id;
        Title = title;
        Author = author;
        IsIssued = false;
    }
}
