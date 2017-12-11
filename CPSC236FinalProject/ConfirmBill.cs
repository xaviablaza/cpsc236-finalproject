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
    public partial class ConfirmBill : Form
    {
        Dashboard dash;
        Bill bill;
        public ConfirmBill(Dashboard dash,Bill bill)
        {
            InitializeComponent();
            this.dash = dash;
            this.bill = bill;
            label1.Text = bill.Paid_by + " has declared that you owe him money from:";
            label4.Text = bill.Description;
            label5.Text = "$"+bill.Amount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "UPDATE bills SET ACCEPTED=1 WHERE Id="+bill.id;
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            dash.updateLists();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
