using Kolokwium2poprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2poprawa.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<CarRental> CarRentals { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Client>().HasData(new List<Client>
            {
                new Client {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Client {
                    Id = 2,
                    FirstName = "Sophie",
                    LastName = "Stevens"
                }
            });

            modelBuilder.Entity<Car>().HasData(new List<Car>
            {
                new Car
                {
                    Id = 1,
                    VIN = "OIWS129380",
                    Name = "Carnumerouno",
                    Seats = 5,
                    PricePerDay = 100,
                    ModelId = 1,
                    ColorId = 2

                },
                new Car
                {
                    Id = 1,
                    VIN = "OIWS129380",
                    Name = "Carnumeroduo",
                    Seats = 7,
                    PricePerDay = 150,
                    ModelId = 2,
                    ColorId = 1
                }
            });

            modelBuilder.Entity<Color>().HasData(new List<Color>
            {
                new Color
                {
                    Id = 1,
                    Name = "Silver"
                },
                new Color
                {
                    Id = 2,
                    Name = "White"
                },
                new Color
                {
                    Id = 3,
                    Name = "Black"
                }
            });

            modelBuilder.Entity<Model>().HasData(new List<Model>
            {
                new Model
                {
                    Id = 1,
                    Name = "Silver"
                },
                new Model
                {
                    Id = 2,
                    Name = "Suzuki Vitara"
                }
            });

            modelBuilder.Entity<CarRental>().HasData(new List<CarRental>
            {
                new CarRental
                {
                    Id = 1,
                    ClientId = 1,
                    CarId = 1,
                    DateFrom = DateTime.Parse("2024-06-20"),
                    DateTo = DateTime.Parse("2024-06-24"),
                    TotalPrice = 400,
                    Discount = 0

                },
                new CarRental
                {
                    Id = 2,
                    ClientId = 2,
                    CarId = 2,
                    DateFrom = DateTime.Parse("2024-06-01"),
                    DateTo = DateTime.Parse("2024-06-05"),
                    TotalPrice = 600,
                    Discount = 0
                },
                new CarRental
                {
                    Id = 3,
                    ClientId = 1,
                    CarId = 2,
                    DateFrom = DateTime.Parse("2024-07-10"),
                    DateTo = DateTime.Parse("2024-06-15"),
                    TotalPrice = 600,
                    Discount = 20
                }
            });
    }
}