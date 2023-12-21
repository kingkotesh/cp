using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace vmconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=172.206.232.31,1433; User Id=king; Password=Kingkotesh@123; Initial Catalog=kingdb");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from emp";
            SqlDataReader r= cmd.ExecuteReader();
            while (r.Read())
            {
                Console.WriteLine(r.GetInt32(0)+"\t"+r.GetString(1)+"\t"+r.GetString(2));
            }
            r.Close();
            conn.Close();
            Console.ReadLine();

        }
    }
}
