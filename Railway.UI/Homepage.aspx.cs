using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Railway.UI
{
    public partial class Testpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {             
                DateTextBox.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd"); //blanking past dates
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StartlocationList.Text == EndlocationList.Text)
                {
                    EndlocationList.Text = "";
                    EndlocationList.Focus();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Invalid details','Starting location and ending location cannot be same','warning')", true);
                }

                else
                {
                    Session["Startloc"] = StartlocationList.Text;
                    Session["Endloc"] = EndlocationList.Text;
                    Session["Date"] = DateTextBox.Text;
                    Response.Redirect("TrainInfo.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}