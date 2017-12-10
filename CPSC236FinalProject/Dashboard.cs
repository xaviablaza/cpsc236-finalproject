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
    public partial class Dashboard : Form
    {
        public User User;
        public BindingList<User> friends;
        public BindingList<Bill> bills;
        List<String> balances;
        public Dashboard(User user)
        {
            InitializeComponent();
            friends = new BindingList<User>();
            bills = new BindingList<Bill>();
            balances = new List<String>();
            this.User = user;
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS
                                        bills (
                                        Id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        PAID_BY  VARCHAR(255) NOT NULL,
                                        PAID_TO  VARCHAR(255) NOT NULL,
                                        DESC     VARCHAR(255) NOT NULL,
                                        AMOUNT   DECIMAL(8,2) NOT NULL,
                                        SETTLED  BOOLEAN NOT NULL);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS
                                        friends (
                                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        friend1 VARCHAR(255) NOT NULL,
                                        friend2 VARCHAR(255) NOT NULL);";
            cmd.ExecuteNonQuery();
            // getFriends
            cmd.CommandText = "SELECT friend1,friend2 FROM friends WHERE friend1='" + user.Email + "' OR friend2='" + user.Email + "';";
            SQLiteDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetString(0) == User.Email)
                {
                    friends.Add(new User(dataReader.GetString(1)));
                }
                else
                {
                    friends.Add(new User(dataReader.GetString(0)));
                }
            }
            SQLiteCommand getBills = dbConnection.CreateCommand();

            dbConnection.Close();

            // Set the datasources
            friendsListBox.DataSource = friends;
            billsListBox.DataSource = bills;
            
            // Set the display members
            friendsListBox.DisplayMember = "Email";
            billsListBox.DisplayMember = "Description";

            fullName.Text = user.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add Friend Button
            AddFriend2 form = new AddFriend2(this);
            form.ShowDialog();
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            AddBillPage form = new AddBillPage(this);
            form.ShowDialog();
        }

        private void viewBillBtn_Click(object sender, EventArgs e)
        {
            SettleBill form = new SettleBill();
            form.ShowDialog();
        }
    }
}
