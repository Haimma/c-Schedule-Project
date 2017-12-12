namespace Schedule
{
    partial class SecretaryMenu
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
            this.lb_options = new System.Windows.Forms.ListBox();
            this.b_confirm = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.L1_menu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_options
            // 
            this.lb_options.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_options.FormattingEnabled = true;
            this.lb_options.ItemHeight = 22;
            this.lb_options.Location = new System.Drawing.Point(280, 79);
            this.lb_options.Name = "lb_options";
            this.lb_options.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_options.Size = new System.Drawing.Size(399, 356);
            this.lb_options.TabIndex = 0;
            this.lb_options.SelectedIndexChanged += new System.EventHandler(this.lb_options_SelectedIndexChanged);
            // 
            // b_confirm
            // 
            this.b_confirm.BackColor = System.Drawing.Color.Transparent;
            this.b_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_confirm.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_confirm.Image = global::Schedule.Properties.Resources.אישור_מזכירה;
            this.b_confirm.Location = new System.Drawing.Point(37, 164);
            this.b_confirm.Name = "b_confirm";
            this.b_confirm.Size = new System.Drawing.Size(183, 48);
            this.b_confirm.TabIndex = 1;
            this.b_confirm.UseVisualStyleBackColor = false;
            this.b_confirm.Click += new System.EventHandler(this.b_confirm_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.Transparent;
            this.b_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_cancel.Image = global::Schedule.Properties.Resources.ביטול_מזכירה_2;
            this.b_cancel.Location = new System.Drawing.Point(37, 248);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(183, 45);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // L1_menu
            // 
            this.L1_menu.AutoSize = true;
            this.L1_menu.BackColor = System.Drawing.Color.Transparent;
            this.L1_menu.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.L1_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L1_menu.Location = new System.Drawing.Point(273, 9);
            this.L1_menu.Name = "L1_menu";
            this.L1_menu.Size = new System.Drawing.Size(236, 40);
            this.L1_menu.TabIndex = 3;
            this.L1_menu.Text = "תפריט - מזכירה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Schedule.Properties.Resources.strok_מזכירה;
            this.pictureBox1.Location = new System.Drawing.Point(215, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 13);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.BackColor = System.Drawing.Color.Transparent;
            this.l_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.l_name.ForeColor = System.Drawing.SystemColors.Control;
            this.l_name.Location = new System.Drawing.Point(33, 79);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(58, 22);
            this.l_name.TabIndex = 6;
            this.l_name.Text = "Hello ";
            // 
            // SecretaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_מזכירה;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.L1_menu);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_confirm);
            this.Controls.Add(this.lb_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SecretaryMenu";
            this.Text = "SecretaryMenu";
            this.Load += new System.EventHandler(this.SecretaryMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_options;
        private System.Windows.Forms.Button b_confirm;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Label L1_menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_name;
    }
}