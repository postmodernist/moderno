using Lab10.Models;
namespace Lab10.Repository;

public interface IBookRepository
{
    Task <IEnumerable<Book>> GetBooks();
    Task<Book> GetBookByName(int id);
    Task<Book> AddBook(Book book);
    Task<Book> UpdateBook (int id, Book book);
    Task DeleteBook(int id);
    bool BookExist(int id);
}