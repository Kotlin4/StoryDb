using Microsoft.EntityFrameworkCore;
using StoryDb.Model.Data.Configurations.Tags;
using System.Reflection;

namespace StoryDb.Model.Data
{
    // Класс контекста Базы данных
    public class StoryDbContext : DbContext
    {
        public StoryDbContext() { }

        public StoryDbContext(DbContextOptions<StoryDbContext> options) : base(options) { }
        // Автоматическая регистрация DbSet для всех сущностей, реализующих IEntity
        public void RegisterAllEntities(ModelBuilder modelBuilder)
        {
            var entityTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IEntity).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (var entityType in entityTypes)
            {
                // Используем метод Set<TEntity>() для регистрации DbSet
                var method = typeof(ModelBuilder).GetMethod("Entity", new Type[] { });
                var genericMethod = method.MakeGenericMethod(entityType);
                genericMethod.Invoke(modelBuilder, null);
            }
        }

        // Настройка подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SQLitePCL.Batteries.Init();
            optionsBuilder.UseSqlite("Data Source=storyDb");
        }

        // Подключение настройки связей таблиц и Валидации
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Регистрация всех сущностей
            RegisterAllEntities(modelBuilder);

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition()
                == typeof(IEntityTypeConfiguration<>)));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
    }
}
