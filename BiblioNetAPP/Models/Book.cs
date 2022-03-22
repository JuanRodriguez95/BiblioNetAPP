using BiblioNetAPP.Validations;
using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        [FirstCapitalLetters]
        public string BookName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
