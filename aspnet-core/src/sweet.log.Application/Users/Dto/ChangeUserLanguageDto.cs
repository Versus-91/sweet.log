using System.ComponentModel.DataAnnotations;

namespace sweet.log.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}