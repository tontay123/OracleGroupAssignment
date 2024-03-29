using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OracleGroupAssignment.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public int AppUserId { get; set; }
        
        public bool IsHidden { get; set; }

        public string? Name { get; set; }
        public string? Address { get; set; } 

    }
}
