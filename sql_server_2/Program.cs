using System.Data.SqlClient;
namespace sql_server_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = "Data Source=DESKTOP-TH8OA6H;Initial Catalog=mohith;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            Console.WriteLine("Enter the threshold_amount");
            ulong balance = Convert.ToUInt64(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("select * from Show(@Balance)", conn);
            cmd.Parameters.Add("@Balance", System.Data.SqlDbType.BigInt).Value = balance;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader[0] + "  ");
                Console.Write(reader[1] + "  ");
                Console.Write(reader[2] + "  ");
                Console.Write(reader[3] + "  ");
                Console.Write(reader[4] + "  ");
                Console.Write(reader[5] + "  ");

                Console.WriteLine();
            }
            Console.WriteLine("Execution successfully completed!!");
            reader.Close();
            conn.Close();
            
        }
        
    }
}