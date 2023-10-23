using System;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Joan_DynamicComment.DAL
{
	public class AppDbContext:IdentityDbContext
	{
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NavBar> NavBars { get; set; }
        public DbSet<Comment> Comments { get; set; }
		public AppDbContext(DbContextOptions options):base(options)
		{
		}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);


            builder.Entity<NavBar>().HasData(new NavBar { Id=1,Key="Location",Value= "184 Main Rd E, St Albans VIC 3021, Australia" },
                new NavBar { Id=2,Key="Mail",Value= "rft.smayilov@bk.com" },
                new NavBar { Id=3,Key="Phone",Value= "+ 00 254 254565" },
                new NavBar { Id=7,Key="LinkendIn",Value= "https://www.linkedin.com/in/rufat-ismayilov/" },
                new NavBar { Id=4,Key="Instegram",Value= "https://www.integram.com/in/rufat-ismayilov/" },
                new NavBar { Id = 5, Key = "Facebook", Value = "https://www.Facebook.com/in/rufat-ismayilov/" },
                new NavBar { Id = 6, Key = "Twitter", Value = "https://www.Twitter.com/in/rufat-ismayilov/" }
                );

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

