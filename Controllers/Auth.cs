using Microsoft.AspNetCore.Mvc;

namespace yeni_klasor_adi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return RedirectToAction("Tanitim");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı";
            return View();
        }

        public IActionResult Tanitim()
        {
            return View();
        }
    }
}