using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.ViewModel;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TablaRegistroViewModel model)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                using (chevezEntities db = new chevezEntities())
                {
                    var oRegister = new Register();
                    oRegister.nombre = model.nombre;
                    oRegister.email = model.email;
                    oRegister.conpania = model.conpania;
                    oRegister.contacto = model.contacto;
                    oRegister.celular = model.celular;
                    oRegister.pass = model.pass;

                    db.Register.Add(oRegister);
                    db.SaveChanges();
                }

                return Redirect(Url.Content("~/Home/Index"));
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }



            

            return Redirect(Url.Content("~/Home/Index"));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}