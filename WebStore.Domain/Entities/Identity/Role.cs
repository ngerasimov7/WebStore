using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities.Identity
{
    public class Role : IdentityRole
    {
        public const string Administrator = "Administrators";

        public const string Users = "Users";

        public string Description { get; set; }
    }
}