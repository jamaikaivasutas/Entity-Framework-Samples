namespace Kreta.Database.Entities;

[Table("Student")]
public class StudentEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    [StringLength(50)]
    public string MothersName { get; set; }

    [ForeignKey("Address")]
    public uint AddressId { get; set; }

    public virtual AddressEntity Address { get; set; }

    public virtual List<SubjectEntity> Subjects { get; set; }

    public virtual List<GradeEntity> Grades { get; set; }
 
    
}
