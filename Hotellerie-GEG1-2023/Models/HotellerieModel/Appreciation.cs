using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GEG1_2023.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom de la personne est obligatoire.")]
        [Display(Name = "Nom Personne")]
        public string NomPers {  get; set; }
        [Required(ErrorMessage = "Le commentaire est obligatoire.")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel? Hotel { get; set; }
    }
}
