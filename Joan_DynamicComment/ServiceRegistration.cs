using System;
using Joan_DynamicComment.DAL;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Joan_DynamicComment
{
	public static class ServiceRegistration
	{
		public static void Registration(this IServiceCollection services,ConfigurationManager configuration)
		{
            
            services.AddControllersWithViews();
			services.AddDbContext<AppDbContext>(option =>
			{
				option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
			});
			services.AddSession(opt =>
			{
				opt.IdleTimeout = TimeSpan.FromHours(1);
			});
			services.AddRazorPages();

			services.AddIdentity<AppUser, IdentityRole>(option =>
			{
				option.User.RequireUniqueEmail = true;
				option.Password.RequireDigit = true;
				option.Password.RequiredLength = 8;
				option.Password.RequireLowercase = true;
				option.Password.RequireNonAlphanumeric = true;
				option.Password.RequireUppercase = true;
				option.SignIn.RequireConfirmedEmail = true;
				option.SignIn.RequireConfirmedAccount = true;
				//option.SignIn.RequireConfirmedPhoneNumber = true;
				option.Lockout.AllowedForNewUsers = true;
				option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
				option.Lockout.MaxFailedAccessAttempts = 4;
			}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.Configure<DataProtectionTokenProviderOptions>(option =>
            {
                option.TokenLifespan = TimeSpan.FromMinutes(10);

            });
        }
	}
}

