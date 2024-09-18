namespace Vehicles.Database.Entities;
[Table("Manufacturer")]
[Index(nameof(Name), IsUnique = true)]
public class ManufacturerEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(120)]
    public string Name { get; set; }

    public virtual IReadOnlyCollection<ManufacturerEntity> Manufacturers { get; set; }
}
