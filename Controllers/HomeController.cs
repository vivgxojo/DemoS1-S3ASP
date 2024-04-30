using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Action2()
        {
            return View("Vue2");
        }
        public ActionResult Action3(string id)
        {
            ViewData["param"] = id;
            return View();
        }

        /// <summary>
        /// Démo des paramètres
        /// </summary>
        /// <param name="id">Le id qui est envoyé à la vue</param>
        /// <param name="option">a ou b pour choisir la vue recoit le id</param>
        /// <returns>la vue, avec ou sans id, ou un message d'erreur</returns>
        public ActionResult Action4(string id, string option)
        {
            if(option == "a")
            {
                ViewData["param"] = id;
                return View();
            }
            else if(option == "b")
            {
                return View();
            }
            else
            {
                ViewData["erreur"] = "Le id est obligatoire et l'option doit être a ou b.";
                return View("Erreur");
            }
        }

        public ContentResult SendContent()
        {
            string s = "<h2>Bienvenu dans mon site web</h2>";
            return Content(s, "text/html");
        }
    }
}
