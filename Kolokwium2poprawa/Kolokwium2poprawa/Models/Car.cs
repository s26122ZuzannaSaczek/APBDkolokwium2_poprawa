using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2poprawa.Models;

public class Car
{
    [Key]
    public int Id { get; set; }
    [MaxLength(17)]
    public string VIN { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public int Seats { get; set; }
    public int PricePerDay { get; set; }
    public int ModelId { get; set; }
    public int ColorId { get; set; }
    
    [ForeignKey(nameof(ModelId))]
    public Model Model { get; set; } = null!;
    [ForeignKey(nameof(ColorId))]
    public Color color { get; set; } = null!;
    
}