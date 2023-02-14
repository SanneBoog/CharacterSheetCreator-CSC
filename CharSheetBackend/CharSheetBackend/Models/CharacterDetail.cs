using System.ComponentModel.DataAnnotations;

namespace CharSheetBackend.Models;

public class CharacterDetail
{
    [Key]
    public int CharacterId { get; set; }
    public string CharacterName { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public string Background { get; set; }
    public string PlayerName { get; set; }
    public string Race { get; set; }
    public string Alignment { get; set; }
    public int ExperiencePoints { get; set; }
}
