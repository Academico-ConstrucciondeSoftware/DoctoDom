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
        private User user = new User(1, "", "");
        private string connString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;

        public User GetUser(int Id)
        {
            User userResult = new User(1, "", "");
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,UserName,LastName,Cedula,Phone1,Phone2, ";
                    query += "Birthdate,UserAddres,Email,Nickname,UserPassword,UserType,Specialties,ImagePath,CreatedDate from Users ";
                    query += "where Id='" + Id + "'";
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

        public User GetUser(string NickName, string password)
        {
            User userResult = new User(1, "", "");
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,UserName,LastName,Cedula,Phone1,Phone2, ";
                    query += "Birthdate,UserAddres,Email,Nickname,UserPassword,UserType,Specialties,ImagePath,CreatedDate from Users ";
                    query += "where Nickname='" + NickName + "' and UserPassword='" + password + "'";
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

        public int NewUser(User user)
        {
            User userResult = new User(1, "", "");
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "INSERT INTO [dbo].[Users] ";
                    query += "([UserName] ";
                    query += ",[LastName] ";
                    query += ",[Cedula] ";
                    query += ",[Phone1] ";
                    query += ",[Phone2] ";
                    query += ",[Birthdate] ";
                    query += ",[UserAddres] ";
                    query += ",[Email] ";
                    query += ",[Nickname] ";
                    query += ",[UserPassword] ";
                    query += ",[UserType] ";
                    query += ",[Specialties] ";
                    query += ",[ImagePath] ";
                    query += ",[CreatedDate]) ";
                    query += "VALUES ";
                    query += "('" + user.UserName + "'";
                    query += ",'" + user.LastName + "' ";
                    query += ",'" + user.Cedula + "' ";
                    query += ",'" + user.Phone1 + "' ";
                    query += ",'" + user.Phone2 + "' ";
                    query += ",'" + user.Birthdate + "' ";
                    query += ",'" + user.UserAddres + "' ";
                    query += ",'" + user.Email + "' ";
                    query += ",'" + user.Nickname + "' ";
                    query += ",'" + user.UserPassword + "' ";
                    query += ",'" + user.UserType + "' ";
                    query += ",'" + user.Specialties + "' ";
                    query += ",'" + @user.ImagePath + "' ";
                    query += ",'" + DateTime.Now + "') ";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    return sqlCommand.ExecuteNonQuery(); //Return number affeted insert
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return 0;
            }
        }

        public int UpdateUser(User user)
        {
            User userResult = new User(1, "", "");
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "UPDATE[dbo].[Users] ";
                    query += "SET[UserName] = '" + user.UserName + "'";
                    query += ",[LastName] = '" + user.LastName + "'";
                    query += ",[Cedula] = '" + user.Cedula + "'";
                    query += ",[Phone1] = '" + user.Phone1 + "'";
                    query += ",[Phone2] = '" + user.Phone2 + "'";
                    query += ",[Birthdate] = '" + user.Birthdate + "' ";
                    query += ",[UserAddres] = '" + user.UserAddres + "'";
                    query += ",[Email] = '" + user.Email + "'";
                    query += ",[Nickname] = '" + user.Nickname + "'";
                    query += ",[UserPassword] = '" + user.UserPassword + "'";
                    query += ",[UserType] = '" + user.UserType + "'";
                    query += ",[Specialties] = '" + user.Specialties + "'";
                    query += ",[ImagePath] = '" + @user.ImagePath + "'";
                    query += ",[CreatedDate] = '" + user.CreatedDate + "' ";
                    query += "WHERE Id = '" + user.Id + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    return sqlCommand.ExecuteNonQuery(); //Return number affeted insert
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return 0;
            }
        }

        public int DeleteUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "Delete from [dbo].[Users] ";
                    query += "WHERE Id = '" + user.Id + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    return sqlCommand.ExecuteNonQuery(); //Return number affeted insert
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return 0;
            }
        }

    }
}

