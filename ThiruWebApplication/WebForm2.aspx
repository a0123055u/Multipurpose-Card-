<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ThiruWebApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 245px;
        }
        .auto-style4 {
            width: 245px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Wallet Application</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Welcome"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="user"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="Service Available for"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="user"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnLoad="Page_Load" Text="Acc1" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" OnLoad="Page_Load" Text="Acc2" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Text="acc1"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="acc2"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
