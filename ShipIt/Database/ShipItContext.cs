using ShipIt.Models.DataModels;
using Microsoft.EntityFrameworkCore;


namespace ShipIt.Database
{
    public class ShipItContext : DbContext
    {
        public DbSet<CompanyDataModel> Companies { get; set; }   

        public DbSet<EmployeeDataModel> Employees { get; set; }   
        public DbSet<ProductDataModel> Products { get; set;}
        public DbSet<StockDataModel> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // This is the configuration used for connecting to the database
            optionsBuilder.UseNpgsql(
                @"Server=localhost;Port=5432;Database=ShipIt;UserId=ShipIt;Password=ShipIt;"
            );
        }
    }
}
