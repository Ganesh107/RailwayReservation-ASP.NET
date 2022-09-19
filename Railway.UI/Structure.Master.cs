using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Railway.UI
{
    public partial class Structure : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
                Response.Cache.SetNoStore();
                if (Session["Userid"] == null)
                {
                    LogoutButton.Visible = false;
                }
                else
                {
                    Welcome.Text = "Hello, "+ Session["Username"].ToString()+" ";
                    LogoutButton.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void LogoutButton_Click1(object sender, EventArgs e)
        {
            try
            {
                if (Session["Userid"] != null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Good Bye!','Log out successfull!','success')", true);
                    Session["Userid"] = null;
                    Welcome.Visible = false;
                    LogoutButton.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}