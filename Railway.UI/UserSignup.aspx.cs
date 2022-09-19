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
    public partial class UserSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //Function to add new users
        protected void SignupButton_Click(object sender, EventArgs e)
        {
            try
            {
                PassengersService passengersService = new PassengersService();
                Passengers passenger = new Passengers();
                passenger.Pname = NameTextbox.Text.Trim();
                passenger.Dob = DateTextbox.Text.Trim();
                passenger.Address = AddressBox.Text.Trim();
                passenger.Phonenumber = PhnoTextbox.Text.Trim();
                passenger.Passwords = PasswordBox.Text.Trim();

                //checking whether user is already registered
                if (passengersService.CheckPhonenumberExists(passenger.Phonenumber))
                {
                    int user_id = passengersService.GetPassengerId(passenger.Phonenumber);
                    UseridLabel.Text = "Already Registered! Your User-Id is " + user_id + " Use it for Login ";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Already registered!','','warning')", true);
                    NameTextbox.Text = "";
                    DateTextbox.Text = "";
                    AddressBox.Text = "";
                    PhnoTextbox.Text = "";
                    PasswordBox.Text = "";
                    NameTextbox.Focus();
                }
                else
                {
                    //calling bussiness layer method (user added successfully)
                    int rows_returned = passengersService.AddPassengers(passenger);
                    if (rows_returned == 1)
                    {
                        //retrieving userid of the newly registered user
                        int userid = passengersService.GetPassengerId(passenger.Phonenumber);
                        UseridLabel.Text = "Your User-Id is " + userid + " Use it for Login ";
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Great Work!','Registration Successfull','success')", true);
                        NameTextbox.Text = "";
                        DateTextbox.Text = "";
                        AddressBox.Text = "";
                        PhnoTextbox.Text = "";
                        PasswordBox.Text = "";
                        NameTextbox.Focus();
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "k", "swal('Error','Account creation failed!','error')", true);
                        NameTextbox.Text = "";
                        DateTextbox.Text = "";
                        AddressBox.Text = "";
                        PhnoTextbox.Text = "";
                        PasswordBox.Text = "";
                        NameTextbox.Focus();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to reset signup form
        protected void ResetButton_Click(object sender, EventArgs e)
        {
            NameTextbox.Text = "";
            DateTextbox.Text = "";
            AddressBox.Text = "";
            PhnoTextbox.Text = "";
            PasswordBox.Text = "";
            NameTextbox.Focus();
        }
    }
}