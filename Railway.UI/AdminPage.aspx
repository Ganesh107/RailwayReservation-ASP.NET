<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Railway.UI.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/AdminPage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <div class="container">
        <div class="row">
           <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <center>
                                    <img src="images/train.png" width="120"/>
                                    <h3> Add new train</h3>
                                    <hr />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Train ID</label>
                                <asp:TextBox ID="TrainnumTextbox" runat="server" CssClass="form-control" TextMode="Number" placeholder="Train ID"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="TrainidValidator" runat="server" ErrorMessage="Please enter Train ID" SetFocusOnError="True" ControlToValidate="TrainnumTextbox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-6">
                                <label class="adminpglabel">Train Name</label>
                                <asp:TextBox ID="TrainnameTextbox" runat="server" CssClass="form-control" placeholder="Train Name"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="TrainNameValidator" runat="server" ErrorMessage="Please enter Train name" SetFocusOnError="True" ControlToValidate="TrainnameTextbox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Starting Location</label>
                                <asp:TextBox ID="StartlocTextBox" runat="server" CssClass="form-control" placeholder="Starting Location"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="StartlocValidator" runat="server" ErrorMessage="Please enter starting location" SetFocusOnError="True" ControlToValidate="StartlocTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-6">
                                <label class="adminpglabel">Ending Location</label>
                                <asp:TextBox ID="EndlocTextBox" runat="server" CssClass="form-control" placeholder="Ending Location"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EndlocValidator" runat="server" ErrorMessage="Please enter ending location" SetFocusOnError="True" ControlToValidate="EndlocTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Ac-3 tier seats</label>
                                <asp:TextBox ID="SeatsTextBox" runat="server" CssClass="form-control" TextMode="Number" placeholder="AC-3tier class seats"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="SeatsValidator" runat="server" ErrorMessage="Please enter number of seats" SetFocusOnError="True" ControlToValidate="SeatsTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-6">
                                <label class="adminpglabel" >Arrival Time</label>
                                <asp:TextBox ID="ArrivaltimeTextBox" runat="server" CssClass="form-control" TextMode="Time" placeholder="Arrival Time"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ArrivaltimeValidator" runat="server" ErrorMessage="Please enter arrival time" SetFocusOnError="True" ControlToValidate="ArrivaltimeTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Departure Time</label>
                                <asp:TextBox ID="DeparturetimeTextBox" runat="server" CssClass="form-control" TextMode="Time" placeholder="Departure Time"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="DeparturetimeValidator" runat="server" ErrorMessage="Please enter departure time" SetFocusOnError="True" ControlToValidate="DeparturetimeTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-6">
                                <label class="adminpglabel">Arrival Date</label>
                                <asp:TextBox ID="ArrivaldateTextBox" runat="server" CssClass="form-control" TextMode="Date" placeholder="Arrival Date"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ArrivaldateValidator" runat="server" ErrorMessage="Please enter arrival date" SetFocusOnError="True" ControlToValidate="ArrivaldateTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Sleeper seats</label>
                                 <asp:TextBox ID="SleeperTextBox" runat="server" CssClass="form-control" TextMode="Number" placeholder="Sleeper class seats"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="SleeperValidator" runat="server" ErrorMessage="Please enter number of seats" SetFocusOnError="True" ControlToValidate="SleeperTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                             <div class="col-md-6">
                                <label class="adminpglabel">AC-2 tier seats</label>
                                 <asp:TextBox ID="Ac2tierTextBox" runat="server" CssClass="form-control" TextMode="Number" placeholder="AC-2tier class seats"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="Ac2tierValidator" runat="server" ErrorMessage="Please enter number of seats" SetFocusOnError="True" ControlToValidate="Ac2tierTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label class="adminpglabel">Tatkal seats</label>
                                 <asp:TextBox ID="TatkalTextBox" runat="server" CssClass="form-control" TextMode="Number" placeholder="Tatkal class seats"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="TatkalValidator" runat="server" ErrorMessage="Please enter number of seats" SetFocusOnError="True" ControlToValidate="TatkalTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                             <div class="col-md-6">
                                <label class="adminpglabel">Ladies seats</label>
                                 <asp:TextBox ID="LadiesTextBox" runat="server" CssClass="form-control" TextMode="Number" placeholder="Ladies class seats"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="LadiesclassValidator" runat="server" ErrorMessage="Please enter number of seats" SetFocusOnError="True" ControlToValidate="LadiesTextBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                           <br />
                        <div class="row">
                            <div class="form-group col-12">
                                <asp:Button ID="AddTrainButton" runat="server" Text="Add Train" CssClass="btn btn-primary btn-block" OnClick="AddTrainButton_Click"/>
                            </div>
                        </div>
                
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
