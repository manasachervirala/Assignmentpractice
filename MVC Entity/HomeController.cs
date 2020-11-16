using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myapp.models;
using MYApp.Db.Dpoperations;

namespace MVCappwithdb.Controllers
{
    public class HomeController : Controller
    {
		EmployeesRepository repository = null;

		public HomeController()
		{
			repository = new EmployeesRepository();
		}
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Create(EmployeeModels model)
		{
			if(ModelState.IsValid)
			{
				int id = repository.AddEmployee(model);
				if(id>0)
				{
					ModelState.Clear();
					ViewBag.Issuccess = "Data Added";
				}
			}
			return View();
		}
		public ActionResult GetAllRecords()
		{
			var result = repository.GetAllEmployees();
			return View();
		}
		public ActionResult Details(int id)
		{
			var result = repository.GetAllEmployees();
			return View();

		}
		public ActionResult Edit()
		{
			var result = repository.GetAllEmployees();
			return View();
		}
		[HttpPost]
		public ActionResult Edit(EmployeeModels model)
		{
			if(ModelState.IsValid)
			{
				repository.UpdateEmployee(model.Id, model);
				return RedirectToAction("GelAllRecords");
			}
			return View();
		}
		[HttpPost]
		public ActionResult Delete(int id)
		{
			repository.DeleteEmployee(id);
			return RedirectToAction("GetAllRecords");
		}
	}
}