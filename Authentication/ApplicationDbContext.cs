using IoT.Authentication.IoT.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;  
using Microsoft.EntityFrameworkCore;  
  
namespace IoT.Authentication  
{  
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  
        {  
  
        }  
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
    }  
} 
