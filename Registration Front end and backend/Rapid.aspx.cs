using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace rapid
{
	public partial class Rapid : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			//Response.Write("Your response is successfully sudmmited");
			SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTabelConnectionString"].ConnectionString);
			Connect.Open();
			var insertQuery = "insert into RegistrationTabel(Id,Name,Email,Password,City,Gender)values(@Id,@Name,@Email,@Password,@City,@Gender)";
			SqlCommand cmd = new SqlCommand(insertQuery, Connect);
			string gender = string.Empty;
			if (RadioButton1.Checked)
			{
				gender = "male";

			}
			else if (RadioButton2.Checked)
			{
				gender = "female";
			}
			cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
			cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
			cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
			cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
			cmd.Parameters.AddWithValue("@City", DropDownList1.Text);
			cmd.Parameters.AddWithValue("@Gender", gender);
			cmd.ExecuteNonQuery();


			Response.Write("records are stored successfully");

			Connect.Close();
		}

	}
}
