using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Task_1
{
    public class Startup //����� "������� �����"
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//��������� �������, ����������� ��� ������ MVC
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //����� ���������� �� ��������� ��������
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//���������� �������� � ��������� �������������� ��������� ����������.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("name", "{controller}/{action}");
            });
        }
    }
}
