using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name Is Required")]
        [StringLength(12, MinimumLength =6)]
        public string Name { get; set; }

        public string Adderess { get; set; }

        public int Salary { get; set; }

        public string Email { get; set; }
    }
}