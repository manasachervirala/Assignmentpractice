using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApplication.Controllers
{
    public class MusicStroreController : Controller
    {
        // GET: MusicStrore
		[ActionName("manasa")]
		[HttpGet]
        public ActionResult Index()
        {
            return View();
        }
		[ActionName("karthik")]
		[HttpPost]
		public string Welcome()
		{
			return "hello this is welcome action message";
			
		}
		[ActionName("Jacksaprrow")]
		[HttpPatch]
		public string ShowMusic(string MusicTitle)

		{
			return "you have selected" + MusicTitle + "Music";
		}
		public void function(string name)
		{
			Response.Write("You have selected" + "name" + "music");
		}
	
    }
}