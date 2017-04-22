namespace Password_Management
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.TitleLab = new System.Windows.Forms.Label();
            this.TitleList = new System.Windows.Forms.ListBox();
            this.AccountLab = new System.Windows.Forms.Label();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add.Location = new System.Drawing.Point(160, 261);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 32);
            this.Add.TabIndex = 0;
            this.Add.Text = "New";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Quit.Location = new System.Drawing.Point(429, 261);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 32);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Change.Location = new System.Drawing.Point(338, 261);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(85, 32);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // TitleLab
            // 
            this.TitleLab.AutoSize = true;
            this.TitleLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLab.Location = new System.Drawing.Point(12, 21);
            this.TitleLab.Name = "TitleLab";
            this.TitleLab.Size = new System.Drawing.Size(46, 22);
            this.TitleLab.TabIndex = 3;
            this.TitleLab.Text = "Titel";
            // 
            // TitleList
            // 
            this.TitleList.FormattingEnabled = true;
            this.TitleList.ItemHeight = 12;
            this.TitleList.Location = new System.Drawing.Point(12, 46);
            this.TitleList.Name = "TitleList";
            this.TitleList.Size = new System.Drawing.Size(124, 208);
            this.TitleList.Sorted = true;
            this.TitleList.TabIndex = 4;
            this.TitleList.SelectedIndexChanged += new System.EventHandler(this.TitleList_SelectedIndexChanged);
            // 
            // AccountLab
            // 
            this.AccountLab.AutoSize = true;
            this.AccountLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountLab.Location = new System.Drawing.Point(186, 49);
            this.AccountLab.Name = "AccountLab";
            this.AccountLab.Size = new System.Drawing.Size(81, 22);
            this.AccountLab.TabIndex = 5;
            this.AccountLab.Text = "Account:";
            // 
            // PasswordLab
            // 
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLab.Location = new System.Drawing.Point(173, 106);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(94, 22);
            this.PasswordLab.TabIndex = 6;
            this.PasswordLab.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(294, 107);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(210, 21);
            this.Password.TabIndex = 7;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(294, 50);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(210, 21);
            this.Account.TabIndex = 8;
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Remove.Location = new System.Drawing.Point(241, 261);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(91, 32);
            this.Remove.TabIndex = 9;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refresh.Location = new System.Drawing.Point(28, 260);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(87, 32);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 305);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordLab);
            this.Controls.Add(this.AccountLab);
            this.Controls.Add(this.TitleList);
            this.Controls.Add(this.TitleLab);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Password-Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label TitleLab;
        private System.Windows.Forms.ListBox TitleList;
        private System.Windows.Forms.Label AccountLab;
        private System.Windows.Forms.Label PasswordLab;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Refresh;
    }
}

