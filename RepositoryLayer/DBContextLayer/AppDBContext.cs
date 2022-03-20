using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
   public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions con) :base(con) 
        {
                
        }

        public DbSet<User> tblusers { get; set; }
    }
}
