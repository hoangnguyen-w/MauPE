using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Entities
{
    public class Department
    {
        [Key]
        [Display(Name = "Mã phòng ban")]
        public int DepId { get; set; }
        
        [Required]
        [Display(Name = "Tên phòng ban")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Số lượng nhân viên")]
        public int Max_employee { get; set; }
        
        [Required]
        [Display(Name = "Vị trí")]
        public string Location { get; set; }

        public ICollection<Professor> Professors { get; set; }
    }
}
