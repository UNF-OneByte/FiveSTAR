using System;
using FiveSTARProjectTracking.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FiveSTARProjectTracking.Areas.Identity.IdentityHostingStartup))]
namespace FiveSTARProjectTracking.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FiveSTARProjectTrackingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FiveSTARProjectTrackingContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<FiveSTARProjectTrackingContext>();
            });
        }
    }
}