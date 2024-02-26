using System.ComponentModel.DataAnnotations;

namespace SuryaVineforceProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}