using RejestracjaBillenniumPraktyki.DAL;
using RejestracjaBillenniumPraktyki.Models;
using System.Web.Mvc;

namespace RejestracjaBillenniumPraktyki.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddApplication(Registration registration)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Status = false;
                ViewBag.Message = "Nie dodano!";
                return View("Index", registration);              
            }
            else
            {
                RegistrationContext registrationContext = new RegistrationContext();
                registrationContext.Registrations.Add(registration);
                registrationContext.SaveChanges();
                ViewBag.Status = true;
                ViewBag.Message = "Dodano aplikację!";
            }
            return View("Index");
        }
    }
}