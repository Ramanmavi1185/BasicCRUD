using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace _200520823Midterm.Models
{
    public class Company
    {
        [Required()]
        public int Id { get; set; }

        [Required(), MaxLength(82)]
        public string Domain { get; set; }


        public DateTime Anniversay { get; set; }
        public double Percentage { get; set;}
        public int Position { get; set; }

        [Required(), Range(3,98)]
        public string Organization { get; set; }


        [Required(), Range(6,814)]
        public int Place { get; set; }





    }
}
