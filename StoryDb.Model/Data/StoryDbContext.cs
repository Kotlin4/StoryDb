using Microsoft.EntityFrameworkCore;
using StoryDb.Model.Data.Configurations.Relationships.Character;
using StoryDb.Model.Data.Configurations.Validations;
using StoryDb.Model.Entities.Archetype;
using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data
{
    // Класс контекста Базы данных
    public class StoryDbContext : DbContext
    {
        // создание экземпляра таблицы базы данных
        public DbSet<CharacterI> CharacterIs { get; set; }
        public DbSet<Characteristic_U> characteristic_Us { get; set; }
        public DbSet<Characteristic_U_Type> Characteristic_U_Types { get; set; }
        public DbSet<ArchetypeI> ArchetypeIs { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Characteristic_Character> Characteristic_Characters { get; set; }

        // Настройка подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storyDb");
        }

        // Подключение настройки связей таблиц и Валидации
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
