using Laboratorio181.Models; // Asegúrate de incluir esta línea
using System.Linq;
using System.Web.Mvc;

namespace Laboratorio181.Controllers
{
    public class AccessController : Controller
    {
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            using (var db = new YourDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if (user != null)
                {
                    return RedirectToAction("Welcome");
                }
                else
                {
                    ViewBag.Error = "Invalid email or password.";
                    return View("Index");
                }
            }
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}
