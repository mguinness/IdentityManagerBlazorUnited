using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public ApplicationRole(string roleName)
            : base(roleName) { }

        public ICollection<IdentityRoleClaim<string>> Claims { get; set; }
    }

}
