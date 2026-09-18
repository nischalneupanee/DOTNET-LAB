using System;

// File 2: Methods of partial class Book
public partial class Book
{
    public void IssueBook()
    {
        if (!IsIssued)
        {
            IsIssued = true;
            Console.WriteLine($"Book '{Title}' has been successfully issued.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' is already issued.");
        }
    }

    public void ReturnBook()
    {
        if (IsIssued)
        {
            IsIssued = false;
            Console.WriteLine($"Book '{Title}' has been successfully returned.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' was not issued.");
        }
    }

    public void DisplayDetails()
    {
        string status = IsIssued ? "Issued" : "Available";
        Console.WriteLine($"[Book ID: {BookID}] \"{Title}\" by {Author} | Status: {status}");
    }
}
