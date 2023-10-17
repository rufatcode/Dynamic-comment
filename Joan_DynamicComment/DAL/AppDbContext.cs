using System;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Joan_DynamicComment.DAL
{
	public class AppDbContext:IdentityDbContext
	{
		public AppDbContext(DbContextOptions options):base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string AdminId = Guid.NewGuid().ToString();
            string SupperAdminId = Guid.NewGuid().ToString();
            string AdminRoleId = Guid.NewGuid().ToString();
            string UserRoleId = Guid.NewGuid().ToString();
            string SupperAdminRoleId = Guid.NewGuid().ToString();
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { NormalizedName="USER",Name="User",ConcurrencyStamp=UserRoleId,Id=UserRoleId},
                new IdentityRole { NormalizedName="ADMIN",Name="Admin",ConcurrencyStamp=AdminRoleId,Id=AdminRoleId},
                new IdentityRole { NormalizedName="SUPPERADMIN",Name="SupperAdmin",ConcurrencyStamp=SupperAdminRoleId,Id=SupperAdminRoleId}
                );
            AppUser Admin = new AppUser
            {
                Id = AdminId,
                FullName = "RufatCode",
                Email = "rft.smayilov@bk.ru",
                UserName = "Rufat1122",
                NormalizedUserName = "RUFAT1122",
                NormalizedEmail="RFT.SMAYILOV@BK.RU"
            };
            Admin.PasswordHash = passwordHasher.HashPassword(Admin, "Rufat123.");
            AppUser SupperAdmin = new AppUser
            {
                Id = SupperAdminId,
                FullName = "RufatIsmayilov",
                Email = "rufatri@code.edu.az",
                UserName = "Rufat123",
                NormalizedUserName = "RUFAT123",
                NormalizedEmail = "RUFATRI@CODE.EDU.AZ"
            };
            Admin.PasswordHash = passwordHasher.HashPassword(Admin, "Rufat123.");
            SupperAdmin.PasswordHash = passwordHasher.HashPassword(SupperAdmin, "Rufat123.");
            builder.Entity<AppUser>().HasData(Admin, SupperAdmin);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId=AdminRoleId,UserId=AdminId},new IdentityUserRole<string> { UserId=SupperAdminId,RoleId=SupperAdminRoleId});
            base.OnModelCreating(builder);  
        }
    }
}

