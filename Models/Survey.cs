#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name should be at least 2 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Favorite Language is required.")]
        public string Language { get; set; }

        [MinLength(20, ErrorMessage = "Comment should be at least 20 characters.")]
        public string Comment { get; set; }
    }
}
