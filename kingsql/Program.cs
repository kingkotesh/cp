using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace kingsql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=kingserver.database.windows.net; User Id=king; Password=kotesh@123;Initial Catalog=kingdb");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into emp values(2,'aaa','cse')";
            cmd.ExecuteNonQuery();
            Console.WriteLine("record inserted");
            cmd.CommandText = "update emp set name='king' where id=2";
            cmd.ExecuteNonQuery();
            Console.WriteLine("record updated");
            cmd.CommandText = "delete from emp where id=1";
            cmd.ExecuteNonQuery();
            Console.WriteLine("record deleted");
            cmd.CommandText = "select * from emp";
            SqlDataReader r= cmd.ExecuteReader();
            while(r.Read())
            {
                Console.WriteLine(r.GetInt32(0)+"\t"+r.GetString(1)+"\t"+r.GetString(2));
            }
            r.Close();
            Console.Read();

        }
    }
}
