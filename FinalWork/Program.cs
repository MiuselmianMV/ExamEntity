using FinalWork.DAL;
using FinalWork.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinalWork
{
    public class Program
    {
        static void Main(string[] args)
        {



            //var optionsBuilder = new DbContextOptionsBuilder<FWDbContext>();

            var context = new FWDbContext();

            //var serviceProvider = new ServiceCollection()
            //    .AddDbContext<FWDbContext>(options => options.UseSqlServer(connectionString))
            //    .BuildServiceProvider();

            //var context = serviceProvider.GetRequiredService<FWDbContext>();

            TeamsInterface.Add(context);
            context.SaveChanges();

            TeamsInterface.Show(context);

        }
    }
}
