<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="UserSignup.aspx.cs" Inherits="Railway.UI.UserSignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Signup.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-7">
                <h1 class="text-left">User Registration Form</h1>
                <p class="text-left">Do not have an account?<br />
                    Just enter the details and press signup,
                    All done!
                </p>
            </div>
            <div class="col-md-5">
                <div class="row">
                    <div class="col-md-6">
                        <h3 class="text-left">Registration Form</h3>
                    </div>
                    <div class="col-md-6">
                        <span><i class="fa-solid fa-user-plus mx-auto d-none d-md-block"></i></span>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <label class="label col-md-4 control-label">Full Name</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="NameTextbox" runat="server" CssClass="form-control transparent-input" placeholder="Full Name"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="NamefieldValidator" runat="server" ErrorMessage="Please enter your full name" ControlToValidate="NameTextbox" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Date of Birth</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="DateTextbox" runat="server" TextMode="Date" CssClass="form-control transparent-input"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select your Date of Birth" ControlToValidate="DateTextbox" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Phone Number</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="PhnoTextbox" runat="server" CssClass="form-control transparent-input" placeholder="Phone Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PhnoreqValidator" runat="server" ErrorMessage="Please enter your phone number" ControlToValidate="PhnoTextbox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback" SetFocusOnError="True" ></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="PhnoValidator" runat="server" ErrorMessage="Invalid Number" ControlToValidate="PhnoTextbox" ForeColor="Red" ValidationExpression="^([0]|\+91)?[6789]\d{9}$" CssClass="invalid-feedback" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Address</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="AddressBox" runat="server" TextMode="MultiLine" CssClass="form-control transparent-input" placeholder="Address"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" Text="Please enter your address" ControlToValidate="AddressBox" Display="Dynamic" CssClass="invalid-feedback" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Gender</label>
                    <div class="col-md-8 form-control">
                        <asp:RadioButton ID="MaleButton" runat="server" CausesValidation="True" ForeColor="White" GroupName="Gender" Text="Male"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="FemaleButton" runat="server" ForeColor="White" GroupName="Gender" Text="Female"/>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Password</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="PasswordBox" runat="server" CssClass="form-control transparent-input" TextMode="Password" placeholder="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ErrorMessage="Enter a password" ControlToValidate="PasswordBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <label class="label col-md-4 control-label">Confirm Password</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="ConfirmBox" runat="server" CssClass="form-control transparent-input" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="ConfirmValidator" runat="server" ErrorMessage="Enter your password again" ControlToValidate="ConfirmBox" Display="Dynamic" ForeColor="Red" CssClass="invalid-feedback" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="PasswordValidator" runat="server" ErrorMessage="Passwords do not match enter again" ControlToCompare="PasswordBox" ControlToValidate="ConfirmBox" ForeColor="Red" CssClass="invalid-feedback" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>
                    </div>    
                </div>
                <div class="row">
                    <div class="col-md-4"></div>
                    <div class="col-md-8">
                        <asp:Button ID="SignupButton" runat="server" Text="Sign Up" CssClass="btn btn-success" OnClick="SignupButton_Click"/>
                        <asp:Button ID="ResetButton" runat="server" Text="Reset" CssClass="btn btn-danger" CausesValidation="False" OnClick="ResetButton_Click"/>
                    </div>
                </div>
                <asp:Label ID="UseridLabel" runat="server" CssClass="success" ForeColor="#66FF33"></asp:Label>
                <a href="UserLogin.aspx"> Login Here</a>
            </div>
        </div> 
    </div>
</asp:Content>
