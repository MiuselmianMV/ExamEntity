using Microsoft.EntityFrameworkCore;
using FinalWork.DAL.Entities;
using Microsoft.Extensions.Configuration;


namespace FinalWork.DAL
{

    public class FWDbContext: DbContext 
    {
        public DbSet<Team> Teams { get; set; }
        private string _dbConnectionString => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalWork;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //public FWDbContext(DbContextOptions options = null) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_dbConnectionString);
            }
        }

    }
}
