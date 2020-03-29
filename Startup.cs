using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAPISampleHandsOn.DataLayer;
using WebAPISampleHandsOn.Models;
using Microsoft.AspNetCore.Identity;

namespace WebAPISampleHandsOn
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddDbContext<AuthenticationContext>(opt => 
            opt.UseSqlServer(Configuration.GetConnectionString("IdentityDatabase")));
            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<AuthenticationContext>();

           // services.AddDbContext<ApplicationDbContext>(option => option.UseInMemoryDatabase("Application"));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("MyTastDatabase")));

            //services.AddScoped<ApplicationDbContext>();
            //services.AddScoped(typeof(IBookServices),typeof (BookServices));
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //AddMovies.Initialize(app.ApplicationServices);
        }
    }
}
