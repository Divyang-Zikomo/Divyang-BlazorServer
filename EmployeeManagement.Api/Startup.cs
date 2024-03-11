using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api
{
    public class Startup
    {
        

        //public class Startup(IConfiguration configuration)
        //{
        //    Configuration= configuration;
        //}
        public IConfiguration Configuration { get; }
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddControllers();
        }
    }
}
