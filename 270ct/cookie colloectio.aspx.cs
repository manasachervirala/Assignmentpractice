using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie_collection
{
	public partial class cookie_colloectio : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//setting the Expiry Date and Time of The Cokkies
			Response.Cookies["computers"].Expires = DateTime.Now.AddDays(-1);
		}

		protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
		{
			Label2.Text = "please selected ur choice";
			//..........Adding Cookies............//
			if (iphone.Checked)
				Response.Cookies["computer"]["iphone"] = "you are checked for iphone and cookie triggered";
			if (real.Checked)
				Response.Cookies["computer"]["real me"] = "you are checked for iphone and cookie triggered";

			if (Vivo.Checked)
				Response.Cookies["computer"]["vivo"] = "you are checked for iphone and cookie triggered";
			//......Fetching the cookie.....//

			if (Request.Cookies["computer"].Values.ToString()!= null)
			{
				if (Request.Cookies["computer"]["iphone"] != null)
					Label2.Text = Label2.Text + Response.Cookies["computer"]["iphone"] + " " + " ";
				if (Request.Cookies["computer"]["real"] != null)
					Label2.Text = Label2.Text + Response.Cookies["computer"]["real me"] + " " + " ";
				if (Request.Cookies["computer"]["vivo"] != null)
					Label2.Text = Label2.Text + Response.Cookies["computer"]["vivo"] + " " + " ";
			}
			else
			{
				Label2.Text = "please select your choice";
				Response.Cookies["computers"].Expires = DateTime.Now.AddDays(-1);
			}
		}


	}
}