using parcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcial.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult indexV()
        {
            return View();
        }

        [HttpGet]
        public ActionResult correcto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult error()
        {
            return View();
        }


        [HttpPost]
        public ActionResult indexV(cajero c)
        {

            if (c.monto % 5 == 0)
            {
                return Redirect("correcto");
            }
            else
            {
                return Redirect("Error");
            }
        }
    }
}