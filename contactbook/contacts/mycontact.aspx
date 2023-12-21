<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mycontact.aspx.cs" Inherits="contacts.mycontact" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tbladdrecord" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtname" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Email:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ContactType</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtcnt" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ContactNumber:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtcn" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2"><asp:Button ID="insert" Text="Insert" runat="server" OnClick="insert_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <hr />
      <asp:GridView ID="ContactGrid" runat="server" HorizontalAlign="Center" AutoGenerateColumns="false" OnRowCommand="ContactGrid_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="PartitionKey" HeaderText="ContactType" />
                    <asp:BoundField DataField="RowKey" HeaderText="ContactNumber" />
                    <asp:ButtonField ButtonType="Link" HeaderText="Edit/Delete" Text="Edit/Delete" />
                </Columns>
            </asp:GridView>
            <hr />
            <asp:Table ID="tbleditrecord" runat="server" HorizontalAlign="Center" Visible="false">
                <asp:TableRow>
                    <asp:TableCell>Name:</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtedname" runat="server" ></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Email</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtedemail" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ContactType</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtedcnt" runat="server" Enabled="false"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ContactName</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtedcn" runat="server" Enabled="false"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Button ID="edit" runat="server" Text="Edit" OnClick="edit_Click" /></asp:TableCell>
                    <asp:TableCell><asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
