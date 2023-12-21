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
                    <asp:TableCell>MovieName:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtmovie" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>DirectorName:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtdirector" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>HeroName:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txthero" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Rating:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="rating" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><asp:Button ID="add" runat="server" Text="add" OnClick="add_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <hr />
            <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Movie Name" />
                    <asp:BoundField DataField="Director" HeaderText="Director Name" />
                    <asp:BoundField DataField="PartitionKey" HeaderText="Hero Name" />
                    <asp:BoundField DataField="RowKey" HeaderText="Rating" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
