namespace CPSC236FinalProject
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.fullName = new System.Windows.Forms.Label();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.billsListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.viewBillBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friends";
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(14, 51);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(159, 368);
            this.friendsListBox.TabIndex = 1;
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(186, 25);
            this.fullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(63, 13);
            this.fullName.TabIndex = 4;
            this.fullName.Text = "Xavi Ablaza";
            // 
            // addBillBtn
            // 
            this.addBillBtn.Location = new System.Drawing.Point(597, 19);
            this.addBillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(59, 25);
            this.addBillBtn.TabIndex = 5;
            this.addBillBtn.Text = "Add Bill";
            this.addBillBtn.UseVisualStyleBackColor = true;
            this.addBillBtn.Click += new System.EventHandler(this.addBillBtn_Click);
            // 
            // billsListBox
            // 
            this.billsListBox.FormattingEnabled = true;
            this.billsListBox.Location = new System.Drawing.Point(189, 51);
            this.billsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.billsListBox.Name = "billsListBox";
            this.billsListBox.Size = new System.Drawing.Size(546, 368);
            this.billsListBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Friend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewBillBtn
            // 
            this.viewBillBtn.Location = new System.Drawing.Point(660, 19);
            this.viewBillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewBillBtn.Name = "viewBillBtn";
            this.viewBillBtn.Size = new System.Drawing.Size(75, 25);
            this.viewBillBtn.TabIndex = 8;
            this.viewBillBtn.Text = "View Bill";
            this.viewBillBtn.UseVisualStyleBackColor = true;
            this.viewBillBtn.Click += new System.EventHandler(this.viewBillBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 441);
            this.Controls.Add(this.viewBillBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.billsListBox);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Button addBillBtn;
        private System.Windows.Forms.ListBox billsListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewBillBtn;
    }
}