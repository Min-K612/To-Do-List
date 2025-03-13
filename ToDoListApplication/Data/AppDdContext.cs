using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoListApplication.Models;

namespace ToDoListApplication.Data
{
    public class AppDdContext : IdentityDbContext<User>
    {
        public AppDdContext(DbContextOptions<AppDdContext> options) : base(options)
        {
        }
    }
}
