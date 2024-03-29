using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using OracleGroupAssignment.Models;

namespace OracleGroupAssignment.Data
{
    public class AuthDbContext : IdentityDbContext<AppUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
            
        }
        public DbSet<OracleGroupAssignment.Models.Customer> Customer { get; set; } = default!;
    }
}
