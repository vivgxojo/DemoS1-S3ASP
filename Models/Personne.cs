namespace WebApplication2.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Personne(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }   
    }
}
