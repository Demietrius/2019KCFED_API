using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace _2019KCFED_API.Models
{
    public class _2019KCFED_APIContext : DbContext
    {
        public _2019KCFED_APIContext(DbContextOptions<_2019KCFED_APIContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Business> Business { get; set; }




    }
}
