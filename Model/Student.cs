using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI2.Model
{
    [Table(name: "Student")]
    public class Student 
    { 
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Student_Name { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Student_Surname { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]

        public string Grade { get; set; }
    }
}
