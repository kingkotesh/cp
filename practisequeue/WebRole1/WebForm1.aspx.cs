using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage.Queue;


namespace WebRole1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount s;
        CloudQueueClient c;
        CloudQueue q;
        protected void Page_Load(object sender, EventArgs e)
        {
            s = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==");
            c=s.CreateCloudQueueClient();
            q = c.GetQueueReference("practisequeue");
            q.CreateIfNotExists();

        }

        protected void send_Click(object sender, EventArgs e)
        {
            CloudQueueMessage m = new CloudQueueMessage(txtname.Text+";"+txtsub.Text+";"+txtbod.Text);
            q.AddMessage(m);
        }
    }
}