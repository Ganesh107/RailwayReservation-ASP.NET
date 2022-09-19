<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Railway.UI.AdminLogin" %>
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
                                    <img src="images/Admin.jpg" width="450" class="mx-auto d-none d-md-block img-fluid"/>
                                    <p> Login to continue.... </p>
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
                                    <img src="images/adminavatar.png" width="100"/>
                                    <h3>Admin Login</h3>
                                    <hr />
                                </center>
                             </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label class="loginlabel">User ID</label>          
                                <div class="form-group">
                                    <asp:TextBox ID="AdminidTextbox" runat="server" CssClass="form-control" placeholder="Admin ID" TextMode="Number"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="AdminValidator" runat="server" ControlToValidate="AdminidTextbox" ErrorMessage="Please fill out this field" BorderStyle="None" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                                </div>

                                <label class="loginlabel">Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="AdminPasswordTextbox" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="AdminPasswordValidator" runat="server" ErrorMessage="Please fill out this field" ControlToValidate="AdminPasswordTextbox" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                                </div>

                                <div class="form-group">
                                    <asp:Button ID="AdminLoginButton" runat="server" Text="Login" class="btn btn-success btn-block" OnClick="ValidateLogin"/>
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
