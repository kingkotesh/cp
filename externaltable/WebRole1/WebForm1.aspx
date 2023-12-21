<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole1.WebForm1" %>
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
                    <asp:TableCell>Movie Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="mtext"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Director Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="dtext"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Hero Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="htext"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Rating:</asp:TableCell>
                    <asp:TableCell><asp:TextBox runat="server" ID="rate"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Button ID="insert" runat="server" Text="Add" OnClick="insert_Click"/></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <hr />
<asp:GridView runat="server" ID="grid" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="MovieName" />
        <asp:BoundField DataField="Director" HeaderText="DirectorName" />
        <asp:BoundField DataField="RowKey" HeaderText="HeroName" />
        <asp:BoundField DataField="PartitionKey" HeaderText="Rating" />

    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
