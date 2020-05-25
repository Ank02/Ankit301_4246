using Microsoft.EntityFrameworkCore;
using MT.OnlineRestaurant.DataLayer.Data_Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.DataLayer.DataEntity
{
    class ReviewDetailsContext : DbContext
    {

        public DbSet<ReviewDetails> reviewdetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = ReviewDetails; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
