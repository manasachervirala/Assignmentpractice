using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookie
{
	public partial class cookie : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//creating the cookie.....//
			// creating the Http cookie instance by specifying the name//

			HttpCookie cookie = new HttpCookie("student");
			//assign the value to the created cookie
			cookie.Value = "manasa";
			

			//add the cookie to response instance
			Response.Cookies.Add(cookie);
			//......Fetch the cookie created.......//
			var Cookie_Value= Response.Cookies["student"].Value;
			// Label returning with the cookie information

			Label1.Text = Cookie_Value;

		}
	}
}