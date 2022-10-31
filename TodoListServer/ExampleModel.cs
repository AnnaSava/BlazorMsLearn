using System.ComponentModel.DataAnnotations;

public class ExampleModel
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }

    [StringLength(10, ErrorMessage = "Description is too long.")]
    public string? Description { get; set; }
}