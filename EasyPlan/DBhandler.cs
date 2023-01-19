using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Win1.Models;

namespace Win1
{
    //This static class holds static methods to get/update/delete data from the DB.
    static class DBhandler
    {
        public static Dictionary<string, string> notificationsInfo = new Dictionary<string, string>();
        
        private static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ben Keidar\Documents\DiaryDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public static  void ExecuteQuery(string query) {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static int GetEventId(string query) {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = (Int32)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
        public static Dictionary<string,string> GetEventFields(string query)
        {
            Dictionary<string, string> fields = new Dictionary<string, string>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            fields.Add("Text",dt.Rows[0]["Text"].ToString());
            fields.Add("Description", dt.Rows[0]["Description"].ToString());
            fields.Add("Type", dt.Rows[0]["Type"].ToString());
            conn.Close();
            return fields;
        }
        public static List<MyEvents> GetEvents(string query) {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<MyEvents> eventsArr = new List<MyEvents>();
            while (reader.Read())
            {
                eventsArr.Add(new MyEvents(
                    reader["id"].ToString(),
                    reader["Text"].ToString(),
                    reader["Description"].ToString(),
                    reader["Type"].ToString().Trim(),
                    Convert.ToDateTime(reader["Start"].ToString()),
                    Convert.ToDateTime(reader["Ending"].ToString())
               ));
            }
            conn.Close();
            return eventsArr;
        }
        public static List<MyTask> GetTasks(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<MyTask> eventsArr = new List<MyTask>();
            while (reader.Read())
            {
                eventsArr.Add(new MyTask(
                    reader["Id"].ToString(),
                    reader["Title"].ToString(),
                    Convert.ToInt32(reader["Done"].ToString()),
                    Convert.ToDateTime(reader["Deadline"].ToString())
               ));
            }
            conn.Close();
            return eventsArr;
        }
        public static List<Note> GetNotes(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Note> notesArr = new List<Note>();
            while (reader.Read())
            {
                notesArr.Add(new Note(
                    reader["Id"].ToString(),
                    reader["Title"].ToString(),
                    reader["Text"].ToString()
               ));
            }
            conn.Close();
            return notesArr;
        }
        public static List<MyNotification> GetNotifications(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<MyNotification> notesArr = new List<MyNotification>();
            while (reader.Read())
            {
                notesArr.Add(new MyNotification(
                    reader["Id"].ToString(),
                    reader["NotifyTime"].ToString(),
                    reader["NotifyMessage"].ToString()
               ));
            }
            conn.Close();
            return notesArr;
        }
    }
}