using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctoDom.Rules
{
    public class SpecialtiesRule
    {
        public string ErrorMessage { get; set; }
        private string connString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;

        public DataTable GetSpecialties()
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,SpecialtiesName,SpecialtiesDescripction from Specialties ";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(result);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }

            return result;
        }
    }
}
