namespace IAshop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using IAshop.Data.Models;

    public class CategoriesSeeder : ISeeder
    {

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Gaming" });
            await dbContext.Categories.AddAsync(new Category { Name = "Toys" });
            await dbContext.Categories.AddAsync(new Category { Name = "Books" });

            await dbContext.SaveChangesAsync();
        }
    }
}
