
using ContosoUniversity.Service.Business.Statistics;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using ContosoUniversity.Service.Services;
using ContosoUniversity.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace ContosoUniversity.Service
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IStatisticsBusiness, StatisticsBusiness>();
            services.AddDbContext<SchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DbConnection"));
                //options.UseLazyLoadingProxies();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(routes =>
            {
                routes.MapGrpcService<GreeterService>();
                routes.MapGrpcService<StatisticsService>();
            });
        }
    }
}
