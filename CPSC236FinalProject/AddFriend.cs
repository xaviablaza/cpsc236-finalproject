using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSC236FinalProject
{
    public partial class AddFriend : Form
    {
        Dashboard dashboard;
        public AddFriend()
        {
            InitializeComponent();
        }

        public AddFriend(Dashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text.ToString();
            if (email != dashboard.User.Email)
            {
                SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
                dbConnection.Open();
                SQLiteCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = "SELECT EMAIL FROM user WHERE EMAIL='" + email + "';";
                SQLiteDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    errMsg.Text = "Email not found.";
                    return;
                }
                dataReader.Close();
                SQLiteCommand cmd3 = dbConnection.CreateCommand();
                cmd3.CommandText = "SELECT friend1 from friends WHERE friend1='" + email + "' OR friend2='" + email + "' LIMIT 1;";
                SQLiteDataReader dataReader2 = cmd3.ExecuteReader();
                if (dataReader2.HasRows)
                {
                    errMsg.Text = email + " already added as your friend.";
                    return;
                }
                dataReader2.Close();
                SQLiteCommand cmd2 = dbConnection.CreateCommand();
                cmd2.CommandText = "INSERT INTO friends (friend1,friend2) VALUES ('" + dashboard.User.Email + "','" + email + "');";
                cmd2.ExecuteNonQuery();
                dashboard.friends.Add(new User(email));
                dbConnection.Close();
                this.Close();
            }
            else
            {
                errMsg.Text = "You can't add yourself as a friend.";
            }
        }
    }
}
