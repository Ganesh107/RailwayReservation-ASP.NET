<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Railway.UI.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/login.css" rel="stylesheet" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <div class="row">
        <div class="col"><p></p></div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="images/loginimg.png"  class="mx-auto d-none d-md-block img-fluid main-img"/>
                                    <p> Login to Book tickets </p>
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="images/user.png" width="100"/>
                                    <h3>Passenger Login</h3>
                                    <hr />
                                </center>
                             </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label class="loginlabel">User ID</label>          
                                <div class="form-group">
                                    <asp:TextBox ID="UseridTextbox" runat="server" CssClass="form-control" placeholder="User ID" TextMode="Number"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UseridValidator" runat="server" ControlToValidate="UseridTextbox" ErrorMessage="Please fill out this field" BorderStyle="None" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                                </div>

                                <label class="loginlabel">Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="PasswordTextbox" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ErrorMessage="Please fill out this field" ControlToValidate="PasswordTextbox" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                                </div>

                                <div class="form-group">
                                    <asp:Button ID="LoginButton" runat="server" Text="Login" class="btn btn-success btn-block" OnClick="LoginButton_Click"/>
                                </div>

                                <div class="form-group">
                                    <asp:Button ID="SignupButton" runat="server" Text="Sign Up" CssClass="btn btn-primary btn-block" OnClick="SignupButton_Click" CausesValidation="False"/>
                                </div>                            
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col"><p></p></div>
    </div>
</asp:Content>


                                