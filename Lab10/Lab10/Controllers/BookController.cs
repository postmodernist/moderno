using System.Data;
using Lab10.Models;
using Lab10.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Lab10.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController: ControllerBase
{
    private readonly IBookRepository _bookRepository;

    public BookController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        try
        {
            return Ok(await _bookRepository.GetBooks());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBookById(int id)
    {
        try
        {

            var book = await _bookRepository.GetBookByName(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBook(int id, Book book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }

        try
        {
            book = await _bookRepository.UpdateBook(id, book);
        }

        catch (DBConcurrencyException)
        {
            if (!_bookRepository.BookExist(id))
            {
                return NotFound();
            }
            else
            {
                return NotFound();
            }
            throw;
        }
        return Ok(book);
    }

    [HttpPost]
    public async Task<ActionResult<Book>> AddBook(Book book)
    {
        try
        {
            book = await _bookRepository.AddBook(book);
            return CreatedAtAction("GetBooks", new { id = book.Id }, book);
        }
        catch (Exception )
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        try
        {
            if (_bookRepository.BookExist(id))
            {
                await _bookRepository.DeleteBook(id);
                return NoContent();
            }

            return NotFound();
        }
        catch (Exception )
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}