using System.ComponentModel.DataAnnotations;

namespace _200520823Midterm.Models
{
    public class Employee
    {

        [Required()]
        public int Id { get; set; }


        [Required()]
        public int ParentId { get; set; }


        [Required(), MaxLength(82)]
        public string MiddleName { get; set; }


        [Required()]
        public DateTime CalenderDate { get; set; }

        public decimal Salary { get; set; }


        [Required()]
        public int Force { get; set; }


        [Required()]
        public decimal Frequency { get; set; }

        public DateTime LastUpdated { get; set; }


    }
}
