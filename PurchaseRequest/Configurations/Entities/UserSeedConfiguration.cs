using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseRequest.Data;

namespace PurchaseRequest.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    Firstname = "Admin",
                    Lastname = "Test",
                    PasswordHash = hasher.HashPassword(null, "Okey2012+"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                     Email = "admin@user.com",
                     NormalizedEmail = "ADMIN@USER.COM",
                     UserName = "admin@user.com",
                     NormalizedUserName = "ADMIN@USER.COM",
                     Firstname = "Admin",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "Okey2012+"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}