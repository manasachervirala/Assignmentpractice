﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace stu
{
	public partial class stu : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString);
		protected void Page_Load(object sender, EventArgs e)

		{
			if (!IsPostBack)
			{
				bind();
			}
		}
		public void bind()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("SELECT * from Student", con);
			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds, "Student");
			repeater2.DataSource = ds.Tables[0];
			repeater2.DataBind();
		}

	}
}

		
	
	
