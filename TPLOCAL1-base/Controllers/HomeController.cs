using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "Form":
                        return View("Form", new FormModel());
                   
                    case "Avis":
                        {
                            List<Opinion> opinionList = new OpinionList().GetAvis("XlmFiles/DataAvis.xml");
                            ViewBag.opinionList = opinionList;
                            return View(id);
                        }
                    case "Validation":
                        return View(id);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        [HttpPost]
        public ActionResult ValidationFormulaire(FormModel model)
        {
            if (ModelState.IsValid)
            {

                return View("Validation", model);
            }
            else
            {
                return View("Form", model);
            }
        }
    }
}