using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;
using Railway.Entities;

namespace Railway.UI
{
    public partial class ViewTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();

            //returns booked ticket details
            DataTable ticket =  ticketService.ViewTicket(Convert.ToInt32(Session["Userid"]));
            TicketGridView.DataSource = ticket;
            TicketGridView.DataBind();
        }
    }
}