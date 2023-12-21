using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace vm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=172.206.232.31,1433; User Id=king; Password=Kingkotesh@123; Initial Catalog=kingdb");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into emp values(" + Int32.Parse(txtid.Text) + ",'" + txtname.Text + "','" + txtdept.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}