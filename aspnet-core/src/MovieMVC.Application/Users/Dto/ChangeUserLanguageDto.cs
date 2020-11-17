using System.ComponentModel.DataAnnotations;

namespace MovieMVC.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}