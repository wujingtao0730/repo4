namespace WindowsFormsApp1
{
    partial class Login
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
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textUsername.Location = new System.Drawing.Point(384, 148);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(121, 27);
            this.textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPassword.Location = new System.Drawing.Point(384, 209);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(121, 27);
            this.textPassword.TabIndex = 1;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(313, 148);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(65, 27);
            this.username.TabIndex = 2;
            this.username.Text = "姓名:";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(313, 209);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 26);
            this.password.TabIndex = 3;
            this.password.Text = "密码:";
            // 
            // commit
            // 
            this.commit.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commit.Location = new System.Drawing.Point(281, 323);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(115, 35);
            this.commit.TabIndex = 4;
            this.commit.Text = "确认";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(278, 257);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 23);
            this.type.TabIndex = 5;
            this.type.Text = "用户类型：";
            // 
            // UserType
            // 
            this.UserType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UserType.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "普通用户",
            "管理员"});
            this.UserType.Location = new System.Drawing.Point(384, 258);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(121, 25);
            this.UserType.TabIndex = 6;
            this.UserType.Text = "用户类型";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("宋体", 10.64348F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.Location = new System.Drawing.Point(452, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(115, 35);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "清除";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(882, 555);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.type);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Button cancel;
    }
}

