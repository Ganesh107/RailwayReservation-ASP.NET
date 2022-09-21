<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="EditTrains.aspx.cs" Inherits="Railway.UI.EditTrains" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/EditTrains.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <asp:Button ID="LogoutButton" runat="server" Text="Logout" CssClass="btn btn-danger" CausesValidation="false" OnClick="LogoutButton_Click"/>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <center>
                                    <h3>TRAIN DETAILS</h3>
                                </center>
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-12 overflow">
                                <asp:GridView ID="TrainsGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="trainnumber" CssClass="table table-striped" OnRowDeleted="TrainsGridView_RowDeleted" OnRowUpdated="TrainsGridView_RowUpdated">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                        <asp:BoundField DataField="Trainnumber" HeaderText="Trainnumber" SortExpression="Trainnumber" ReadOnly="True" />
                                        <asp:BoundField DataField="Trainname" HeaderText="Trainname" SortExpression="Trainname" />
                                        <asp:BoundField DataField="Startloc" HeaderText="Startloc" SortExpression="Startloc" />
                                        <asp:BoundField DataField="Endloc" HeaderText="Endloc" SortExpression="Endloc" />
                                        <asp:BoundField DataField="Arrivaltime" HeaderText="Arrivaltime" SortExpression="Arrivaltime" />
                                        <asp:BoundField DataField="Departuretime" HeaderText="Departuretime" SortExpression="Departuretime" />
                                        <asp:BoundField DataField="Arrivaldate" HeaderText="Arrivaldate" SortExpression="Arrivaldate" />
                                        <asp:BoundField DataField="Ac2tier" HeaderText="Ac2tier" SortExpression="Ac2tier" />
                                        <asp:BoundField DataField="Sleeper" HeaderText="Sleeper" SortExpression="Sleeper" />
                                        <asp:BoundField DataField="Ac3tier" HeaderText="Ac3tier" SortExpression="Ac3tier" />
                                        <asp:BoundField DataField="Tatkal" HeaderText="Tatkal" SortExpression="Tatkal" />
                                        <asp:BoundField DataField="Ladies" HeaderText="Ladies" SortExpression="Ladies" />
                                    </Columns>
                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteTrains" SelectMethod="GetAlltrains" TypeName="Railway.BusinessLayer.TraininfoService" UpdateMethod="UpdateTraininfo">
                                    <DeleteParameters>
                                        <asp:Parameter Name="trainnumber" Type="Int32" />
                                    </DeleteParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="trainnumber" Type="Int32" />
                                        <asp:Parameter Name="trainname" Type="String" />
                                        <asp:Parameter Name="startloc" Type="String" />
                                        <asp:Parameter Name="endloc" Type="String" />
                                        <asp:Parameter Name="arrivaltime" Type="String" />
                                        <asp:Parameter Name="departuretime" Type="String" />
                                        <asp:Parameter Name="arrivaldate" Type="String" />
                                        <asp:Parameter Name="ac2tier" Type="Int32" />
                                        <asp:Parameter Name="sleeper" Type="Int32" />
                                        <asp:Parameter Name="ac3tier" Type="Int32" />
                                        <asp:Parameter Name="tatkal" Type="Int32" />
                                        <asp:Parameter Name="ladies" Type="Int32" />
                                    </UpdateParameters>
                                </asp:ObjectDataSource>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
