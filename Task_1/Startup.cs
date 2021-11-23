using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Task_1
{
    public class Startup //класс "входная точка"
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//добавляет сервисы, необходимые для работы MVC
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //метод отвечающий за обработку запросов
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//Добавление маршрута в коллекцию обрабатываемых маршрутов приложения.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("name", "{controller}/{action}");
            });
        }
    }
}
