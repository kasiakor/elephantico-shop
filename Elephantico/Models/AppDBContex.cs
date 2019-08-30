using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    //through AppDbC we will be able to work with the type user, we can add it by IdentityDbC
    //default type for the user is IdentityUser
    public class AppDBContex : IdentityDbContext<IdentityUser>
    {
        // DbContext needs an instance of DbContext options 
        // to pass options override OnConfiguring method or through contructor
        // options must be passed to the base class
        public AppDBContex(DbContextOptions<AppDBContex> options):base(options)
        {

        }

        // EF knows about the Elephaitem type and will create the coresponding table in the db elephaitems
        public DbSet<Elephaitem> Elephaitems { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
