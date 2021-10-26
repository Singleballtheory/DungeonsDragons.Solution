using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DungeonsDragons.Models;

namespace DungeonsDragons.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CharactersController : ControllerBase
  {
    private readonly DungeonsDragonsContext _db;

    public CharactersController(DungeonsDragonsContext db)
    {
      _db = db;
    }

    // GET api/characters
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Character>>> Get(string name, string profession, string weapon, string age, string gender)
    {
      var query = _db.Characters.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (profession != null)
      {
        query = query.Where(entry => entry.Profession == profession);
      }

      if (weapon != null)
      {
        query = query.Where(entry => entry.Weapon == weapon);
      }

      if (age != null)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      return await query.ToListAsync();
    }

    // POST api/characters
    [HttpPost]
    public async Task<ActionResult<Character>> Post(Character character)
    {
      _db.Characters.Add(character);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCharacter), new { id = character.CharacterId }, character);
    }

    // GET: api/Characters/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);

      if (character == null)
      {
        return NotFound();
      }

      return character;
    }

    // PUT: api/Characters/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Character character)
    {
      if (id != character.CharacterId)
      {
        return BadRequest();
      }

      _db.Entry(character).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CharacterExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // DELETE: api/Characters/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);
      if (character == null)
      {
        return NotFound();
      }

      _db.Characters.Remove(character);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool CharacterExists(int id)
    {
      return _db.Characters.Any(e => e.CharacterId == id);
    }
  }
}