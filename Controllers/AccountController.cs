    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    namespace punto.Controllers
    {
        public class AccountController : Controller
        {
            public IActionResult Login()
            {
                return View();
            }

            

        }

        

    }

    