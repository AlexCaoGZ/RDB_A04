/*
* FILE		        : SqlConnection.cs
* PROJECT	        : PROG2111 - Assignment 04
* PROGRAMMER	    : Yutong Ji & Zijia Cao
* FIRST  VERSION	: 2021/12/08
* DESCRIPTION	    :
* The functions in this file is to connection the sql database
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace RDB_A04
{
    internal class SqlConnection
    {
        string connStr = null;
        MySqlConnection conn = null;

        /*
        *FUNCTION	    : SqlConnection
        *DESCRIPTION	: the constructor for SqlConnection
        *PARAMETERS	    :
        *	none.
        *RETURNS	    :
        *	nothing.
        */
        public SqlConnection()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            connStr = config.AppSettings.Settings["connStr"].Value;
            conn = new MySqlConnection(connStr);
        }

        /*
        *FUNCTION	    : executeCmd
        *DESCRIPTION	: this function will exectue the SQL cmd.
        *PARAMETERS	    :
        *	string sqlCommand: the sql cmd that need to be executed.
        *RETURNS	    :
        *	List<string> : a list that holds the return data
        */
        public List<string> executeCmd(string sqlCommand)
        {
            //Split the cmd for return datas handling
            string[] sArray = sqlCommand.Split(' ');
            List<string> retrunList = new List<string>();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (sArray[0] == "SELECT" && sArray[3] == "questionTable") 
                {
                    bool a = reader.Read();
                    retrunList.Add(reader.GetValue(0).ToString());
                    retrunList.Add(reader.GetValue(1).ToString());
                    retrunList.Add(reader.GetValue(2).ToString());
                    retrunList.Add(reader.GetValue(3).ToString());
                    retrunList.Add(reader.GetValue(4).ToString());
                    retrunList.Add(reader.GetValue(5).ToString());
                    retrunList.Add(reader.GetValue(6).ToString().ToUpper());

                }
                else if(sArray[0] == "SELECT" && sArray[3] == "userTable")
                {
                    while (reader.Read())
                    {
                        retrunList.Add(reader.GetValue(0).ToString());
                        retrunList.Add(reader.GetValue(1).ToString());
                        retrunList.Add(reader.GetValue(2).ToString());
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retrunList;
        }
    }
}
