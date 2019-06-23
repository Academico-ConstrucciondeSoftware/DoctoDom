﻿using DoctoDom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctoDom.Rules
{
    public class AppointmentsRule
    {
        public string ErrorMessage { get; set; }
        private string connString = ConfigurationManager.ConnectionStrings["dbContext"].ConnectionString;

        public DataTable GetAppointments(int Id)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,QuotesDescription,QuotesDate,UserId, Specialties from Quotes where UserId = '" + Id.ToString() + "'";
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

        public DataTable GetAppointmentsDoctor(int UserId)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,QuotesDescription,QuotesDate,UserId, Specialties from Quotes where IdDoctor = '" + UserId.ToString() + "'";
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


        public Quotes GetDetailtAppointments(int UserId, int CitaId)
        {
            Quotes quotes = new Quotes();
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,QuotesDescription,QuotesDate,UserId, Specialties,IdDoctor from Quotes where UserId = '" + UserId.ToString() + "' And ";
                    query += "Id ='" +CitaId.ToString()+ "' ";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        quotes.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                        quotes.QuotesDescription = sqlDataReader["QuotesDescription"].ToString();
                        quotes.QuotesDate = Convert.ToDateTime(sqlDataReader["QuotesDate"].ToString());
                        quotes.UserId = Convert.ToInt32(sqlDataReader["UserId"].ToString());
                        quotes.Specialties = Convert.ToInt32(sqlDataReader["Specialties"].ToString());
                        if (!string.IsNullOrEmpty(sqlDataReader["IdDoctor"].ToString()))
                        {
                            quotes.DoctorId = Convert.ToInt32(sqlDataReader["IdDoctor"].ToString());
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }

            return quotes;
        }

        public Quotes GetDetailtAppointmentsDoctor(int UserId, int CitaId)
        {
            Quotes quotes = new Quotes();
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "select Id,QuotesDescription,QuotesDate,UserId, Specialties,IdDoctor from Quotes where IdDoctor = '" + UserId.ToString() + "' And ";
                    query += "Id ='" + CitaId.ToString() + "' ";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.CommandType = CommandType.Text;
                    conn.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        quotes.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                        quotes.QuotesDescription = sqlDataReader["QuotesDescription"].ToString();
                        quotes.QuotesDate = Convert.ToDateTime(sqlDataReader["QuotesDate"].ToString());
                        quotes.UserId = Convert.ToInt32(sqlDataReader["UserId"].ToString());
                        quotes.Specialties = Convert.ToInt32(sqlDataReader["Specialties"].ToString());
                        if (!string.IsNullOrEmpty(sqlDataReader["IdDoctor"].ToString()))
                        {
                            quotes.DoctorId = Convert.ToInt32(sqlDataReader["IdDoctor"].ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }

            return quotes;
        }
    }
}