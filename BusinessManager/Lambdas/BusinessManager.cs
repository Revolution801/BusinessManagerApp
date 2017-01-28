using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization;


using MySql.Data.MySqlClient;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Lambdas
{
    public class BusinessManager
    {
        private const string connectionString = "Data Source=revolutionlandscaping.cglo8cydpqxv.us-west-1.rds.amazonaws.com;Persist Security Info=True;User ID=RevolutionAdmin;PWD=password;";

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string GetAccount(string input, ILambdaContext context)
        {
            // Connect to the DB
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open a connection
                    conn.Open();

                    // Create a command
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "select * from Accounts";

                    // Execute the command and cycle through the DataReader object
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Add header row to table
                        //sb.Append("<h1>All Scores</h1><html><head><title>All Recorded Scores</title></head><body><table border=\"1\">"
                        //    + "<tr><td>Game</td><td>Player Name</td><td>Max Score</td><td>Time Alive(sec)</td></tr>");
                        while (reader.Read())
                        {
                            //sb.Append("<tr>" + "<td>" + reader["GameID"] + "</td>" 
                            //    + "<td>" + reader["PlayerName"] + "</td>"
                            //    + "<td>" + reader["MaxScore"] + "</td>" 
                            //    + "<td>" + reader["TimeAlive"] + "</td>" + "</tr>");
                        }
                        //sb.Append("</table></body></html>");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return input?.ToUpper();
        }
    }
}
