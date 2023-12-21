using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace vmsql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=172.206.233.231,1433;User Id=santhosh;Password=santhosh@123;Initial Catalog=temp ");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            Console.WriteLine("before insert");
            cmd.CommandText = "select * from emp";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0)+"\t"+reader.GetString(1)+"\t"+reader.GetString(2));
            }
        }
    }
}
