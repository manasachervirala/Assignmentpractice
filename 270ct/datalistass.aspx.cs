using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace datalistass
{
	public partial class datalistass : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataTable Table = new DataTable();
			Table.Columns.Add("Fname");
			Table.Columns.Add("Lname");
			Table.Columns.Add("Designation");
			Table.Columns.Add("Location");
			Table.Columns.Add("Country");

			Table.Rows.Add(101, "MANASA", "SE", "Hyd", "India");
			Table.Rows.Add(102, "Sowmya", "HR", "Delhi", "India");
			Table.Rows.Add(103, "swathi", "QA", "Bangalor", "India");
			Table.Rows.Add(104, "ramya", "SE", "Channai", "India");
			Table.Rows.Add(105, "haritha", "JE", "Delhi", "India");
			Table.Rows.Add(106, "pricilla", "SE", "Delhi", "India");
			Table.Rows.Add(107, "anvitha", "JE", "Channai", "India");
			Table.Rows.Add(108, "jiya", "HR", "Bangalor", "India");
			Table.Rows.Add(109, "kushoo", "HR", "Delhi", "India");
			Table.Rows.Add(110, "prem", "SE", "Channai", "India");




			datalist1.DataSource = Table;
			datalist1.DataBind();
		}
	}
}