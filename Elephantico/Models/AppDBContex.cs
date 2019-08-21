using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public class AppDBContex : DbContext
    {
        // DbContext needs an instance of DbContext options 
        // to passoptions override OnConfiguring method or through contructor
        // options must be passed to the base class
        public AppDBContex(DbContextOptions<AppDBContex> options):base(options)
        {

        }

        // EF knows about the Elephaitem type and will create the coresponding table in the db elephaitems
        public DbSet<Elephaitem> Elephaitems { get; set; }
    }
}
