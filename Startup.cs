using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession(options => {
                options.Cookie.Name = ".NumberGuess.Session";
                options.IdleTimeout = System.TimeSpan.FromSeconds(1000);
                options.Cookie.IsEssential = true;

            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            
            app.UseRouting();
            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });*/
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "doctor",
                    pattern: "Doctor",
                    defaults: "{controller=DoctorController}/{action=FeverCheck}/{id?}");
                endpoints.MapControllerRoute(
                    name: "number",
                    pattern: "GuessingGame",
                   
                   defaults: new { controller = "NumberGuess", action = "index" }
                   );
                endpoints.MapControllerRoute(
                    name: "student",
                    pattern: "/Student/Details",
                   
                   defaults: new { controller = "StudentController", action = "Details" }
                   );
                endpoints.MapControllerRoute(
                    name: "peopleDefault",
                    pattern: "{controller=PeopleListController}/{action=People}/{id?}",
                    defaults: new { controller = "PeopleListController", action = "People" }
                    );
                endpoints.MapControllerRoute(
                    name: "people",
                    pattern: "People",
                    defaults: new { controller = "PeopleListController", action = "People" }
                    );


            });

        }
        
    }
}
