using System.Data.SqlClient;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            string connection = "Data Source=DESKTOP-TH8OA6H;initial catalog = mohith;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();


            
            for(int i = 0; i < 10; i++)    
            {

                SqlCommand cmd = new SqlCommand("pass", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Console.WriteLine("Enter details of record " + (i + 1));

                Console.WriteLine("Enter  Passport Number:");
                long passport_no = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter  Candidate Name:");
                string candidate_name = Console.ReadLine();

                Console.WriteLine("Enter  Passport Expiry Date:");
                string expiry_date = Console.ReadLine();

                Console.WriteLine("Enter the Years of validity:");
                int val_years = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Applied Through Channel:");
                string channel_app = Console.ReadLine();

                cmd.Parameters.Add("@pass_id", System.Data.SqlDbType.BigInt).Value = passport_no;
                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = candidate_name;
                cmd.Parameters.Add("@exipiry_date", System.Data.SqlDbType.Date).Value = expiry_date;
                cmd.Parameters.Add("@validity_years", System.Data.SqlDbType.Int).Value = val_years;
                cmd.Parameters.Add("@applied_by", System.Data.SqlDbType.VarChar).Value = channel_app;

                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted Successfully!!");
                
            }
            conn.Close();
        }

        catch (SqlException e)
        {
            Console.WriteLine("this is sql exception" + e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("This is exception in c#" + ex.Message);
        }












    }
}
