using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
namespace sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=tab.database.windows.net; User id=srinivas; Password=Vasu3246; Initial Catalog=table");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            Console.WriteLine("Table Contents before Insert");
            cmd.CommandText = "Select * from emp1";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2));
            }
            reader.Close();
            Console.WriteLine("Insert Operation");
            cmd.CommandText = "insert into emp1 values(10, 'abcd','AIML')";
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine("Record inserted Sucessfully");
            }
            Console.WriteLine("Table Contents After Insert");
            cmd.CommandText = "Select * from emp1";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2));
            }
            reader.Close();
            cmd.CommandText = "update emp1 set name='kmd' where id=1";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Contents After Insert");
            cmd.CommandText = "Select * from emp1";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + "\t" + reader.GetString(1) + "\t" + reader.GetString(2));
            }
            reader.Close();
            Console.Read();
        }
    }
}
