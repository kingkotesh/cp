<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="up" runat="server" Text="upload" OnClick="up_Click" />
            <asp:Button ID="down" runat="server" Text="download" OnClick="down_Click" />
        </div>
    </form>
</body>
</html>
