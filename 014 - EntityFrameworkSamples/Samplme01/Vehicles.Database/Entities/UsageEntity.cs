namespace Vehicles.Database.Entities;

[Table("Usage")]
[Index(nameof(Name), IsUnique = true))]
public class UsageEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string Description { get; set; }

    public virtual IReadOnlyCollection<ModelEntity> Models { get; set; }
}
