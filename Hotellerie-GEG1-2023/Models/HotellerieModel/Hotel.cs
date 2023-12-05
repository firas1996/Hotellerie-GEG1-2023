using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GEG1_2023.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The name atribute is required !!!")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="The name must be between 3 and 20 chars !!")]
        public string Nom { get; set; }
        [Range(1,5,ErrorMessage ="You must set a number between 1 and 5 !!!")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage = "The Ville atribute is required !!!")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "The SiteWeb atribute is required !!!")]
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$",ErrorMessage ="You must set a valid URL !!")]
        [Display(Name ="Site Web")]
        public string SiteWeb { get; set; }
        public string Tel { get; set; }
        public virtual ICollection<Appreciation>? Appreciations { get; set; } = new List<Appreciation>();
    }
}
