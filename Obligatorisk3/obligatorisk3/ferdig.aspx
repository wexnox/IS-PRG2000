<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ferdig.aspx.cs" Inherits="obligatorisk3.ferdig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        form {
            margin-bottom: 150px;
            margin-left: 150px;
            margin-right: 150px;
            margin-top: 50px;
            padding-left: 50px;
            padding-right: 50px;
            padding-bottom: 50px;
            padding-top: 25px;
            border-style: solid;
            border-width: 3px;
            background-color: mintcream;
        }

        h2 {
            font-size: 42px;
            padding-top: 20px;
            padding-bottom: 20px;
        }
        .btnLoggut {
            float: right;
            margin-top: -30px;
            margin-right: -50px;
            font-weight: bold;
        }

        .btnStart {
            float: initial;
            font-weight: bold;
        }
       GridView
       {
           position: relative;
       }
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="auto-style1">
            <asp:Button class="btnLoggut" ID="btnLoggut" runat="server" Text="Logg ut" OnClick="btnLoggut_Click" Width="161px" Height="35px" />
        </div>
        <h2>Berntzen&#39;s teoriportal </h2>
        <asp:Image ID="Image1" runat="server" ImageUrl="" Height="200px" Width="351px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        Du svarte feil på følgende spørsmål:
        <br />
        <br />
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" Height="211px" Width="1116px">
            <Columns>
                <asp:BoundField DataField="Text" HeaderText="Spørsmål" />
                <asp:BoundField DataField="Value" HeaderText="Fasit" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button CssClass="btnStart" ID="startBtn" runat="server" Height="47px" OnClick="startBtn_Click" Text="Ta testen på nytt" Width="1121px" />

    </form>
</body>
</html>
