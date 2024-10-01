namespace Vehicles.Database.Entities;

[Table("Owner")]
[Index(nameof(TAJ), IsUnique = true)]
public class OwnerEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    [StringLength(11)]
    public string Birthday { get; set; }

    [Required]
    [StringLength(9)]
    public string TAJ { get; set; }

    public virtual IReadOnlyCollection<VehicleEntity> Vehicles { get; set; }

    public uint StreetId { get; set; }

    public virtual StreetEntity Street { get; set; }
}
