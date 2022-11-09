using System.Data.SqlClient;
namespace sql_server_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=INLPF1DL1G8\\MSSQLSERVER1;Initial Catalog=mohith;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            Console.WriteLine("Enter the name of the student");
            string name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("std_2", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@input", System.Data.SqlDbType.VarChar).Value = name;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("\n"+dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
            }

        }
    }
}