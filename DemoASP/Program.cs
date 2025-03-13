namespace DemoASP
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{Action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
