using PlatformSerice.Models;

namespace PlatformService.Data
{
    public static class PropDb
    {
        public static void PrepPopulation (IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<ApplicationDataContext>());
            }
        }
        private static void SeedData(ApplicationDataContext dataContext)
        {
            if(!dataContext.Platforms.Any())
            {
                Console.WriteLine("Создание данных...");
                dataContext.Platforms.AddRange(
                    new Platform() { Name = "DotNet", Publisher = "Microsoft", Cost = "Free"},
                    new Platform() { Name = "SQL", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Docker", Publisher = "Docker Inc.", Cost = "Free" },
                    new Platform() { Name = "Redis", Publisher = "Redis Labs", Cost = "Free" });
                dataContext.SaveChanges();
            }
            else 
            {
                Console.WriteLine("В базе данных уже есть данные");
            }
        }
    }
}
