<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sporsmaal.aspx.cs" Inherits="obligatorisk3.sporsmaal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        form {
            margin-bottom: 200px;
            margin-left: 200px;
            margin-right: 200px;
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

        .nesteBtn {
            float: initial;
            font-weight: bold;
        }

        .radiobutton {
            font-weight: bold;
        }

        .btnLoggut {
            float: right;
            margin-top: -30px;
            margin-right: -50px;
            font-weight: bold;
        }

        .auto-style1 {
            margin-top: -35px;
        }

        .lblSporsmaal {
            font-size: 28px;
        }

        .bilde {
            float: right;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Button class="btnLoggut" ID="btnLoggut" runat="server" Text="Logg ut" OnClick="btnLoggut_Click" Width="161px" Height="35px" />
        </div>

        <h2>Berntzen&#39;s teoriportal &nbsp;</h2>
        <p>
            <asp:Label ID="lblAnswerd" runat="server"></asp:Label>
            / 20 spørsmål
        </p>
        <p>
            <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
            &nbsp;<asp:Label class="lblSporsmaal" ID="lblsporsmaal" runat="server"></asp:Label>
            <asp:Image Class="bilde" ID="Image1" runat="server" Height="288px" Width="281px" />
        </p>
        <p>
            <asp:RadioButton class="radiobutton" ID="RadioButton1" runat="server" GroupName="ans" Checked="False" OnClick="clicked(this.id)" OnCheckedChanged="RadioButton1_CheckedChanged" />
            <asp:Literal ID="radio1" runat="server"></asp:Literal>
        </p>
        <p>
            <asp:RadioButton class="radiobutton" ID="RadioButton2" runat="server" GroupName="ans" Checked="False" OnClick="clicked(this.id)" OnCheckedChanged="RadioButton2_CheckedChanged" />
            <asp:Literal ID="radio2" runat="server"></asp:Literal>
        </p>
        <p>
            <asp:RadioButton class="radiobutton" ID="RadioButton3" runat="server" GroupName="ans" Checked="False" OnClick="clicked(this.id)" OnCheckedChanged="RadioButton3_CheckedChanged" />
            <asp:Literal ID="radio3" runat="server"></asp:Literal>
        </p>
        <p>
            <asp:RadioButton class="radiobutton" ID="RadioButton4" runat="server" GroupName="ans" Checked="False" OnClick="clicked(this.id)" OnCheckedChanged="RadioButton4_CheckedChanged" />
            <asp:Literal ID="radio4" runat="server"></asp:Literal>
        </p>
        <p>
            &nbsp;
        </p>

        <p aria-selected="true">
            &nbsp;
            <asp:Label ID="infoLbl" runat="server"></asp:Label>
        </p>
        <p aria-selected="true">
            <asp:Button ID="btnSvar" runat="server" Height="38px" Text="Svar" Width="393px" OnClick="btnSvar_Click" />
        </p>
        <p>
            <asp:Button class="nesteBtn" ID="nesteBtn" runat="server" Text="Neste spørsmål " OnClick="nesteBtn_Click" Width="398px" Height="45px" />
        </p>

    </form>
</body>
</html>
