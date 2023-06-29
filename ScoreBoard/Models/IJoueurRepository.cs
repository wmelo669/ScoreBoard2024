namespace ScoreBoard.Models
{
    public interface IJoueurRepository
    {
        public List<Joueur> ListeJoueurs { get; set; }
        public Joueur? GetJoueur(int id);
        public void Modifier(Joueur joueur);
        public void Supprimer(int id);
    }
}
