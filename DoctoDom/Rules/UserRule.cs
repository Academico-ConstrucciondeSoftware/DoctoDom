using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctoDom.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DoctoDom.Rules
{
    public class UserRule
    {
        public string ErrorMessage { get; set; }
        private User user = new User();
        private string connString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;

        public User GetUser(int Id)
        {
            User userResult = new User();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,UserName,LastName,Cedula,Phone1,Phone2, ";
                    query += "Birthdate,UserAddres,Email,Nickname,UserPassword,UserType,Specialties,ImagePath,CreatedDate from Users ";
                    query += "where Id='"+Id+"'";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        userResult.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                        userResult.UserName = sqlDataReader["UserName"].ToString();
                        userResult.LastName = sqlDataReader["LastName"].ToString();
                        userResult.Cedula = sqlDataReader["Cedula"].ToString();
                        userResult.Phone1 = sqlDataReader["Phone1"].ToString();
                        userResult.Phone2 = sqlDataReader["Phone2"].ToString();
                        userResult.Birthdate = Convert.ToDateTime(sqlDataReader["Birthdate"].ToString());
                        userResult.UserAddres = sqlDataReader["UserAddres"].ToString();
                        userResult.Email = sqlDataReader["Email"].ToString();
                        userResult.Nickname = sqlDataReader["Nickname"].ToString();
                        userResult.UserPassword = sqlDataReader["UserPassword"].ToString();
                        userResult.UserType = Convert.ToInt32(sqlDataReader["UserType"].ToString());
                        userResult.Specialties = Convert.ToInt32(sqlDataReader["Specialties"].ToString());
                        userResult.ImagePath = sqlDataReader["ImagePath"].ToString();
                        userResult.CreatedDate = Convert.ToDateTime(sqlDataReader["CreatedDate"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }

            return userResult;
        }

        public DataTable GetDoctor()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,UserName,LastName,Cedula,Phone1,Phone2, ";
                    query += "Birthdate,UserAddres,Email,Nickname,UserPassword,UserType,Specialties,ImagePath,CreatedDate from Users ";
                    query += "where UserType = 1";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }

            return dataTable;
        }

    }
}

