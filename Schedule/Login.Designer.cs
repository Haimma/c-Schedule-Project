namespace Schedule
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.b_exit = new System.Windows.Forms.Button();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.Transparent;
            this.b_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_exit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.b_exit.Image = global::Schedule.Properties.Resources.exitB;
            this.b_exit.Location = new System.Drawing.Point(406, 278);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(108, 29);
            this.b_exit.TabIndex = 5;
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Pass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_Pass.Location = new System.Drawing.Point(270, 234);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(241, 32);
            this.tb_Pass.TabIndex = 2;
            this.tb_Pass.Text = "Password";
            this.tb_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.tb_Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tb_Pass.Leave += new System.EventHandler(this.tb_Pass_Leave);
            // 
            // b_login
            // 
            this.b_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_login.BackColor = System.Drawing.Color.Transparent;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_login.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.b_login.Image = global::Schedule.Properties.Resources.LoginB;
            this.b_login.Location = new System.Drawing.Point(270, 278);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(108, 29);
            this.b_login.TabIndex = 4;
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.Window;
            this.tb_user.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_user.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_user.Location = new System.Drawing.Point(270, 192);
            this.tb_user.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(241, 32);
            this.tb_user.TabIndex = 0;
            this.tb_user.Text = "Username";
            this.tb_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_user_MouseClick);
            this.tb_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.tb_user.Leave += new System.EventHandler(this.tb_user_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.tb_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox tb_user;
    }
}

