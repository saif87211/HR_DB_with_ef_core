using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Location
{
    [Key]
    [Column(Order = 1)]
    public int LocationId { get; set; }
    
    [Column(Order = 2), MaxLength(50)]
    public string Address { get; set; } = null!;
    
    [Column(Order = 3)]
    public string PostalCode { get; set; } = null!;
    
    [Column(Order = 4), MaxLength(10)]
    public string? City { get; set; }
}