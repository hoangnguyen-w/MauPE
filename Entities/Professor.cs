using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Entities
{
    public class Professor
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tên nhân viên")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tuổi")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Ngày Sinh")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Hình ảnh")]
        public string Photo { get; set; }


        [Required]
        [Display(Name = "Tình trạng bản thân")]
        public string Married { get; set; }

        [Required]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required]
        [ForeignKey("Departments")]
        public int DepId { get; set; }

        public Department Departments {get;set;}
    }
}
