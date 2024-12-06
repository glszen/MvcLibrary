using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class EditViewModel
    {
        //What we need for the book edit page.
        public int Id { get; set; }

        [Required(ErrorMessage = "Cannot be left blank")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Cannot be left blank")]
        public string Genre { get; set; } = "";

        public DateTime PublishDate { get; set; }

        public string ISBN { get; set; } = "";

        public int CopiesAvailable { get; set; }

        public string authorName { get; set; } = "";

        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Cannot be left blank")]
        public int AuthorId { get; set; }
    }
}
