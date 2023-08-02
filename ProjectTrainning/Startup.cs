using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ProjectTrainning
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            #region database context
            services.AddDbContext<MyprojectDBContext>(item => item.UseSqlServer(configRoot.GetConnectionString("myConnect"))); //context
            #endregion

            services.AddControllersWithViews();

            services.AddMvc();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
        }
    }
}
