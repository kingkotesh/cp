using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Azure;

namespace WebRole1
{
    public partial class MyGallery : System.Web.UI.Page
    {
        CloudStorageAccount sa;
        CloudBlobClient client;
        CloudBlobContainer container;
        CloudBlockBlob blob;
        protected void Page_Load(object sender, EventArgs e)
        {
            sa = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("BlobCS"));
            client=sa.CreateCloudBlobClient();
            container = client.GetContainerReference("mygallery");
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess=BlobContainerPublicAccessType.Blob
            });
            imggrid.DataSource = container.ListBlobs();
            imggrid.DataBind();

        }
        protected void btn_Click(object sender, EventArgs e)
        {
            blob = container.GetBlockBlobReference(img.FileName);
            blob.UploadFromStream(img.FileContent);
            Response.Redirect("~/MyGallery.aspx");
        }
    }
}