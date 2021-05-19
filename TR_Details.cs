using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Demo1
{
    public class TR_Details
    {
        public static string connectionstring()
        {
            string cstring = string.Empty;
            cstring = ConfigurationManager.ConnectionStrings["TestDemoConnectionString"].ConnectionString;
            return cstring;

        }
        public DataTable GetTRDetails()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataAdapter sqlda = null;
            DataTable dtTRDetails = null;

            using (connection = new SqlConnection(connectionstring()))
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "USP_GetTRData";
                sqlda = new SqlDataAdapter(command);
                dtTRDetails = new DataTable();
                sqlda.Fill(dtTRDetails);

            }
            return dtTRDetails;

        }
    }
}