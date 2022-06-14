using Microsoft.AspNetCore.Identity;

namespace IBA_Alumni.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }

    }
}
