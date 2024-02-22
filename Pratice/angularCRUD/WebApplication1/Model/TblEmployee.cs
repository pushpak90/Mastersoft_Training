using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class TblEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;
        [StringLength(150)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(250)]
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime Doj { get; set; }
        [StringLength(20)]
        public string Gender { get; set; } = string.Empty;
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationID { get; set; }
        [NotMapped]
        public string Designation { get; set; } = string.Empty;
    }
}
