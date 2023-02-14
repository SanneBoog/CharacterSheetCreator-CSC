using CharSheetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharSheetBackend.Controller
{
    [Route("api")]
    [ApiController]
    public class CharacterDetailController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CharacterDetailController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("characters/all")]
        public IEnumerable<CharacterDetail> GetAll()
        {
            var details = _context.CharacterDetails
                .Select(p => new CharacterDetail
                {
                    CharacterId = p.CharacterId,
                    CharacterName = p.CharacterName,
                    Class = p.Class,
                    Level = p.Level,
                    Background = p.Background,
                    PlayerName = p.PlayerName,
                    Race = p.Race,
                    Alignment = p.Alignment,
                });

            return details;
        }

        [HttpGet("character/{characterId}")]
        public async Task<ActionResult<CharacterDetail>> GetById(int characterId)
        {
            var character = await _context.CharacterDetails
                .Select(p => new CharacterDetail
                {
                    CharacterId = p.CharacterId,
                    CharacterName = p.CharacterName,
                    Class = p.Class,
                    Level = p.Level,
                    Background = p.Background,
                    PlayerName = p.PlayerName,
                    Race = p.Race,
                    Alignment = p.Alignment,

                })
                .FirstOrDefaultAsync(p => p.CharacterId == characterId);

            if (character == null)
            {
                throw new Exception();
            }

            return character;
        }

        [Route("character/create")]
        [HttpPost]
        public async Task<ActionResult<CharacterDetail>> Create(CharacterDetail characterDetail)
        {
 
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var random = new Random();
            characterDetail.CharacterId = random.Next();

            using (var context = _context)
            {
                context.CharacterDetails.Add(characterDetail);
                await context.SaveChangesAsync();
            }
            return CreatedAtAction(nameof(GetById), new { characterId = characterDetail.CharacterId }, characterDetail);
        }
        //[HttpPut("{characterId}")]
        //public void Update(int characterId, [FromBody] CharacterDetail product)
        //{
        //    // Update an existing product
        //}

        //[HttpDelete("{characterId}")]
        //public void Delete(int characterId)
        //{
        //    // Delete a product by ID
        //}
    }
}
