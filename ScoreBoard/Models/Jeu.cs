using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu : IValidatableObject
    {
        List<ValidationResult> validationResults = new List<ValidationResult>();

        [Required]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public DateTime DateSortie { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int JoueurId { get; set; }

        [Required]
        public Joueur Joueur { get; set; }

        [Required]
        public int ScoreJoueur { get; set; }

        [Required]
        public DateTime DateEnregistrement { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateSortie >= DateTime.Today)
            {
                validationResults.Add(new ValidationResult($"La date de sortie doit être inférieure a la date d'aujourd'hui: {DateTime.Today}"));
            }

            if (ScoreJoueur > 100 || ScoreJoueur < 0)
            {
                validationResults.Add(new ValidationResult("Assurez vous que le score du joueur soit entre 0 et 100"));
            }

            return validationResults;
        }
    }
}
