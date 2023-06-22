using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _200520823Midterm.Models;
using System.Security.Cryptography.X509Certificates;

namespace _200520823Midterm.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }  


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

            
        }
    }
}