using System.ComponentModel.DataAnnotations;
namespace MvcLibrary.Models
{
    public class Book //Book model for to keep book information.
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public int AuthorId { get; set; } //To match the author.
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }

    }
}
