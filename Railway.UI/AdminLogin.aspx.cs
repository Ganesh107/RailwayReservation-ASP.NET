using Railway.BusinessLayer;
using Railway.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Railway.UI
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //Function to validate admin details
        protected void ValidateLogin(object sender, EventArgs e)
        {
            try
            {
                int adminid = int.Parse(AdminidTextbox.Text);
                string password = AdminPasswordTextbox.Text;
                AdminService adminService = new AdminService();

                //calling business layer method
                Admins admin = adminService.ValidateAdmin(adminid, password);
                if (admin.Passwords == password)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Login Success','Welcome Admin!','success')", true);
                    Session["Adminid"] = admin.Adminid;                   
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Login Failed','Invalid details','error')", true);
                    AdminidTextbox.Text = "";
                    AdminPasswordTextbox.Text = "";
                    AdminidTextbox.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void AdminSignupButton_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("EditTrains.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}