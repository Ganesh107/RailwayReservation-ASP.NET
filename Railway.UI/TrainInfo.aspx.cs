using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;
using System.Data;

namespace Railway.UI
{
    public partial class TrainInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    StartlocList.Text = Session["Startloc"].ToString();
                    EndlocList.Text = Session["Endloc"].ToString();
                    DateTextBox.Text = Session["Date"].ToString();
                    DateTextBox.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd"); //blanking past dates

                    //instantiating business class object
                    TraininfoService traininfoService = new TraininfoService();
                    DataTable dt = traininfoService.FilterTrains(Session["Startloc"].ToString(), Session["Endloc"].ToString(), Session["Date"].ToString());

                    //poupulating gridview with result
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiating business class object
                TraininfoService traininfoService = new TraininfoService();
                DataTable dt = traininfoService.FilterTrains(StartlocList.Text, EndlocList.Text, DateTextBox.Text);

                //poupulating gridview with result
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void GetTrainDetails(object sender, EventArgs e)
        {
            try
            {
                //redirect to login page if user is not logged in
                if (Session["Userid"] == null)
                {
                    Response.Redirect("UserLogin.aspx");
                }
                else
                {
                    //get row data of required row 
                    var btn = (Control)sender;
                    GridViewRow row = (GridViewRow)btn.NamingContainer;
                    Session["trainnumber"] = row.Cells[1].Text;
                    Session["trainname"] = row.Cells[2].Text;
                    Session["startloc"] = row.Cells[3].Text;
                    Session["endloc"] = row.Cells[4].Text;
                    Session["arrivaltime"] = row.Cells[5].Text;
                    Session["departuretime"] = row.Cells[6].Text;
                    Session["arrivaldate"] = row.Cells[7].Text;
                    Session["ticketclass"] = ClassDownList.Text;
                    Session["Ac2tier"] = row.Cells[8].Text;
                    Session["Sleeper"] = row.Cells[9].Text;
                    Session["AC3tier"] = row.Cells[10].Text;
                    Session["Tatkal"] = row.Cells[11].Text;
                    Session["Ladies"] = row.Cells[12].Text;
                    Response.Redirect("BookTicket.aspx");
                }              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}