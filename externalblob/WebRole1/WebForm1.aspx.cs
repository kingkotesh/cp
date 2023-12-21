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
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==;EndpointSuffix=core.windows.net");
            blobClient=account.CreateCloudBlobClient();
            container = blobClient.GetContainerReference("externalbolb");
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });
            list.DataSource = container.ListBlobs();
            list.DataBind();
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            blob = container.GetBlockBlobReference(img.FileName);
            blob.UploadFromStream (img.FileContent);
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}