using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;
using Railway.Entities;

namespace Railway.UI
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Function to validate user login
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = int.Parse(UseridTextbox.Text);
                string password = PasswordTextbox.Text;
                PassengersService passengers = new PassengersService();

                //calling business layer method
                Passengers passenger = passengers.ValidateUser(userid, password);
                if (passenger.Passwords == password)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Login Success','Welcome Back!','success')", true);
                    Session["Userid"] = passenger.Userid;
                    Session["Username"] = passenger.Pname;
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    UseridTextbox.Text = "";
                    PasswordTextbox.Text = "";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Login Failed','Invalid details','error')", true);           
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to redirect to signup page
        protected void SignupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignup.aspx");
        }
    }
}