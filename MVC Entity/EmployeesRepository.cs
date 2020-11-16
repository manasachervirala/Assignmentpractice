using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myapp.models;

namespace MYApp.Db.Dpoperations
{
	public class EmployeesRepository
	{
		public int AddEmployee(EmployeeModels model)
		{
			using (var context = new empdbEntities())
			{
				Employee emp = new Employee()
				{
					FirstName = model.FirstName,
					LastName = model.LastName,
					Email = model.Email,
					Code = model.Code
				};
				context.Employee.Add(emp);
				context.SaveChanges();
				return emp.Id;
			}
			
		}
		public List<EmployeeModels> GetAllEmployees()
		{
			using (var context = new empdbEntities())
			{
				var result = context.Employee
					.Select(x => new EmployeeModels()
					{
						Id = x.Id,
						Addressid = x.Addressid,
						Code = x.Code,
						Email = x.Email,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Address=new AddressModel()
						{
							Id=x.Address.Id,
							Details=x.Address.Details,
							Country=x.Address.Country,
							state=x.Address.state
						}
					}).ToList();
				return result;
			}

		}
		public EmployeeModels GetEmployee(int id)
		{
			using (var context = new empdbEntities())
			{
				var result = context.Employee
					.Where(x => x.Id == id)
					.Select(x => new EmployeeModels()
					{
						Id = x.Id,
						Addressid = x.Addressid,
						Code = x.Code,
						Email = x.Email,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Address = new AddressModel()
						{
							Id = x.Address.Id,
							Details = x.Address.Details,
							Country = x.Address.Country,
							state = x.Address.state
						}
					}).FirstOrDefault();
				return result;
			}
		}
		public bool UpdateEmployee(int id,EmployeeModels models)
		{
			using (var context = new empdbEntities())
			{
				var employee = new Employee();
				if(employee != null)
				{
					employee.FirstName = models.FirstName;
					employee.LastName = models.LastName;
					employee.Email = models.Email;
					employee.Code = models.Code;
					employee.Addressid = models.Addressid;
				}
				context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
				return true;
			}
		}
		public bool DeleteEmployee(int id)
		{
			using (var context = new empdbEntities())
			{
				var emp = new Employee()
				{
					Id=id
				};
				context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
				context.SaveChanges();
				return false;
			}
		}
	}
}
