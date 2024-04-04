using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Joueur:IValidatableObject
    {
        List<ValidationResult> validationResults = new List<ValidationResult>();

        [Required]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Nom { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Prenom { get; set; }

        [RegularExpression(@"^[A-Z\xC0-\xD6\xD8-\xDE]{2,4}$")]
        public string? Equipe { get; set; }

        
        public string? Telephone { get; set; }

        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@scoreboard\.ca$", ErrorMessage = "")]
        [Required]
        public string Courriel { get; set; }


        public List<Jeu>? Jeux { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validation de l'émail
            if(Courriel != $"{Id}@scoreboard.ca")
            {
                validationResults.Add(new ValidationResult("Votre courriel doit etre composé de votre identifiant suivi de: @scoreboard.ca"));
            }

            return validationResults;

        }
    }
}
