using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace storedProcedure.DataAccessLayer
{
    public class Class1
    {
        public void saveData(string Id,string txtName, string txtAge, string txtCountry) {
            string cn=ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cn))
            {
                
                SqlCommand cmd = new SqlCommand("SpMyProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Insert");
                cmd.Parameters.AddWithValue("@Name", txtName);
                cmd.Parameters.AddWithValue("@Age", txtAge);
                cmd.Parameters.AddWithValue("@Country", txtCountry);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
            }


        }
        public void DeleteData(string Id)
        {
            string cn = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cn))
            {
                SqlCommand cmd = new SqlCommand("SpMyProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Delete");
                cmd.Parameters.AddWithValue("@Id",Id);
                con.Open();
                cmd.ExecuteNonQuery();
              
                con.Close();
            }

        }
        public void UpdateData(string Id, string txtName, string txtAge, string txtCountry)
        {
            string cn = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cn))
            {

                SqlCommand cmd = new SqlCommand("SpMyProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Update");
                cmd.Parameters.AddWithValue("@Name", txtName);
                cmd.Parameters.AddWithValue("@Age", txtAge);
                cmd.Parameters.AddWithValue("@Country", txtCountry);
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        
        }
}