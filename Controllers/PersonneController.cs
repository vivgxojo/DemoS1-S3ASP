using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels;

namespace WebApplication2.Controllers
{
    public class PersonneController : Controller
    {
        public IActionResult Index()
        {
            Personne p = new Personne(1, "Alex");
            return View(p);
        }

        public IActionResult Liste() {
            List<Personne> liste = new List<Personne>();
            liste.Add(new Personne(2, "Bob"));
            liste.Add(new Personne(3, "Amélie"));
            liste.Add(new Personne(4, "Jo"));
            return View("ListePersonnes", liste);
        }
        public IActionResult Registre()
        {
            Registre r = new Registre();
            r.Personne = new Personne(2, "Bob");
            r.Armes.Add(new Arme(1, "Bâton"));
            r.Armes.Add(new Arme(2, "Parapluie"));
            return View(r);
        }
    }
}
