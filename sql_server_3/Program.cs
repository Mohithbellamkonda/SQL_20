using System;
using System.Data.SqlClient;
namespace sql_server_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=DESKTOP-TH8OA6H;Initial Catalog=mohith;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            Console.WriteLine("enter any genere from the following-");
            Console.WriteLine("horror,kids, mythological, Commercial");
            string genre=Console.ReadLine();
            SqlCommand cmd=new SqlCommand("select * from Display(@Genre)", con);
            cmd.Parameters.Add("@Genre",System.Data.SqlDbType.VarChar).Value = genre;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                

            }
            dr.Close();
            con.Close();

        }
    }
}