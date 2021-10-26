using Microsoft.EntityFrameworkCore;

namespace DungeonsDragons.Models
{
  public class DungeonsDragonsContext : DbContext
  {
    public DungeonsDragonsContext(DbContextOptions<DungeonsDragonsContext> options) : base(options)
    {

    }

    public DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Character>()
      .HasData(
        new Character { CharacterId = 1, Name = "Hank", Profession = "Ranger", Weapon = "Bow", Age = "15", Gender = "Male" },
        new Character { CharacterId = 2, Name = "Eric", Profession = "Cavalier", Weapon = "Shield", Age = "15", Gender = "Male" },
        new Character { CharacterId = 3, Name = "Diana", Profession = "Acrobat", Weapon = "Staff", Age = "14", Gender = "Female" },
        new Character { CharacterId = 4, Name = "Presto", Profession = "Magican", Weapon = "Hat", Age = "14", Gender = "Male" },
        new Character { CharacterId = 5, Name = "Sheila", Profession = "Thief", Weapon = "Cloak", Age = "13", Gender = "Female" },
        new Character { CharacterId = 6, Name = "Bobby", Profession = "Barbarian", Weapon = "Club", Age = "8", Gender = "Male" },
        new Character { CharacterId = 7, Name = "Uni", Profession = "Unicorn", Weapon = "Teleport", Age = "Unknown", Gender = "Female" },
        new Character { CharacterId = 8, Name = "Dungeon Master", Profession = "Dungeon Master", Weapon = "Magic", Age = "Unknown", Gender = "Male" }
      );
    }
  }
}