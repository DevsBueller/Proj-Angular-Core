using System.ComponentModel.DataAnnotations;

namespace PrototipoSistemaFGV.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}