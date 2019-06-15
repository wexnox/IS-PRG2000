<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HotellWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Reserver rom</h1>
        <p class="lead">her kan du reservere rom.</p>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <form id="Form" runat="server">
                    <div class="form-group">
                        <label>Kundenavn:</label>
                        <asp:TextBox ID="txtKundenavn" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Startdato:</label>
                        <asp:TextBox ID="txtStartdato" type="date" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <%-- TODO: Her kunne en kanskje brukt foreach for og spytte ut 1-max dager --%>
                    <div class="form-group">
                        <label for="">Utsjekking:</label>
                        <asp:TextBox ID="txtUtsjekking" type="date" runat="server" class="form-control"></asp:TextBox>
                        
                    </div>
                    <div class="form-group">
                        <label>Refkey:</label>
                        <asp:TextBox runat="server" ID="txtrefkey" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="submit" class="form-control" runat="server" Text="Submit" OnClick="submit_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
