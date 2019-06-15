<%@ Page Title="Bestilling" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bestilling.aspx.cs" Inherits="HotellWeb.Bestilling" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
        <h1>Kanseller bestilling din her </h1>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblKundenavn" runat="server" Text="Kundenavn"></asp:Label>
                            <asp:TextBox ID="txtkundenavn" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRefkey" runat="server" Text="RefKey:"></asp:Label>
                            <asp:TextBox ID="txtRefkey" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnSlettBestilling" runat="server" OnClick="btnSlettBestilling_Click" Text="Slett Bestilling" />
                            <br />
                            <asp:Label ID="lblMessage" runat="server"></asp:Label>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
