using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace _2019KCFED_API.Models
{
    public class DbConnection : DbContext
    {
        public DbConnection():base()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Business> Business { get; set; }




    }
}
