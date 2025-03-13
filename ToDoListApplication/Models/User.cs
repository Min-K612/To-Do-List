using Microsoft.AspNetCore.Identity;

namespace ToDoListApplication.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
