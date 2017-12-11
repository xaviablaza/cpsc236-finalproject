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
        public Dashboard(User user)
        {
            InitializeComponent();
            friends = new BindingList<User>();
            bills = new BindingList<Bill>();
            this.User = user;
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
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
            dataReader.Close();
            dbConnection.Close();

            // Set the datasources
            friendsListBox.DataSource = friends;
            billsListBox.DataSource = bills;
            
            // Set the display members
            friendsListBox.DisplayMember = "Email";
            billsListBox.DisplayMember = "Description";

            fullName.Text = user.Name;
            updateLists();
        }

        public void updateLists()
        {
            bills.Clear();
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM bills WHERE (PAID_BY='"+User.Email+"' OR PAID_TO='" + User.Email + "') AND SETTLED=0;";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                string paid_by = reader.GetString(1);
                string paid_to = reader.GetString(2);
                string desc = reader.GetString(3);
                float amount = reader.GetFloat(4);
                bool accepted = reader.GetBoolean(5);
                bool settled = reader.GetBoolean(6);
                bills.Add(new Bill(id, paid_by, paid_to, desc, amount, accepted, settled));
            }
            reader.Close();
            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add Friend Button
            AddFriend form = new AddFriend(this);
            form.ShowDialog();
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            AddBillPage form = new AddBillPage(this);
            form.ShowDialog();
        }

        private void viewBillBtn_Click(object sender, EventArgs e)
        {
            // Open up the View Details Form
            if (billsListBox.SelectedIndex > -1)
            {
                Bill bill = (Bill)billsListBox.Items[billsListBox.SelectedIndex];
                //if (!bill.isAccepted && bill.Paid_to != User.Email)
                //{
                 //   ConfirmBill form = new ConfirmBill(this,bill);
                //}
                //else
                //{
                    SettleBill form = new SettleBill(this,bill);
                    form.ShowDialog();
                //}
            }


            
        }
    }
}
