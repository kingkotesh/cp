using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure;

namespace WebRole1
{
    public class MyEntity : TableEntity
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public MyEntity() { }
        public MyEntity(string name, string director, string hero, string rating)
        {
            Name = name;
            Director = director;
            PartitionKey = hero;
            RowKey = rating;
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount account;
        CloudTableClient tableClient;
        CloudTable table;
        protected void Page_Load(object sender, EventArgs e)
        {
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==");
            tableClient=account.CreateCloudTableClient();
            table = tableClient.GetTableReference("practisetable");
            table.CreateIfNotExists();
            TableQuery<MyEntity> query=new TableQuery<MyEntity>();
            grid.DataSource= table.ExecuteQuery<MyEntity>(query);
            grid.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string mname = txtmovie.Text;
            string dname=txtdirector.Text;
            string hname=txthero.Text;
            string rate=rating.Text;
            MyEntity entity=new MyEntity(mname,dname,hname,rate);
            TableOperation i=TableOperation.Insert(entity);
            table.Execute(i);
            Response.Redirect("~/WebForm1.aspx");
            
        }
    }
}