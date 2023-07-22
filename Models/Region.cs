using System.ComponentModel.DataAnnotations;

namespace HR_DB_with_ef_core;

public class Region
{
    public int RegionId { get; set; }

    [MaxLength(25)]
    public string RegionName { get; set; } = null!;

    public ICollection<Country> MyProperty { get; set; } = new List<Country>();
}