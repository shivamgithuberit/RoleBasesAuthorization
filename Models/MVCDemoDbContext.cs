using RoleBasesAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using RoleBasesAuthorization.Models;
using System.Diagnostics.CodeAnalysis;

namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {

        public MVCDemoDbContext(DbContextOptions<MVCDemoDbContext> options) : base(options) { }

      
        public DbSet<User> Users { get; set; }

       

       
    }

}
