using System.ComponentModel.DataAnnotations;

namespace Dataplatform.SqlManager.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}