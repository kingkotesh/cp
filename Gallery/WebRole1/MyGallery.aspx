<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyGallery.aspx.cs" Inherits="WebRole1.MyGallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            choose a file:<asp:FileUpload ID="img" runat="server" />
            <asp:Button ID="btn" runat="server" Text="Upload" OnClick="btn_Click" />
            <hr />
            <asp:ListView ID="imggrid" runat="server">
                <ItemTemplate>
                    <asp:Image ImageUrl="<%#((Microsoft.WindowsAzure.Storage.Blob.IListBlobItem)(Container.DataItem)).Uri %>" 
                        Height="200px" Width="200px" runat="server" />
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
