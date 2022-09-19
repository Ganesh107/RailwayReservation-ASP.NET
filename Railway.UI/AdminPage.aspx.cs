using Railway.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;

namespace Railway.UI
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Adminid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        //Function to add new trains
        protected void AddTrainButton_Click(object sender, EventArgs e)
        {
            try
            {
                TraininfoService traininfoService = new TraininfoService();
                Traininfo train = new Traininfo();

                //assigning values for properties of Traininfo entity
                train.Trainnumber =  int.Parse(TrainnumTextbox.Text.Trim());
                train.Trainname = TrainnameTextbox.Text.Trim();
                train.Startloc = StartlocTextBox.Text.Trim();
                train.Endloc = EndlocTextBox.Text.Trim();
                train.Arrivaltime = ArrivaltimeTextBox.Text.Trim();
                train.Arrivaldate = ArrivaldateTextBox.Text.Trim();
                train.Departuretime = DeparturetimeTextBox.Text.Trim();
                train.Ac3tier = int.Parse(SeatsTextBox.Text.Trim());
                train.Ac2tier = int.Parse(Ac2tierTextBox.Text.Trim());
                train.Sleeper = int.Parse(SleeperTextBox.Text.Trim());
                train.Tatkal = int.Parse(TatkalTextBox.Text.Trim());
                train.Ladies = int.Parse(LadiesTextBox.Text.Trim());

                //checking whether train_number already exists
                if (traininfoService.CheckIfTrainnumberExists(train.Trainnumber))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Operation Failed','Train Number already exists!!','error')", true);
                    TrainnumTextbox.Text = "";
                    TrainnameTextbox.Text = "";
                    StartlocTextBox.Text = "";
                    EndlocTextBox.Text = "";
                    ArrivaltimeTextBox.Text = "";
                    DeparturetimeTextBox.Text = "";
                    ArrivaldateTextBox.Text = "";
                    Ac2tierTextBox.Text = "";
                    SeatsTextBox.Text = "";
                    TatkalTextBox.Text = "";
                    LadiesTextBox.Text = "";
                    SleeperTextBox.Text = "";
                    TrainnumTextbox.Focus();
                }
                else
                {
                    //calling AddTrains() in business layer
                    traininfoService.AddTrains(train);
                    Response.Redirect("EditTrains.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}