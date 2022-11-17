using Lab10.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab10.Repository;

public class BookRepository: IBookRepository
{
    private ApplicationContext _context;
    public BookRepository(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Book>> GetBooks()
    {
        try
        {
            return await _context.Books.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public async Task<Book> GetBookByName(int id)
    {
        try
        {
            return await  _context.Books.FindAsync(id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Book> AddBook(Book book)
    {
        try
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Book> UpdateBook(int id, Book book)
    {
        try
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return book;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task DeleteBook(int id)
    {
        try
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return;
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public bool BookExist(int id)
    {
        try
        {
            return _context.Books.Any(e => e.Id == id);
        }
        catch (Exception)
        {
            throw;
        }
    }
}