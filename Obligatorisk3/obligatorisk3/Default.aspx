<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="obligatorisk3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <style type="text/css">
     .login{
         font-size: 30px;
         font-weight: bold;
     }
     .jumbotron{
         font-size:40px;
         font-weight: bold;
     }
     .auto-style2 {
         position: relative;
         min-height: 1px;
         float: left;
         width: 437px;
         left: 98px;
         top: 2px;
         height: 326px;
         padding-left: 15px;
         padding-right: 15px;
     }
     </style>

    <div class="jumbotron">
        Berntzen&#39;s Teoriportal
    </div>

    <div class="auto-style2" style="margin-right: 936px; ">
        <p class="login">Logg inn</p>
        <p>
            Brukernavn:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtUsername" runat="server" Width="187px"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Logg inn" />
            &nbsp;
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
        <asp:Label ID="lblFeilmelding" runat="server"></asp:Label>
    </div>

</asp:Content>
