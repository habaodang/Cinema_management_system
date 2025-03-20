using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CinemaManagementSystem
{
    class StaffData
    {
        string conn = @"Data Source=.;Initial Catalog=CinemaDB;Integrated Security=True";

        public int ID { set; get; } //0
        public string Username { set; get; }//1
        public string Password { set; get; }//2
        public string Role { set; get; }//3
        public string Status { set; get; }//4

        public List<StaffData> staffDataLIstData()
        {
            List<StaffData> listData = new List<StaffData>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM USERS WHERE role = 'Staff'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        StaffData sData = new StaffData();
                        sData.ID = (int)reader[0];
                        sData.Username = reader[1].ToString();
                        sData.Password = reader[2].ToString();
                        sData.Role = reader[3].ToString();
                        sData.Status = reader[4].ToString();


                        listData.Add(sData);

                    }

                }
            }
            return listData;
        }
    }
}
