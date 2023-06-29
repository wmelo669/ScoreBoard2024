namespace ScoreBoard.Models
{
    public class Jeu
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateSortie { get; set; }
        public string Description { get; set; }
        public int JoueurId { get; set; }
        public Joueur Joueur { get; set; }
        public int ScoreJoueur { get; set; }
        public DateTime DateEnregistrement { get; set; }
    }
}
