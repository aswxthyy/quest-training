namespace Library.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        public GenericResponse<Book> GetBookByID(int id)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.ID == id);
            if (book == null) 
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = book,
            };
        }
    }
}