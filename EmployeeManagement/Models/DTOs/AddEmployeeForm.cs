using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.DTOs;

public class AddEmployeeForm
{
    [Required]
    public string Name { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    public EmployeeType Type { get; set; }

    [Required]
    public Position Position { get; set; }

    [Required]
    public string ImgUrl { get; set; }
}
