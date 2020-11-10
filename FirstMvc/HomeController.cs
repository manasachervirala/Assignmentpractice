using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "My name is manasa.";
			ViewBag.manasa = "congrats";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your manasa.chervirala.";

			return View();
		}
	}
}