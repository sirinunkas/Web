using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TEST_SK: DbContext
    {
                      

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}