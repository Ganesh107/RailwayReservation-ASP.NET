<%@ Page Title="" Language="C#" MasterPageFile="~/Structure.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Railway.UI.Testpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Homepage.css" rel="stylesheet" />
    <%--animate.css--%>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner" data-interval="1000">
    <div class="carousel-item active">
        <div class="carousel-caption">
            <h3 class="animate__animated animate__bounceInDown animate__delay-1s">Welcome</h3>
            <p class="animate__animated animate__fadeInLeftBig animate__delay-1s">To Railway Reservation</p>
        </div>
      <img class="d-block w-100" src="images/img4.jpg" alt="First slide">
    </div>
    <div class="carousel-item">
        <div class="carousel-caption">
            <p class="animate__animated animate__fadeInLeftBig animate__delay-1s">“The train is a small world moving through a larger world”</p>
            <p class="animate__animated animate__fadeInLeftBig animate__delay-1s">-Elisha Cooper, ‘Train’(2013)</p>
        </div>
      <img class="d-block w-100" src="images/img6.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
        <div class="carousel-caption">
            <p class="animate__animated animate__fadeInLeftBig animate__delay-1s">“The train is a small world moving through a larger world”</p>
            <p class="animate__animated animate__fadeInLeftBig animate__delay-1s">-Elisha Cooper, ‘Train’(2013)</p>
        </div>
      <img class="d-block w-100 img-responsive" src="images/img7.jpg" />" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    <br />
    <div class="container-fluid" id="BookTickets">
        <div class="row">
            <div class="col-md-12">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center><h4 class="font-weight-bold">BOOK TICKET</h4></center>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                    <div class="col-md-6">
                                        <label>From</label>
                                            <asp:DropDownList ID="StartlocationList" runat="server" CssClass="form-control">
                                                <asp:ListItem Selected="True" Text="--select--" Value=""></asp:ListItem>
                                                <asp:ListItem>KERALA</asp:ListItem>
                                                <asp:ListItem>BANGLORE</asp:ListItem>
                                                <asp:ListItem>CHENNAI</asp:ListItem>
                                                <asp:ListItem>PUNE</asp:ListItem>
                                                <asp:ListItem>DELHI</asp:ListItem>
                                                <asp:ListItem>MUMBAI</asp:ListItem>
                                                <asp:ListItem>HYDERABAD</asp:ListItem>
                                            </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select a location" Display="Dynamic" ControlToValidate="StartlocationList" ForeColor="Red" CssClass="invalid-feedback" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="col-md-5">
                                        <label>Date</label>
                                         <asp:TextBox ID="DateTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="DateFieldValidator" runat="server" ErrorMessage="Please select a date" ControlToValidate="DateTextBox" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" CssClass="invalid-feedback"></asp:RequiredFieldValidator>
                                    </div>                             
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <label>To</label>
                                    <asp:DropDownList ID="EndlocationList" runat="server" CssClass="form-control">
                                                <asp:ListItem Selected="True" Text="--select--" Value=""></asp:ListItem>
                                                <asp:ListItem>CHENNAI</asp:ListItem>
                                                <asp:ListItem>BANGLORE</asp:ListItem>
                                                <asp:ListItem>KERALA</asp:ListItem>
                                                <asp:ListItem>PUNE</asp:ListItem>
                                                <asp:ListItem>DELHI</asp:ListItem>
                                                <asp:ListItem>MUMBAI</asp:ListItem>
                                                <asp:ListItem>HYDERABAD</asp:ListItem>
                                     </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select a location" ControlToValidate="EndlocationList" CssClass="invalid-feedback" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </div>
                                <br />
                                <div class="col-md-2">
                                    <label></label>                            
                                    <asp:Button ID="SearchButton" runat="server" Text="Search" CssClass="btn btn-primary searchbtn" CausesValidation="true" OnClick="SearchButton_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="container-fluid" id="holidays">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <center>
                            <h2 class="font-weight-bold">HOLIDAYS</h2>
                        </center>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4 d-flex">
                        <div class="card">
                            <div class="card-body flex-fill">
                                <div class="row">
                                    <div class="col">
                                        <img src="images/exterior.jpg" class="img"/>
                                     </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <h4 class="font-weight-bold">Maharajas' Express</h4>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <p class="para text-justify">Redefining Royalty, Luxury and Comfort, Maharajas' express takes you on a sojourn to the era of bygone stately splendour of princely states. Sylvan furnishings, elegant ambience and modern amenities are amalgamated for an “Experience Unsurpassed”. It has been a winner of “World’s Leading Luxury train” by World Travel Awards consecutively for last six years.</p>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <a href="https://www.the-maharajas.com/">Read More>></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 d-flex">
                        <div class="card">
                            <div class="card-body flex-fill">
                                <div class="row">
                                    <div class="col">
                                        <img src="images/Manali.jpg" class="img"/>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <h4 class="font-weight-bold">Rail Tour Packages</h4>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <p class="para text-justify">IRCTC offers Exclusive Rail tour packages with confirmed train tickets, sight-seeing and meals for enchanting Nilgiri Mountains, Darjeeling, Kullu Manali, Kashmir, Gangtok or divine tours of Mata Vaishno Devi, Rameswaram, Madurai, Shirdi, Tirupati etc. Holiday packages/ Land packages to these destinations are also available.</p>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <a href="https://www.irctctourism.com/">Read More>></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 d-flex">
                        <div class="card">
                            <div class="card-body flex-fill">
                                <div class="row">
                                    <div class="col">
                                        <img src="images/Buddha_Banner.jpg" class="img"/>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <h4 class="font-weight-bold">Buddhist Circuit Tourist Train</h4>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <p class="para text-justify">India, the country where Buddhism originated has rich memories of the Buddhist legacy. As part of its drive towards austerity, the only kind of art & architecture that it supported were Stupas, Chaityas & Viharas. Buddhist Train India will help you visit all these places up close for a truly religious experience.</p>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="col">
                                        <a href="https://www.irctcbuddhisttrain.com/#/index">Read More>></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>   
            </div>
        </div>
    </div>
    <br />
    <div class="container-fluid" id="specialities">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12">
                        <center>
                            <h2 class="font-weight-bold">SPECIALITIES</h2>
                        </center>
                    </div>
                </div>
                <br>
                <div class="row">
                     <div class="col-md-4 d-flex row2">
                            <div class="card img-fluid">
                                <div class="card-body flex-fill card-style">
                                    <img src="images/AC-First.png" class="img1"/>
                                </div>
                                <hr />
                                <div class="col">
                                    <center>
                                        <h4 class="font-weight-bold">AC-2 Tier</h4>
                                    </center>
                                </div>
                            </div>
                        </div>
                         <div class="col-md-4 d-flex">
                            <div class="card img-fluid">
                                <div class="card-body flex-fill card-style">
                                    <img src="images/AC-second.png" class="img1"/>
                                </div>
                                <hr />
                                <div class="col">
                                    <center>
                                        <h4 class="font-weight-bold">AC-3 Tier</h4>
                                    </center>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 d-flex">
                            <div class="card img-fluid">
                                <div class="card-body flex-fill card-style">
                                    <img src="images/AC-second.png" class="img1"/>
                                </div>
                                <hr />
                                <div class="col">
                                    <center>
                                        <h4 class="font-weight-bold">Sleeper</h4>
                                    </center>
                                </div>
                            </div>
                        </div>
                  </div>
             </div>
        </div>
    </div>
</asp:Content>
