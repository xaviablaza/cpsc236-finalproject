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
    public partial class SettleBill : Form
    {
        Dashboard dash;
        Bill bill;
        public SettleBill(Dashboard dash, Bill bill)
        {
            InitializeComponent();
            this.dash = dash;
            this.bill = bill;
            label3.Text = bill.Description;
            label5.Text = "$" + bill.Amount;
            if (bill.Paid_by == dash.User.Email)
            {
                label1.Text = "A bill between you and " + bill.Paid_to + " was made.";
                label6.Text = "The bill was paid by you.";
                label7.Text = "Did " + bill.Paid_to + " pay you $" + bill.Amount + "?";
            }
            else
            {
                button1.Hide();
                label1.Text = "A bill between you and " + bill.Paid_by + " was made.";
                label6.Text = "The bill was paid by " + bill.Paid_by;
                label7.Text = "You owe " + bill.Paid_to +  " $" + bill.Amount + ".";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "UPDATE bills SET SETTLED=1 WHERE Id=" + bill.id;
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            dash.updateLists();
            this.Close();
        }
    }
}
