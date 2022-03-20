using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using FINAL_PROJECT3.Models;
using System.Data;


namespace FINAL_PROJECT3.Models.DAL
{
    

    public class DataServices
    {
        //public int InsertGate(GatePass gatePass)
        //{

        //}


        public int InsertUser(User user)
        {
            SqlConnection con = null;

            try
            {
                con = Connect("FinalProject");
                SqlCommand command = CreateInsertUser(user, con);
                int affected = command.ExecuteNonQuery();
                //if (UsersList == null)
                //    UsersList = new List<User>();
                //UsersList.Add(user);
                return affected;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed in Insert", ex);
            }

            finally
            {
                con.Close();
            }
        }

        SqlCommand CreateInsertUser(User user, SqlConnection con)
        {
            string insertStr = "INSERT INTO [SHAY_User] ([USR_Id],[USR_UserName],[USR_Email],[USR_Password]) " +
                "VALUES('" + user.UserID + "','" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "')";
            SqlCommand command = new SqlCommand(insertStr, con);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandTimeout = 30;
            return command;
        }

        SqlConnection Connect(string connectionStringName)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }







    }
}