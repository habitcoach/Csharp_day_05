class Program
{
    static void Main(string[] args)
    {
        // Instantiate the book service
        IBookService bookService = new BookService();

        // Adding some initial books
        bookService.AddBook(new Book { Id = 1, Title = "Book 1", Author = "Author 1", Year = 2000 });
        bookService.AddBook(new Book { Id = 2, Title = "Book 2", Author = "Author 2", Year = 2005 });
       
        // Test CRUD operations
        try
        {
            Console.WriteLine("Listing all books:");
            List<Book> books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title} by {book.Author} ({book.Year})");
            }

            Console.WriteLine("\nGet Book by ID:");
            Book bookById = bookService.GetBookById(1);
            Console.WriteLine($"{bookById.Id}: {bookById.Title} by {bookById.Author} ({bookById.Year})");

            Console.WriteLine("\nUpdating Book:");
            bookService.UpdateBook(1, new Book { Id = 1, Title = "Updated Book", Author = "Updated Author", Year = 2020 });
            Console.WriteLine("Book updated successfully.");
            List<Book> booksU = bookService.GetAllBooks();
            foreach (var book in booksU)
            {
                Console.WriteLine($"{book.Id}: {book.Title} by {book.Author} ({book.Year})");
            }

            Console.WriteLine("\nDeleting Book:");
            bookService.DeleteBook(2);
            Console.WriteLine("Book deleted successfully.");
            List<Book> booksD = bookService.GetAllBooks();
            foreach (var book in booksD)
            {
                Console.WriteLine($"{book.Id}: {book.Title} by {book.Author} ({book.Year})");
            }
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}