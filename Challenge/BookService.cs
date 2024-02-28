using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BookService : IBookService
{
    private List<Book> _books;

    public BookService()
    {
        _books = new List<Book>();
    }

    public List<Book> GetAllBooks()
    {
        return _books;
    }

    public Book GetBookById(int id)
    {
        Book book = _books.Find(b => b.Id == id);
        if (book == null)
            throw new BookNotFoundException($"Book with ID {id} not found.");
        return book;
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void UpdateBook(int id, Book book)
    {
        int index = _books.FindIndex(b => b.Id == id);
        if (index != -1)
            _books[index] = book;
        else
            throw new BookNotFoundException($"Book with ID {id} not found.");
    }

    public void DeleteBook(int id)
    {
        Book bookToRemove = _books.Find(b => b.Id == id);
        if (bookToRemove != null)
            _books.Remove(bookToRemove);
        else
            throw new BookNotFoundException($"Book with ID {id} not found.");
    }
}