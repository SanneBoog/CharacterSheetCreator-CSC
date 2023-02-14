using CharSheetBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharSheetBackend.Controller
{
    [Route("api")]
    [ApiController]
    public class AbilityScoresController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AbilityScoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("abilityScores/{characterId}")]
        public async Task<ActionResult<AbilityScore>> GetById(int characterId)
        {
            var character = await _context.AbilityScores
                .Select(p => new AbilityScore
                {
                    AbilityScoresId = p.AbilityScoresId,
                    CharacterId = p.CharacterId,
                    Strength = p.Strength,
                    Dexterity = p.Dexterity,
                    Constitution = p.Constitution,
                    Intelligence = p.Intelligence,
                    Wisdom = p.Wisdom,
                    Charisma = p.Charisma,
                })
                .FirstOrDefaultAsync(p => p.CharacterId == characterId);

            if (character == null)
            {
                throw new Exception();
            }

            return character;
        }
    }
}
