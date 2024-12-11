using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class CarListDbContext : IdentityDbContext
{
    public CarListDbContext(DbContextOptions<CarListDbContext> options) : base(options)
    {

    }

    public DbSet<Car> cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Make = "Honda",
                    Model = "Fit",
                    Vin = "123"
                },
                new Car
                {
                    Id = 2,
                    Make = "Toyota",
                    Model = "Prado",
                    Vin = "123"
                },
                new Car
                {
                    Id = 3,
                    Make = "Honda",
                    Model = "Civic",
                    Vin = "123"
                },
                new Car
                {
                    Id = 4,
                    Make = "Audi",
                    Model = "A5",
                    Vin = "123"
                },
                new Car
                {
                    Id = 5,
                    Make = "BMW",
                    Model = "M3",
                    Vin = "123"
                },
                new Car
                {
                    Id = 6,
                    Make = "Nissan",
                    Model = "Note",
                    Vin = "123"
                },
                new Car
                {
                    Id = 7,
                    Make = "Ferrari",
                    Model = "Spider",
                    Vin = "123"
                }
            );

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "c22445ce-6116-4b2d-b90e-874d0f6291c1",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            },
            new IdentityRole
            {
                Id = "46907667-3d6d-4115-a0b1-6e9102240b32",
                Name = "User",
                NormalizedName = "USER",
            }
            );

        var hasher = new PasswordHasher<IdentityUser>();

        modelBuilder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "d3deb5dc-93e4-4295-ba46-2fc651f62441",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                EmailConfirmed = true
            },
            new IdentityUser
            {
                Id = "1a220b77-52fe-4fc6-9a91-67246ef3529f",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                NormalizedUserName = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
            );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "c22445ce-6116-4b2d-b90e-874d0f6291c1",
                UserId = "d3deb5dc-93e4-4295-ba46-2fc651f62441"
            },
            new IdentityUserRole<string>
            {
                RoleId = "46907667-3d6d-4115-a0b1-6e9102240b32",
                UserId = "1a220b77-52fe-4fc6-9a91-67246ef3529f"
            }
            );
    }
}