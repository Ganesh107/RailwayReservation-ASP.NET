<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="ViewTicket.aspx.cs" Inherits="Railway.UI.ViewTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center><h4 class="font-weight-bold">TICKET DETAILS</h4></center>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col">
                                <asp:GridView ID="TicketGridView" runat="server" CssClass="table table-striped"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
