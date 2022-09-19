﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railway.BusinessLayer;
using Railway.Entities;
using System.Data;

namespace Railway.UI
{
    public partial class EditTrains : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            try
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Record Updated!','','success')", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            try
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Record Deleted!','','success')", true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}