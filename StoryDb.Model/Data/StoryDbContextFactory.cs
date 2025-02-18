using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data
{
    internal class StoryDbContextFactory : IDesignTimeDbContextFactory<StoryDbContext>
    {
        public StoryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StoryDbContext>();
            optionsBuilder.UseSqlite("Data Source=storyDb");

            return new StoryDbContext(optionsBuilder.Options);
        }
    }
}
