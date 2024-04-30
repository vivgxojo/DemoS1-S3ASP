namespace WebApplication2.Models
{
    public class Arme
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Arme(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }   
    }
}
