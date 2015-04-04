using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Step.Logic.Admin
{
    public class HomeController:Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}
