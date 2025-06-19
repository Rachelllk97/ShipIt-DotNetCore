// using Microsoft.EntityFrameworkCore;
// using ShipIt.Models.DataModels;
// using ShipIt.Models.ApiModels;

// namespace ShipIt_DotNetCore
// {
//     public class ShipItDbContext : DbContext
//     {
//         // Put all the tables you want in your database here
//         //public DbSet<EmployeeDataModel> Employees { get; set; }
//         //public DbSet<Product> Products { get; set; }
//         //public DbSet<Company> Companies { get; set; }
//         //public DbSet<Stock> Stocks { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             // This is the configuration used for connecting to the database
//             optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=ShipIt;User Id=ShipIt;Password=ShipIt;");
//         }
//     }
// }
