namespace MvcLibrary.Models
{
    public class Author //Author model for to keep author information.
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
    }
}
