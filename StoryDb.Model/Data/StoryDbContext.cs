using Microsoft.EntityFrameworkCore;
using StoryDb.Model.Data.Configurations.Relationships;
using StoryDb.Model.Data.Configurations.Validations;
using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data
{
    // Класс контекста Базы данных
    public class StoryDbContext : DbContext
    {
        // создание экземпляра таблицы базы данных
        public DbSet<Character> Characters { get; set; }

        // Настройка подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storyDb");
        }

        // Подключение настройки связей таблиц и Валидации
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterValidation());
        }
    }
}
