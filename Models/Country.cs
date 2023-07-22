using System.ComponentModel.DataAnnotations;
namespace HR_DB_with_ef_core;

public class Country
{
    public int CountryId { get; set; }

    [MaxLength(40)]
    public string CountryName { get; set; } = null!;

    // public ICollection<Location> Locations { get; set; } = new List<Location>();

    public int RegionId { get; set; }
    public Region Region { get; set; }
}
