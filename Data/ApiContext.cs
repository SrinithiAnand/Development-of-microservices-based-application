using Microsoft.EntityFrameworkCore;
using Sensors.Models;


namespace Sensors.Data
{
    public class ApiContext : DbContext{
        public DbSet<RouteData> Sensors { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {

        }
    }
}