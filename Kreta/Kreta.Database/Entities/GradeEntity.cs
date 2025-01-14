namespace Kreta.Database.Entities;

[Table("Grade")]
public class GradeEntity
{
    [Required]
    [StringLength(50)]
    public string StudentName { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public uint GradeValue { get; set; }

    [ForeignKey("Subject")]
    public uint SubjectId { get; set; }

    public virtual SubjectEntity Subject { get; set; }

    [ForeignKey("Student")]
    public uint StudentId { get; set; }

    public virtual StudentEntity Student { get; set; }
}
