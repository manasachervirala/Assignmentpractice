using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Myapp.models
{
	public class EmployeeModels
	{
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		public int? Addressid { get; set; }
		[Required]
		public string Code { get; set; }
		public AddressModel Address { get; set; }
	}
}
