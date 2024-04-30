namespace WebApplication2.Models.ViewModels
{
    public class Registre
    {
        public Personne Personne { get; set; }
        public List<Arme> Armes { get; set; }

        public Registre()
        {
            Armes = new List<Arme>();
        }

        public Registre(Personne personne, List<Arme> armes)
        {
            Personne = personne;
            Armes = armes;
        }
    }
}
