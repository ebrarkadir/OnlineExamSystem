using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}