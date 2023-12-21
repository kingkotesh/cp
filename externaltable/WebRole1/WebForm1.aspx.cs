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
    public class MovieEntity : TableEntity
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public MovieEntity() { }
        public MovieEntity(string name, string director,string hero,string rating)
        {
            Name= name;
            Director= director;
            RowKey = hero;
            PartitionKey = rating;
        }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        CloudStorageAccount account;
        CloudTableClient tableClient;
        CloudTable table;
        protected void Page_Load(object sender, EventArgs e)
        {
            account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=bec586;AccountKey=4tq5fwW3MBwtuMv202G4JgLRFnXDev+RBFyNZ8yiGivL+AcFg5zqJk+l/P/H6iqSw+73ak2COpeY+AStnNvWng==;EndpointSuffix=core.windows.net");
            tableClient=account.CreateCloudTableClient();
            table = tableClient.GetTableReference("externaltable");
            table.CreateIfNotExists();
            TableQuery<MovieEntity>query=new TableQuery<MovieEntity>();
            grid.DataSource=table.ExecuteQuery<MovieEntity>(query);
            grid.DataBind();

        }
        protected void insert_Click(object sender, EventArgs e)
        {
            string name=mtext.Text;
            string director=dtext.Text;
            string hero=htext.Text;
            string rating = rate.Text;
            MovieEntity m=new MovieEntity(name, director, hero, rating);
            TableOperation top = TableOperation.Insert(m);
            table.Execute(top);
            Response.Redirect("~/WebForm1.aspx");

        }
    }
}