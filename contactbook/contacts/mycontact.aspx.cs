using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
namespace contacts
{
    public class ContactEntity : TableEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ContactEntity() { }
        public ContactEntity(string name, string email, string contacttype, string contactnumber)
        {
            Name = name;
            Email = email;
            PartitionKey = contacttype;
            RowKey = contactnumber;
        }
    }
    public partial class mycontact : System.Web.UI.Page
    {
        CloudStorageAccount sa;
        CloudTableClient client;
        CloudTable table; 
        protected void Page_Load(object sender, EventArgs e)
        {
            sa = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("TableCS"));
            client=sa.CreateCloudTableClient();
            table = client.GetTableReference("mycontactsbook");
            table.CreateIfNotExists();
            TableQuery<ContactEntity> query = new TableQuery<ContactEntity>();
            ContactGrid.DataSource=table.ExecuteQuery<ContactEntity>(query);
            ContactGrid.DataBind();       
        }
        protected void insert_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;
            string email=txtemail.Text;
            string contacttype=txtcnt.Text;
            string contactnumber=txtcn.Text;
            ContactEntity contact = new ContactEntity(name,email,contacttype,contactnumber);
            TableOperation iop=TableOperation.Insert(contact);
            table.Execute(iop);
            Response.Redirect("~/mycontact.aspx");

        }
        protected void ContactGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            tbladdrecord.Visible = false;
            ContactGrid.Visible = false;
            tbleditrecord.Visible = true;
            int index=Int32.Parse(e.CommandArgument.ToString());
            GridViewRow row = ContactGrid.Rows[index];
            txtedname.Text = row.Cells[0].Text;
            txtedemail.Text= row.Cells[1].Text;
            txtedcnt.Text = row.Cells[2].Text;
            txtedcn.Text = row.Cells[3].Text;
        }
        protected void edit_Click(object sender, EventArgs e)
        {
            TableOperation eop=TableOperation.Retrieve<ContactEntity>(txtedcnt.Text,txtedcn.Text);
            TableResult res = table.Execute(eop);
            ContactEntity econtact=(ContactEntity)res.Result;
            econtact.Name = txtedname.Text;
            econtact.Email = txtedemail.Text;
            table.Execute(TableOperation.Replace(econtact));
            Response.Redirect("~/mycontact.aspx");
        }
        protected void delete_Click(object sender, EventArgs e)
        {
            TableOperation dop=TableOperation.Retrieve<ContactEntity>(txtedcnt.Text,txtedcn.Text);
            TableResult res=table.Execute(dop);
            ContactEntity dcontact=(ContactEntity)res.Result;
            table.Execute(TableOperation.Delete(dcontact));
            Response.Redirect("~/mycontact.aspx");
        }
    }
}