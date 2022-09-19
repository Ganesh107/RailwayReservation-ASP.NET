<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="BookTicket.aspx.cs" Inherits="Railway.UI.BookTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Bookticket.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10">
                <div class="card">
                    <div class="card-body">
                        <div class="row row1">
                           <div class="col-md-11">
                                <asp:Label ID="TrainnameLabel" runat="server" Text="Label" CssClass="font-weight-bold label1"></asp:Label>
                            </div>
                            <div class="col-md-1">
                                <i class="fa-sharp fa-solid fa-location-dot"></i>
                           </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Label ID="DeparturetimeLbel" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label> | <asp:Label ID="StartlocLabel" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                            </div>
                            <div class="col-md-4">
                                -----<asp:Label ID="TimeLabel" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                            </div>
                            <div class="col-md-4">
                                <asp:Label ID="DestinationLabel" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 style1 text-center">
                                <asp:Label ID="DateLabel" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 text-center">
                                <asp:Label ID="ClassLabel" runat="server" Text="Label" CssClass="font-weight-bold" BackColor="#CCCCCC"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-md-3">
                                                Boarding Station | <asp:Label ID="Label1" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                                            </div>
                                            <div class="col-md-3">
                                                Boarding Date | <asp:Label ID="Label2" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                                            </div>
                                            <div class="col-md-3">
                                                Arrival Time | <asp:Label ID="Label3" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                                            </div>
                                            <div class="col-md-3">
                                                Departure Time | <asp:Label ID="Label4" runat="server" Text="Label" CssClass="font-weight-bold"></asp:Label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <label>Ticket Fare</label><asp:Label ID="RateLabel" runat="server" Text="Label" CssClass="font-weight-bold tktfare"></asp:Label>
                            </div>
                        </div>
                        <div class="row color">
                            <div class="col">
                                <label>Total Fare</label><asp:Label ID="TotalrateLabel" runat="server" Text="Label" CssClass="font-weight-bold txtcolor"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <h5 class="font-weight-bold">Passenger Details</h5>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-md-3">
                                <asp:TextBox ID="NameTextbox" runat="server" CssClass="form-control"  placeholder="Name"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="NameFieldValidator" runat="server" ErrorMessage="Please enter name" SetFocusOnError="True" ControlToValidate="NameTextbox" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="AgeTextBox" runat="server" CssClass="form-control" TextMode="Number"  placeholder="Age"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter age" SetFocusOnError="True" ControlToValidate="AgeTextBox" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <asp:DropDownList ID="GenderList" runat="server" CssClass="form-control">
                                    <asp:ListItem Selected="True" Value="" Text="Gender"></asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="GenderValidator" runat="server" ErrorMessage="Please select gender" SetFocusOnError="True" ControlToValidate="GenderList" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-3">
                                <asp:TextBox ID="BerthTextBox" runat="server" CssClass="form-control" TextMode="Number"  placeholder="Berth Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="BerthFieldValidator" runat="server" ErrorMessage="Please enter berth number" SetFocusOnError="True" ControlToValidate="BerthTextBox" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="CoachTextBox" runat="server" CssClass="form-control" TextMode="Number"  placeholder="Coach Number"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="CoachFieldValidator" runat="server" ErrorMessage="Please enter coach number" SetFocusOnError="True" ControlToValidate="CoachTextBox" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                        </div>     
                        <hr />
                        <div class="row">
                            <div class="col-md-2">
                                <asp:TextBox ID="QuantityTextBox" runat="server" CssClass="form-control" TextMode="Number"  placeholder="Quantity" MaxLength="3"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="QuantityValidator" runat="server" ErrorMessage="Please enter Quantity" SetFocusOnError="True" ControlToValidate="QuantityTextBox" Display="Dynamic" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-4">
                                <asp:LinkButton ID="AddButton" runat="server" CssClass="linkbtn" OnClick="ConfirmPayment" CausesValidation="true">Confirm Payment</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
