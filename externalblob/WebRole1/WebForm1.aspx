<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload runat="server" ID="img" />
            <asp:Button ID="upload" Text="upload" runat="server" OnClick="upload_Click" />
        </div>
    </form>
    <hr />
    <asp:ListView runat="server" ID="list">
        <ItemTemplate>
            <asp:Image ImageUrl="<%#((Microsoft.WindowsAzure.Storage.Blob.IListBlobItem)(Container.DataItem)).Uri %>" runat="server" Height="200px" Width="200px" />
        </ItemTemplate>
    </asp:ListView>
</body>
</html>
