using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;

namespace Railway.UI
{
    public partial class BookTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
                if (!IsPostBack)
                {
                    //assigning bootstrap card label - values dynamically
                    TrainnameLabel.Text = Session["trainname"].ToString();
                    DeparturetimeLbel.Text = Session["departuretime"].ToString();
                    StartlocLabel.Text = Session["startloc"].ToString().ToUpper();
                    TimeLabel.Text = DateTime.Now.ToString("t")+"-----";
                    DestinationLabel.Text = Session["endloc"].ToString().ToUpper();
                    DateLabel.Text = Session["arrivaldate"].ToString();
                    ClassLabel.Text = Session["ticketclass"].ToString().ToUpper();
                    Label1.Text = Session["startloc"].ToString().ToUpper();
                    Label2.Text = Session["arrivaldate"].ToString();
                    Label3.Text = Session["arrivaltime"].ToString();
                    Label4.Text = Session["departuretime"].ToString();

                    //calculating ticket price
                    TicketrateService ticketrateService = new TicketrateService();
                    int rate = ticketrateService.GetTicketRate(Session["ticketclass"].ToString());
                    RateLabel.Text = rate.ToString();                   
                }
            }
			catch (Exception)
			{
				throw;
			}
        }

        protected void ConfirmPayment(object sender, EventArgs e)
        {
            try
            {
                TicketService ticketService = new TicketService();  
                string status = "";
                //reducing train seats
                if (Session["ticketclass"].ToString() == "AC-2 Tier")
                {
                    if (Convert.ToInt32(Session["Ac2tier"]) <= 0)
                    {
                        status = "Waitlist";
                    }
                    else
                    {
                        status = "Confirmed";
                    }
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateSeats(Convert.ToInt16(QuantityTextBox.Text), Convert.ToInt16(Session["trainnumber"]), Session["ticketclass"].ToString());

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    Response.Redirect("ViewTicket.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}