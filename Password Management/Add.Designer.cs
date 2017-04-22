namespace Password_Management
{
    partial class Add
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
            this.AccountLab = new System.Windows.Forms.Label();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.TitleLab = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountLab
            // 
            this.AccountLab.AutoSize = true;
            this.AccountLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountLab.Location = new System.Drawing.Point(74, 90);
            this.AccountLab.Name = "AccountLab";
            this.AccountLab.Size = new System.Drawing.Size(81, 22);
            this.AccountLab.TabIndex = 0;
            this.AccountLab.Text = "Account:";
            // 
            // PasswordLab
            // 
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLab.Location = new System.Drawing.Point(61, 126);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(94, 22);
            this.PasswordLab.TabIndex = 1;
            this.PasswordLab.Text = "Password:";
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(161, 90);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(197, 21);
            this.Account.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(161, 126);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(197, 21);
            this.Password.TabIndex = 3;
            // 
            // AddData
            // 
            this.AddData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddData.Location = new System.Drawing.Point(55, 190);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(100, 41);
            this.AddData.TabIndex = 4;
            this.AddData.Text = "Confirm";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLab.Location = new System.Drawing.Point(92, 53);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(51, 22);
            this.TitleLab.TabIndex = 5;
            this.TitleLab.Text = "Title:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(161, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 21);
            this.Title.TabIndex = 6;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(262, 190);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 41);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleLab);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.PasswordLab);
            this.Controls.Add(this.AccountLab);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLab;
        private System.Windows.Forms.Label PasswordLab;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button Cancel;
    }
}