using System;
using FiveSTAR_tracking.Areas.Identity.Data;
using FiveSTAR_tracking.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FiveSTAR_tracking.Areas.Identity.IdentityHostingStartup))]
namespace FiveSTAR_tracking.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserContextConnection")));

                services.AddDefaultIdentity<FiveSTAR_trackingUser>()
                    .AddEntityFrameworkStores<UserContext>();
            });
        }
    }
}