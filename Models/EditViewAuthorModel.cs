namespace MvcLibrary.Models
{
    public class EditViewAuthorModel
    {
        // //What we need for the author edit page.
        public int Id { get; set; }
        public string AuthorName { get; set; } = "";
        public string AuthorLastName { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
    }
}
