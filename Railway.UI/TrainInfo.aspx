<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="TrainInfo.aspx.cs" Inherits="Railway.UI.TrainInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/TrainInfo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="card cardstyle">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-3">
                                <asp:DropDownList ID="StartlocList" runat="server" CssClass="form-control">
                                    <asp:ListItem>--select--</asp:ListItem>
                                    <asp:ListItem>KERALA</asp:ListItem>
                                    <asp:ListItem>BANGLORE</asp:ListItem>
                                    <asp:ListItem>CHENNAI</asp:ListItem>
                                    <asp:ListItem>PUNE</asp:ListItem>
                                    <asp:ListItem>DELHI</asp:ListItem>
                                    <asp:ListItem>MUMBAI</asp:ListItem>
                                    <asp:ListItem>HYDERABAD</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-3">
                                <asp:DropDownList ID="EndlocList" runat="server" CssClass="form-control">
                                    <asp:ListItem>--select--</asp:ListItem>
                                    <asp:ListItem>KERALA</asp:ListItem>
                                    <asp:ListItem>BANGLORE</asp:ListItem>
                                    <asp:ListItem>CHENNAI</asp:ListItem>
                                    <asp:ListItem>PUNE</asp:ListItem>
                                    <asp:ListItem>DELHI</asp:ListItem>
                                    <asp:ListItem>MUMBAI</asp:ListItem>
                                    <asp:ListItem>HYDERABAD</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="DateTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="col-md-2">
                                <asp:DropDownList ID="ClassDownList" runat="server" CssClass="form-control">
                                <asp:ListItem>AC-2 Tier</asp:ListItem>
                                    <asp:ListItem>AC-3 Tier</asp:ListItem>
                                    <asp:ListItem>Sleeper</asp:ListItem>
                                    <asp:ListItem>Tatkal</asp:ListItem>
                                    <asp:ListItem>Ladies</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2">
                                <asp:Button ID="Searchbtn" runat="server" Text="Modify Search" CssClass="btn btn-warning" OnClick="Searchbtn_Click"/>
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
            <div class="col-md-12">
                <div class="card cardstyle1">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <center>
                                    <h4 class="font-weight-bold">AVAILABLE TRAINS</h4>
                                </center>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-md-12 overflow-auto">
                                <center>
                                <asp:GridView ID="GridView1" runat="server"  CssClass="table table-striped" DataKeyNames="trainnumber" >
                                    <Columns>
                                        <asp:TemplateField ShowHeader="False">
                                            <ItemTemplate>
                                                <asp:Button ID="BooknowButton" runat="server" CausesValidation="false" CommandName="select" Text="Book Now" OnClick="GetTrainDetails"/>
                                            </ItemTemplate>
                                            <ControlStyle CssClass="btn btn-primary" />
                                        </asp:TemplateField>
                                    </Columns>   
                                </asp:GridView>
                                </center>
                            </div>                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
