using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Repository_Domain
{
    [Serializable]
    [Table("Student")]
    public partial class Student : IEntity<int>
    {
        [Key]
        public int TraineeID { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        [Required]
        [StringLength(15)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(10)]
        public string RoundNo { get; set; }
        [Required]
        [StringLength(15)]
        public string CellPhoneNo { get; set; }
    }
}
