namespace Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllerRoute(
                name: "Default",
                pattern : "{controller=home}/{action=index}/{id?}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
