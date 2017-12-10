using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSC236FinalProject
{
    public partial class AddBillPage : Form
    {
        Dashboard dash;
        public AddBillPage(Dashboard dash)
        {
            InitializeComponent();
            this.dash = dash;
            foreach (User friend in dash.friends) {
                comboBox1.Items.Add(friend.Email);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string billDesc = billNameBox.Text.ToString();
            string billAmount = billAmountBox.Text.ToString();
            if (billDesc == "" || billAmount == "")
            {
                errMsg.Text = "All fields must not be empty.";
                return;
            }
            bool isFloat = Regex.IsMatch(billAmount, @"^\d{ 1,100}\.\d{2}", RegexOptions.IgnoreCase);
            if (isFloat)
            {
                errMsg.Text = "Bill amount must be parseable and up to 2 decimal places only.";
                return;
            }
            bool paidByMe = radioButton1.Checked;
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            string values = "";
            string paidBy = "";
            string paidTo = "";
            if (paidByMe)
            {
                paidBy = dash.User.Email;
                paidTo = comboBox1.Text.ToString();
            }
            else
            {
                paidBy = comboBox1.Text.ToString();
                paidTo = dash.User.Email;
            }
            values += "'" + paidBy + "'";
            values += ",'" + paidTo + "'";
            values += ",'" + billDesc+"'";
            values += "," + billAmount;
            values += ",0";
            cmd.CommandText = "INSERT INTO bills (PAID_BY,PAID_TO,DESC,AMOUNT,SETTLED) VALUES ("+values+");";
            cmd.ExecuteNonQuery();
            this.Close();
            float amount = 0;
            float.TryParse(billAmount, out amount);
            dash.bills.Add(new Bill(paidBy, paidTo, billDesc, amount));
            dbConnection.Close();
        }
    }
}
