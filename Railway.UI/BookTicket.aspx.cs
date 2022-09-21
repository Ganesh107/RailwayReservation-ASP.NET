using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Railway.BusinessLayer;

namespace Railway.UI
{
    public partial class BookTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
                if (Session["Userid"] == null)
                {
                    Response.Redirect("UserLogin.aspx");
                }
                if (!IsPostBack)
                {
                    //making Textboxes invisible
                    NameTextBox1.Visible = false;
                    AgeTextBox1.Visible = false;
                    GenderList1.Visible = false;
                    BerthTextBox1.Visible = false;
                    CoachTextBox1.Visible = false;
                    CancelLinkButton.Visible = false;
                    CancelLinkButton1.Visible = false;

                    NameTextBox2.Visible = false;
                    AgeTextBox2.Visible = false;
                    GenderList2.Visible = false;
                    BerthTextBox2.Visible = false;
                    CoachTextBox2.Visible = false;
                    AddPassengerLinkButton1.Visible = false;

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
                    TotalrateLabel.Text = rate.ToString();
                    TotalRs.Text = TotalrateLabel.Text;
                }
            }
			catch (Exception)
			{
				throw;
			}
        }

        //Function to Generate tickets
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
                        status = "Waitlist"; //Ticket status = waitlist if seats <= 0
                    }
                    else
                    {
                        status = "Confirmed";
                    }

                    //updating seat
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateSeats(Convert.ToInt16(QuantityList.Text), Convert.ToInt16(Session["trainnumber"]));

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    if (NameTextBox1.Text != "" && AgeTextBox1.Text != "" && GenderList1.Text != "" && CoachTextBox1.Text != "" && BerthTextBox1.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox1.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox1.Text), Session["ticketclass"].ToString(), GenderList1.Text.ToString(), Convert.ToInt32(BerthTextBox1.Text), Convert.ToInt32(CoachTextBox1.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    if (NameTextBox2.Text != "" && AgeTextBox2.Text != "" && GenderList2.Text != "" && CoachTextBox2.Text != "" && BerthTextBox2.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox2.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox2.Text), Session["ticketclass"].ToString(), GenderList2.Text.ToString(), Convert.ToInt32(BerthTextBox2.Text), Convert.ToInt32(CoachTextBox2.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    Response.Redirect("ViewTicket.aspx");
                }
                else if (Session["ticketclass"].ToString() == "AC-3 Tier")
                {
                    if (Convert.ToInt32(Session["AC3tier"]) <= 0)
                    {
                        status = "Waitlist";
                    }
                    else
                    {
                        status = "Confirmed";
                    }

                    //upating seat
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateAc3TierSeats(Convert.ToInt16(QuantityList.Text), Convert.ToInt16(Session["trainnumber"]));

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    if (NameTextBox1.Text != "" && AgeTextBox1.Text != "" && GenderList1.Text != "" && CoachTextBox1.Text != "" && BerthTextBox1.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox1.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox1.Text), Session["ticketclass"].ToString(), GenderList1.Text.ToString(), Convert.ToInt32(BerthTextBox1.Text), Convert.ToInt32(CoachTextBox1.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    if (NameTextBox2.Text != "" && AgeTextBox2.Text != "" && GenderList2.Text != "" && CoachTextBox2.Text != "" && BerthTextBox2.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox2.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox2.Text), Session["ticketclass"].ToString(), GenderList2.Text.ToString(), Convert.ToInt32(BerthTextBox2.Text), Convert.ToInt32(CoachTextBox2.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    Response.Redirect("ViewTicket.aspx");
                }
                else if (Session["ticketclass"].ToString() == "Sleeper")
                {
                    if (Convert.ToInt32(Session["Sleeper"]) <= 0)
                    {
                        status = "Waitlist";
                    }
                    else
                    {
                        status = "Confirmed";
                    }

                    //upating seat
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateSleeperSeats(Convert.ToInt16(QuantityList.Text), Convert.ToInt16(Session["trainnumber"]));

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    if (NameTextBox1.Text != "" && AgeTextBox1.Text != "" && GenderList1.Text != "" && CoachTextBox1.Text != "" && BerthTextBox1.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox1.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox1.Text), Session["ticketclass"].ToString(), GenderList1.Text.ToString(), Convert.ToInt32(BerthTextBox1.Text), Convert.ToInt32(CoachTextBox1.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    if (NameTextBox2.Text != "" && AgeTextBox2.Text != "" && GenderList2.Text != "" && CoachTextBox2.Text != "" && BerthTextBox2.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox2.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox2.Text), Session["ticketclass"].ToString(), GenderList2.Text.ToString(), Convert.ToInt32(BerthTextBox2.Text), Convert.ToInt32(CoachTextBox2.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    Response.Redirect("ViewTicket.aspx");
                }
                else if (Session["ticketclass"].ToString() == "Tatkal")
                {
                    if (Convert.ToInt32(Session["Tatkal"]) <= 0)
                    {
                        status = "Waitlist";
                    }
                    else
                    {
                        status = "Confirmed";
                    }

                    //upating seat
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateTatkalSeats(Convert.ToInt16(QuantityList.Text), Convert.ToInt16(Session["trainnumber"]));

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    if (NameTextBox1.Text != "" && AgeTextBox1.Text != "" && GenderList1.Text != "" && CoachTextBox1.Text != "" && BerthTextBox1.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox1.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox1.Text), Session["ticketclass"].ToString(), GenderList1.Text.ToString(), Convert.ToInt32(BerthTextBox1.Text), Convert.ToInt32(CoachTextBox1.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    if (NameTextBox2.Text != "" && AgeTextBox2.Text != "" && GenderList2.Text != "" && CoachTextBox2.Text != "" && BerthTextBox2.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox2.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox2.Text), Session["ticketclass"].ToString(), GenderList2.Text.ToString(), Convert.ToInt32(BerthTextBox2.Text), Convert.ToInt32(CoachTextBox2.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    Response.Redirect("ViewTicket.aspx");
                }
                else
                {
                    if (Convert.ToInt32(Session["Ladies"]) <= 0)
                    {
                        status = "Waitlist";
                    }
                    else
                    {
                        status = "Confirmed";
                    }

                    //upating seat
                    TraininfoService traininfoService = new TraininfoService();
                    traininfoService.UpdateLadiesSeats(Convert.ToInt16(QuantityList.Text), Convert.ToInt16(Session["trainnumber"]));

                    //Generating Ticket
                    ticketService.AddTicket(NameTextbox.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox.Text), Session["ticketclass"].ToString(), GenderList.Text.ToString(), Convert.ToInt32(BerthTextBox.Text), Convert.ToInt32(CoachTextBox.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    if (NameTextBox1.Text != "" && AgeTextBox1.Text != "" && GenderList1.Text != "" && CoachTextBox1.Text != "" && BerthTextBox1.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox1.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox1.Text), Session["ticketclass"].ToString(), GenderList1.Text.ToString(), Convert.ToInt32(BerthTextBox1.Text), Convert.ToInt32(CoachTextBox1.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    if (NameTextBox2.Text != "" && AgeTextBox2.Text != "" && GenderList2.Text != "" && CoachTextBox2.Text != "" && BerthTextBox2.Text != "")
                    {
                        ticketService.AddTicket(NameTextBox2.Text.ToString(), Session["trainname"].ToString(), Convert.ToInt32(AgeTextBox2.Text), Session["ticketclass"].ToString(), GenderList2.Text.ToString(), Convert.ToInt32(BerthTextBox2.Text), Convert.ToInt32(CoachTextBox2.Text), Session["arrivaldate"].ToString(), Convert.ToInt32(Session["Userid"]), status);
                    }
                    Response.Redirect("ViewTicket.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to create textboxes to add 2nd passenger details 
        protected void AddPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                NameTextBox1.Visible = true;
                AgeTextBox1.Visible = true;
                GenderList1.Visible = true;
                BerthTextBox1.Visible = true;
                CoachTextBox1.Visible = true;
                AddPassengerLinkButton1.Visible = true;
                CancelLinkButton.Visible = true;
                NameTextBox1.Focus();
                int rate = int.Parse(RateLabel.Text);
                TotalrateLabel.Text = (rate * 2).ToString();
                TotalRs.Text = TotalrateLabel.Text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to create textboxes to add 3rd passenger details
        protected void AddPassengerLinkButton1_Click(object sender, EventArgs e) 
        {
            try
            {
                NameTextBox2.Visible = true;
                AgeTextBox2.Visible = true;
                GenderList2.Visible = true;
                BerthTextBox2.Visible = true;
                CoachTextBox2.Visible = true;
                CancelLinkButton1.Visible = true;
                NameTextBox2.Focus();
                int rate = int.Parse(RateLabel.Text);
                TotalrateLabel.Text = (rate * 3).ToString();
                TotalRs.Text = TotalrateLabel.Text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void CancelLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                NameTextBox1.Visible = false;
                AgeTextBox1.Visible = false;
                GenderList1.Visible = false;
                BerthTextBox1.Visible = false;
                CoachTextBox1.Visible = false;
                CancelLinkButton.Visible = false;
                AddPassengerLinkButton1.Visible = false;
                TotalrateLabel.Text = RateLabel.Text;
                TotalRs.Text = TotalrateLabel.Text;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void CancelLinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TicketrateService ticketrateService = new TicketrateService();
                NameTextBox2.Visible = false;
                AgeTextBox2.Visible = false;
                GenderList2.Visible = false;
                BerthTextBox2.Visible = false;
                CoachTextBox2.Visible = false;
                AddPassengerLinkButton1.Visible = false;
                CancelLinkButton1.Visible = false;
                int rate = ticketrateService.GetTicketRate(Session["ticketclass"].ToString());

                TotalrateLabel.Text = (rate * 2).ToString();
                TotalRs.Text = TotalrateLabel.Text;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}