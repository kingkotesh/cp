using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using Microsoft.WindowsAzure;

namespace WebRole1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount account;
        CloudFileClient fileClient;
        CloudFileDirectory directory;
        CloudFileShare share;
        CloudFile file;
        protected void Page_Load(object sender, EventArgs e)
        {
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==;EndpointSuffix=core.windows.net");
            fileClient=account.CreateCloudFileClient();
            share = fileClient.GetShareReference("externalfiles");
            share.CreateIfNotExists();
            directory = share.GetRootDirectoryReference();
            file = directory.GetFileReference("king.pdf");
        }

        protected void up_Click(object sender, EventArgs e)
        {
            file.UploadFromFile("C:\\Users\\king\\Desktop\\taruncs.pdf",System.IO.FileMode.Open);
            Response.Redirect("WebForm1.aspx");
        }

        protected void down_Click(object sender, EventArgs e)
        {
            file.DownloadToFile("C:\\Users\\king\\Desktop\\external\\taruncs.pdf", System.IO.FileMode.OpenOrCreate);
            Response.Redirect("WebForm1.aspx");
        }
    }
}