using System.ComponentModel.DataAnnotations;

namespace TrafficManagementBusinessCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}