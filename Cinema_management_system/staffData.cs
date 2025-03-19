using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_management_system
{
    class staffData
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\movie.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { set; get; }
        public List<staffData> staffDataListData()
        {
            List<staffData> listData=new List<staffData>();
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM users WHERE role='Staff' AND status !='Deleted'";
                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader=cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        staffData sData=new staffData();
                        sData.ID = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.Role= reader[3].ToString();
                        sData.Status = reader[4].ToString();
                        listData.Add(sData);

                    }
                }
            }
            return listData;
        }
    }
}
