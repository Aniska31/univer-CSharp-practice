using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using prak13.Models;

namespace prak13
{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string con =
"Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
            // ������������� �������� ������
            services.AddDbContext<UsersContext>(options => options.UseSqlServer(con));
            services.AddControllers(); // ���������� ����������� ��� �������������
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // ���������� ������������� �� �����������
            });
        }
    }
}
