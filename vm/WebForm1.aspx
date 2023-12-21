<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="vm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>Id:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="txtid"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="txtname"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Dept:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="txtdept"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><asp:Button runat="server" ID="btn" Text="Insert" OnClick="btn_Click"  /></asp:TableCell>
                </asp:TableRow>


            </asp:Table>
        </div>
    </form>
</body>
</html>
