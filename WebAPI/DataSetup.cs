using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Data.Entity;

namespace WebAPI
{
    public static class DataSetup
    {
        internal static async Task UseDemoDbSetupAsync(this WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var context = services.GetService<DemoApiContext>();
                await context.Database.MigrateAsync();
                await SeedAsync(context);
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An error occured during migration.");
            }

        }
        private static async Task SeedAsync(DemoApiContext context)
        {
            if(context.Quotes.Any())
            {
                return;
            }
            List<Quote> quotes = new List<Quote>();
            Quote q1 = new Quote
            {   
                Name = "Good morning have a nice day"
            };
            Quote q2 = new Quote
            {   
                Name = "Good morning have a beautiful day"
            };
            Quote q3 = new Quote
            {   
                Name = "Good morning have an excellent day"
            };
            quotes.Add(q1);
            quotes.Add(q2);
            quotes.Add(q3);

            foreach(Quote q in quotes)
            {
                context.Quotes.Add(q);
            }
            await context.SaveChangesAsync();
        }
    }
}
