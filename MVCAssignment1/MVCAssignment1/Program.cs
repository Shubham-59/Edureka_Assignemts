namespace MVCAssignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("/end"))
                {
                    await context.Response.WriteAsync("Terminating chain");
                    return;
                }
                await next();
            });
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("hello"))
                {
                    await context.Response.WriteAsync("Hello ");
                }
                await next();
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("hello"))
                {
                    await context.Response.WriteAsync("Hello1 ");
                    await next();
                    await context.Response.WriteAsync("Hello2 ");
                }
                await next();
            });

            


            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
