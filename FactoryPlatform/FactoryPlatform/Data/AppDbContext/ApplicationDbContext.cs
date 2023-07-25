using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FactoryPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        static DbContextOptions<ApplicationDbContext> _options;
        public ApplicationDbContext() : base(_options)
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _options = options;
        }

        public DbSet<Models.Users> Users { get; set; }
        public DbSet<Models.Users_ValidationSession> Users_ValidationSession { get; set; }
        public DbSet<spFPAPP_Sys_pageValidation> spFPAPP_Sys_pageValidation { get; set; }
        public DbSet<spFPAPP_Sys_serviceNowValidation> spFPAPP_Sys_serviceNowValidation { get; set; }

    }
}
