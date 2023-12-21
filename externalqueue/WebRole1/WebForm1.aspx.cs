using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure;

namespace WebRole1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount account;
        CloudQueueClient queueClient;
        CloudQueue queue;
        protected void Page_Load(object sender, EventArgs e)
        {
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==;EndpointSuffix=core.windows.net");
            queueClient=account.CreateCloudQueueClient();
            queue = queueClient.GetQueueReference("externalqueue");
            queue.CreateIfNotExists();
        }

        protected void send_Click(object sender, EventArgs e)
        {
            CloudQueueMessage m = new CloudQueueMessage(txtmail.Text+","+txtsub.Text+","+txtbody.Text);
            queue.AddMessage(m);
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}