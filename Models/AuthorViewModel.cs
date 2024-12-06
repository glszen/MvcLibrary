namespace MvcLibrary.Models
{
    public class AuthorViewModel
    {
       //What we need for the author page.
        public int Id { get; set; }
        public string AuthorName { get; set; } = "";
        public string AuthorLastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
    }
}
