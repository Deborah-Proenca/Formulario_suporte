using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteFabio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Formulario()
        {
           
            return View();
        }

        public ActionResult About()
        {
            var model = new TesteFabio.Models.Formulario();
            //model.Nome = "Deborah";
            return View(model);
        }

        [HttpPost]
        public ActionResult Salvar(TesteFabio.Models.Formulario model)
        {
            //model.Nome = "Deborah";
            return Redirect("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sobre: ";
            

            return View();
        }
    }
}