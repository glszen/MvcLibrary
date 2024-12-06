namespace MvcLibrary.Models
{
    public class LibraryViewModel
    {
        //To put books and authors on the same page.
        public List<Author> Author { get; set; }
        public List<Book> Book { get; set; }

    }
}
