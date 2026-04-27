using System.ComponentModel.DataAnnotations;

namespace HomeworkManager.Models;

public class Homework
{
    public int Id { get; set; }

<<<<<<< HEAD
    [Required]
    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }

=======
    [Required(ErrorMessage = "Opis jest wymagany")]
    [StringLength(300)]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Data jest wymagana")]
    [DataType(DataType.Date)]
    [Display(Name = "Due Date")]
    public DateTime DueDate { get; set; }

    [Required(ErrorMessage = "Status jest wymagany")]
    [Display(Name = "Status")]
>>>>>>> 02f7a078a376dfebf0d219b059c446923495b077
    public string? Status { get; set; }
}