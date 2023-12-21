using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;

namespace WebRole1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount a;
        CloudFileClient f;
        CloudFileShare s;
        CloudFileDirectory d;
        CloudFile file;
        protected void Page_Load(object sender, EventArgs e)
        {
            a = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==");
            f=a.CreateCloudFileClient();
            s = f.GetShareReference("practisefiles");
            s.CreateIfNotExists();
            d=s.GetRootDirectoryReference();
            file=d.GetFileReference("kotesh.txt");
            
        }

        protected void up_Click(object sender, EventArgs e)
        {
            file.UploadFromFile("C:\\Users\\king\\Documents\\helloworld.txt", System.IO.FileMode.Open);
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void down_Click(object sender, EventArgs e)
        {
            file.DownloadToFile("C:\\Users\\king\\Downloads\\hiiworld.txt", System.IO.FileMode.OpenOrCreate);
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}