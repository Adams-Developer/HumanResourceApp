using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Position is required.")]
        public string Position { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Office { get; set; }

        public int  Age { get; set; }
        
        public int Salary { get; set; }
    }
}
