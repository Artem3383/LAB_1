using System.ComponentModel.DataAnnotations;

namespace HomeworkManager.Models;

public class Homework
{
    public int Id { get; set; }

    [Required]
    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }

    public string? Status { get; set; }
}