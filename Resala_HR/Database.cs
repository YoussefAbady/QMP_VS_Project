using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO ;

using MySql.Data.MySqlClient;
using System.Data;



namespace Resala_HR
{
    static class Database
    {
        private static String conString;
        private static MySqlConnection DB_con = null ;
        private static String charSet = "utf8";
        private static String port =  "3306";
        
        public static bool isInitialized = false ; 



        public static DataModels.Result initialize(String server, String DB_name  ,String username , String password)
        {
            conString = String.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};PORT={4};charset={5};", server,DB_name,username,password,port,charSet);
            DB_con = new MySqlConnection(conString);
            //DB_con.Open();
            //MySqlCommand comm = new MySqlCommand();
            //comm.Connection = DB_con;
            //comm.CommandText = "set names utf8";
            //comm.ExecuteNonQuery();


            if (DB_con != null)
            {
                isInitialized = true; 
                return DataModels.Result.SUCCESS;
            }
            else
                return DataModels.Result.DATABASE_CONNECTION_ERROR;
        }

        private static DataModels.Result open()
        {
            try
            {
                if(DB_con.State != ConnectionState.Open)
                    DB_con.Open();

                return DataModels.Result.SUCCESS;
            }
            catch (Exception e)
            {
                return DataModels.Result.DATABASE_CONNECTION_ERROR;
            }
        }



        private static void close()
        {
            if (DB_con.State != ConnectionState.Closed)
                DB_con.Close();        
        }

        public static DataModels.Result executeNoResult(String query)
        {

            if (open() != DataModels.Result.SUCCESS)
                return DataModels.Result.DATABASE_CONNECTION_ERROR; 

            MySqlCommand DB_com = DB_con.CreateCommand();
            DB_com.CommandText = query;
            int res = DB_com.ExecuteNonQuery();
            close();

            return DataModels.Result.SUCCESS;
        }

        public static DataModels.Result execute(String query , ref DataTable DT)
        {
            MySqlDataReader reader;
            if (open() != DataModels.Result.SUCCESS)
                return DataModels.Result.DATABASE_CONNECTION_ERROR;
            

            MySqlCommand DB_com = DB_con.CreateCommand();
            DB_com.CommandText = query;

            try
            {
                reader = DB_com.ExecuteReader();
            }
            catch (Exception e)
            {
                return DataModels.Result.DATABASE_ERROR ;

            }

            if (reader == null)
                return DataModels.Result.DATABASE_ERROR ;

            DT = new DataTable();
            DT.Load(reader);
            

            close();

            return DataModels.Result.SUCCESS ; 

        }

        public static DataModels.ConnectionState getState()
        {
            if (DB_con != null)
                return (DataModels.ConnectionState)Enum.Parse(typeof(DataModels.ConnectionState) , DB_con.State.ToString().ToUpper() );
            else
                return DataModels.ConnectionState.BROKEN ;
        }



    }
    
}
