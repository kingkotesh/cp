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
        CloudStorageAccount sa;
        CloudFileClient c;
        CloudFileDirectory d;
        CloudFileShare s;
        CloudFile f;
        protected void Page_Load(object sender, EventArgs e)
        {
            sa = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=beccsecs2;AccountKey=koLTTb33IZ1R9ZlZci8q5QMagjE0fzAjcFi5LWhfBOgGm2d3GhcM75DYCLQ8rjP77nwQ/W90eoPP+AStEeUBig==");
            c=sa.CreateCloudFileClient();
            s = c.GetShareReference("urfiles");
            s.CreateIfNotExists();
            d=s.GetRootDirectoryReference();
            f = d.GetFileReference("rr.pdf");
        }
        protected void up_Click(object sender, EventArgs e)
        {
            f.UploadFromFile("C:\\Users\\king\\Downloads\\VUTUKURI_KOTESH NAG_Resume updated.pdf", System.IO.FileMode.Open);
            Response.Redirect("~/WebForm1.aspx");
        }
        protected void down_Click(object sender, EventArgs e)
        {
            f.DownloadToFile("C:\\Users\\king\\desktop\\VUTUKURI_KOTESH NAG_Resume updated.pdf", System.IO.FileMode.OpenOrCreate);
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}