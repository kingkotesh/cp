<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="upload" ID="up" OnClick="up_Click" />
            <asp:Button runat="server" Text="download" ID="down" OnClick="down_Click" />
        </div>
    </form>
</body>
</html>
