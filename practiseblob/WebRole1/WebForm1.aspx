<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload runat="server" ID="file" />
            <asp:Button runat="server" ID="submit" Text="submit" OnClick="submit_Click" />
        </div>
        <hr />
        <asp:ListView ID="li" runat="server">
            <ItemTemplate>
                <asp:Image ImageUrl="<%#((Microsoft.WindowsAzure.Storage.Blob.IListBlobItem)(Container.DataItem)).Uri %>" runat="server" Height="200px" Width="200px" />
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
