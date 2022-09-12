namespace HeadlessTest
{
    public class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args)
                .Build()
                .Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureUmbracoDefaults()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                });
    }
}

// var builder = WebApplication.CreateBuilder(args);
// builder.Logging.ClearProviders();
// builder.Logging.AddConsole();

// builder.Host.ConfigureUmbracoDefaults();

// builder.Services.AddRazorPages();
// builder.Services
//     .AddUmbraco(builder.Environment, builder.Configuration)
//     .AddBackOffice()
//     .AddWebsite()
//     .AddComposers()
//     .Build();

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
//     app.UseDeveloperExceptionPage();

// app.UseStaticFiles();

// app.UseUmbraco()
//     .WithMiddleware(u =>
//     {
//         u.UseBackOffice();
//         u.UseWebsite();
//     })
//     .WithEndpoints(u =>
//     {
//         u.UseInstallerEndpoints();
//         u.UseBackOfficeEndpoints();
//         u.UseWebsiteEndpoints();
//     });

// //if (!app.Environment.IsDevelopment())
// //{
// //    app.UseExceptionHandler("/Error");
// //    app.UseHsts();
// //}

// //app.UseHttpsRedirection();


// //app.UseRouting();

// //app.UseAuthorization();

// //app.MapRazorPages();

// app.Run();