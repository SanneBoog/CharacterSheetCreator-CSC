using System.ComponentModel.DataAnnotations;

namespace CharSheetBackend.Models
{
    public class AbilityScore
    {
        [Key]
        public int AbilityScoresId { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int CharacterId { get; set; }

    }
}