namespace CPSC236FinalProject
{
    partial class AccountPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginEmailBox = new System.Windows.Forms.TextBox();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginErr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signupNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.signupPasswordBox = new System.Windows.Forms.TextBox();
            this.signupEmailBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginEmailBox
            // 
            this.loginEmailBox.Location = new System.Drawing.Point(17, 51);
            this.loginEmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginEmailBox.Name = "loginEmailBox";
            this.loginEmailBox.Size = new System.Drawing.Size(293, 20);
            this.loginEmailBox.TabIndex = 0;
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(17, 97);
            this.loginPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.Size = new System.Drawing.Size(293, 20);
            this.loginPasswordBox.TabIndex = 1;
            this.loginPasswordBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(142, 250);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(67, 25);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(139, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Page";
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(132, 241);
            this.signupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(84, 25);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 336);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loginErr);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.loginEmailBox);
            this.tabPage1.Controls.Add(this.loginPasswordBox);
            this.tabPage1.Controls.Add(this.loginButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(337, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // loginErr
            // 
            this.loginErr.AutoSize = true;
            this.loginErr.Location = new System.Drawing.Point(17, 141);
            this.loginErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginErr.Name = "loginErr";
            this.loginErr.Size = new System.Drawing.Size(0, 13);
            this.loginErr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorMessage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.signupNameBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.confirmPasswordBox);
            this.tabPage2.Controls.Add(this.signupPasswordBox);
            this.tabPage2.Controls.Add(this.signupEmailBox);
            this.tabPage2.Controls.Add(this.signupButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(337, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(17, 210);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // signupNameBox
            // 
            this.signupNameBox.Location = new System.Drawing.Point(17, 46);
            this.signupNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupNameBox.Name = "signupNameBox";
            this.signupNameBox.Size = new System.Drawing.Size(297, 20);
            this.signupNameBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(17, 172);
            this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(297, 20);
            this.confirmPasswordBox.TabIndex = 7;
            this.confirmPasswordBox.UseSystemPasswordChar = true;
            // 
            // signupPasswordBox
            // 
            this.signupPasswordBox.Location = new System.Drawing.Point(17, 129);
            this.signupPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupPasswordBox.Name = "signupPasswordBox";
            this.signupPasswordBox.Size = new System.Drawing.Size(297, 20);
            this.signupPasswordBox.TabIndex = 6;
            this.signupPasswordBox.UseSystemPasswordChar = true;
            // 
            // signupEmailBox
            // 
            this.signupEmailBox.Location = new System.Drawing.Point(17, 88);
            this.signupEmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupEmailBox.Name = "signupEmailBox";
            this.signupEmailBox.Size = new System.Drawing.Size(297, 20);
            this.signupEmailBox.TabIndex = 5;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 380);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginEmailBox;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox signupPasswordBox;
        private System.Windows.Forms.TextBox signupEmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox signupNameBox;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label loginErr;
    }
}

