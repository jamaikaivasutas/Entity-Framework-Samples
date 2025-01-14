namespace Kreta.Database.Entities;
[Table("Subject")]
public class SubjectEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Required]
    public string Name { get; set; }

    [ForeignKey("Student")]
    public uint StudentId { get; set; }

    public virtual ICollection<StudentEntity> Students { get; set; }

}
