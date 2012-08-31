    using System.Data.SqlClient;

    namespace WCF45_UPD_Binding_Service
    {
        public class Service : IService
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            public Service()
            {
                Conn = new SqlConnection("Data Source=(localdb)\v11.0;Initial Catalog=Company;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"); 
            }


            public void PostMessages(MessagePost message)
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into MessagePost Values(@PostDetails)";
                Cmd.Parameters.AddWithValue("@PostDetails",message.MessageDetails);
                Cmd.ExecuteNonQuery(); 
                Conn.Close();
            }
        }
    }
