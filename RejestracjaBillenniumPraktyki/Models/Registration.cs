
using System.ComponentModel.DataAnnotations;

namespace RejestracjaBillenniumPraktyki.Models
{
    public class Registration
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ApplicationId { get; set; }
        [Required(ErrorMessage = "Musisz podać imię i nazwisko")]
        [Display(Name = "Imię i nazwisko")]
        [RegularExpression(pattern: @"\w+\s\w+", ErrorMessage = "Podaj imię i nazwisko oddzielone spacją")]
        public string FirstLastName { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Musisz podać dlaczego chcesz uczestniczyć")]
        [Display(Name = "Dlaczego chcesz uczestniczyc")]
        public string Reasons { get; set; }
    }
}