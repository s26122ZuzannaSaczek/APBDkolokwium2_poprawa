using System.ComponentModel.DataAnnotations;

namespace Kolokwium2poprawa.Models;

public class Color
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
}