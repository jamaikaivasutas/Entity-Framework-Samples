namespace Vehicles.Database.Entities;

[Table("Usage")]
public class TypeEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }
}
