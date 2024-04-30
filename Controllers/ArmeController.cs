using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ArmeController : Controller
    {
        List<Arme> listeArmes = Armes.lstArmes;

        public IActionResult Index()
        {
            //ViewBag = ViewData
            //.ListeArmes : clé
            ViewBag.ListeArmes = listeArmes;
            return View();
        }

        public IActionResult TrouverArme(int id)
        {
            Arme? arme = listeArmes.FirstOrDefault(x => x.Id == id);
            if(arme == null)
            {
                ViewBag.erreur = "L'arme n'a pas été trouvée";
                return View("Erreur");
            }
            ViewBag.Arme = arme;
            return View();
        }


    }
}
