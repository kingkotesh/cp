using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure;

namespace WebRole1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount account;
        CloudBlobClient blobClient;
        CloudBlobContainer container;
        CloudBlockBlob blob;
        protected void Page_Load(object sender, EventArgs e)
        {
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==");
            blobClient=account.CreateCloudBlobClient();
            container = blobClient.GetContainerReference("container");
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });
            li.DataSource = container.ListBlobs();
            li.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            blob = container.GetBlockBlobReference(file.FileName);
            blob.UploadFromStream(file.FileContent);
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}