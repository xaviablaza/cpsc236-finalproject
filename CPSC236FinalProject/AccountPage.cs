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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnection.Open();
            SQLiteCommand createTables = dbConnection.CreateCommand();
            createTables.CommandText = @"CREATE TABLE IF NOT EXISTS
                                        user (
                                        Id       INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        NAME     NVARCHAR(2048) NOT NULL,
                                        EMAIL    VARCHAR(255) NOT NULL,
                                        PASSWORD VARCHAR(255) NOT NULL);";
            createTables.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginString = loginEmailBox.Text.ToString().Trim();
            string password = loginPasswordBox.Text.ToString().Trim();

            if (loginString == "" || password == "")
            {
                loginErr.Text = "All fields must be filled out.";
            }
            else
            {
                SQLiteConnection sqlite_conn;          // Database Connection Object
                SQLiteCommand sqlite_cmd;             // Database Command Object
                SQLiteDataReader sqlite_datareader;  // Data Reader Object
                sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT NAME,EMAIL,PASSWORD FROM user WHERE EMAIL = '"+loginString+"';";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                // The SQLiteDataReader allows us to run through each row per loop
                bool login = false;
                User user = null;
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    // Print out the content of the text field:
                    // System.Console.WriteLine("DEBUG Output: '" + sqlite_datareader["text"] + "'");
                    string nameReader = sqlite_datareader.GetString(0);
                    string emailReader = sqlite_datareader.GetString(1);
                    string pwdReader = sqlite_datareader.GetString(2);
                    if (password == pwdReader)
                    {
                        login = true;
                    }
                    user = new User(nameReader, emailReader);
                }
                sqlite_conn.Close();
                if (login)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    loginErr.Text = "Email and password combination is incorrect or does not exist.";
                }
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string name = signupNameBox.Text.ToString().Trim();
            string email = signupEmailBox.Text.ToString().Trim();
            string password = signupPasswordBox.Text.ToString().Trim();
            string confirmPwd = confirmPasswordBox.Text.ToString().Trim();

            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            if (name != "" && email != "" && password != "" && confirmPwd != "")
            {
                bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail && password == confirmPwd)
                {
                    dbConnection.Open();
                    SQLiteCommand cmd = dbConnection.CreateCommand();
                    cmd.CommandText = "SELECT EMAIL FROM user WHERE EMAIL='"+email+"';";
                    SQLiteDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        errorMessage.Text = "Email is already registered.";
                        dbConnection.Close();
                        return;
                    }
                    SQLiteCommand sqlite_cmd = dbConnection.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO user (NAME, EMAIL, PASSWORD) VALUES ('" + name + "','" + email + "','" + password + "');";
                    sqlite_cmd.ExecuteNonQuery();
                    this.Hide();
                    Dashboard dashboard = new Dashboard(new User(name, email));
                    dashboard.ShowDialog();
                    this.Close();
                }
                else if (!isEmail)
                {
                    errorMessage.Text = "Email is not valid.";
                }
                else if (!password.Equals(confirmPwd))
                {
                    errorMessage.Text = "Passwords do not match.";
                }
            }
            else
            {
                errorMessage.Text = "All fields must be filled in.";
            }
            dbConnection.Close();
        }
    }
}
