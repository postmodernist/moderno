namespace Lab10.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }

    public Book(string title, int year , string description)
    {
        Title = title;
        Year = year;
        Description = description;
    }
}
