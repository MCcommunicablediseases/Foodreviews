namespace Foodreviews
{
    partial class Form1
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
            this.enterUsername = new System.Windows.Forms.TextBox();
            this.enterPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.restaurantType = new System.Windows.Forms.ComboBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.restaurantNamesList = new System.Windows.Forms.ListBox();
            this.incorrectPasswordWarning = new System.Windows.Forms.TextBox();
            this.checkedListBoxRN = new System.Windows.Forms.CheckedListBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterUsername
            // 
            this.enterUsername.Location = new System.Drawing.Point(999, 27);
            this.enterUsername.Name = "enterUsername";
            this.enterUsername.Size = new System.Drawing.Size(100, 26);
            this.enterUsername.TabIndex = 1;
            this.enterUsername.TextChanged += new System.EventHandler(this.enterUsername_TextChanged);
            // 
            // enterPassword
            // 
            this.enterPassword.Location = new System.Drawing.Point(1105, 28);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(100, 26);
            this.enterPassword.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.IndianRed;
            this.loginButton.Location = new System.Drawing.Point(1226, 25);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // restaurantType
            // 
            this.restaurantType.FormattingEnabled = true;
            this.restaurantType.Location = new System.Drawing.Point(51, 3);
            this.restaurantType.Name = "restaurantType";
            this.restaurantType.Size = new System.Drawing.Size(551, 28);
            this.restaurantType.TabIndex = 0;
            this.restaurantType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.restaurantType.Click += new System.EventHandler(this.restaurantType_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.restaurantType);
            this.panelMain.Location = new System.Drawing.Point(232, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(670, 44);
            this.panelMain.TabIndex = 4;
            // 
            // restaurantNamesList
            // 
            this.restaurantNamesList.FormattingEnabled = true;
            this.restaurantNamesList.ItemHeight = 20;
            this.restaurantNamesList.Location = new System.Drawing.Point(1302, 873);
            this.restaurantNamesList.Name = "restaurantNamesList";
            this.restaurantNamesList.Size = new System.Drawing.Size(26, 24);
            this.restaurantNamesList.TabIndex = 5;
            this.restaurantNamesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // incorrectPasswordWarning
            // 
            this.incorrectPasswordWarning.BackColor = System.Drawing.SystemColors.Control;
            this.incorrectPasswordWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incorrectPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.incorrectPasswordWarning.Location = new System.Drawing.Point(1068, 60);
            this.incorrectPasswordWarning.Margin = new System.Windows.Forms.Padding(0);
            this.incorrectPasswordWarning.Name = "incorrectPasswordWarning";
            this.incorrectPasswordWarning.Size = new System.Drawing.Size(194, 19);
            this.incorrectPasswordWarning.TabIndex = 6;
            this.incorrectPasswordWarning.Text = "Incorrect! Try again";
            this.incorrectPasswordWarning.Visible = false;
            this.incorrectPasswordWarning.TextChanged += new System.EventHandler(this.incorrectPasswordWarning_TextChanged);
            // 
            // checkedListBoxRN
            // 
            this.checkedListBoxRN.FormattingEnabled = true;
            this.checkedListBoxRN.Location = new System.Drawing.Point(35, 92);
            this.checkedListBoxRN.Name = "checkedListBoxRN";
            this.checkedListBoxRN.Size = new System.Drawing.Size(394, 717);
            this.checkedListBoxRN.TabIndex = 7;
            this.checkedListBoxRN.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 889);
            this.Controls.Add(this.checkedListBoxRN);
            this.Controls.Add(this.incorrectPasswordWarning);
            this.Controls.Add(this.restaurantNamesList);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.enterUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox enterUsername;
        private System.Windows.Forms.TextBox enterPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ComboBox restaurantType;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox restaurantNamesList;
        private System.Windows.Forms.TextBox incorrectPasswordWarning;
        private System.Windows.Forms.CheckedListBox checkedListBoxRN;
    }
}

