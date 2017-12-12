namespace Schedule
{
    partial class ChangeCourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCourseDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_changeDateile = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.cb_day = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.L_detailCourse = new System.Windows.Forms.Label();
            this.lb_name_lecOrtut = new System.Windows.Forms.ListBox();
            this.lb_class = new System.Windows.Forms.ListBox();
            this.lb_activeCourse = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_changeDateile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Schedule.Properties.Resources.strok_מזכירה;
            this.pictureBox1.Location = new System.Drawing.Point(359, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Schedule.Properties.Resources.real_estate_virtual_personal_assistant;
            this.pictureBox4.Location = new System.Drawing.Point(12, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "שינוי פרטי קורס";
            // 
            // panel_changeDateile
            // 
            this.panel_changeDateile.BackColor = System.Drawing.Color.Transparent;
            this.panel_changeDateile.Controls.Add(this.label5);
            this.panel_changeDateile.Controls.Add(this.label4);
            this.panel_changeDateile.Controls.Add(this.cb_hour);
            this.panel_changeDateile.Controls.Add(this.cb_day);
            this.panel_changeDateile.Controls.Add(this.label3);
            this.panel_changeDateile.Controls.Add(this.L_detailCourse);
            this.panel_changeDateile.Controls.Add(this.lb_name_lecOrtut);
            this.panel_changeDateile.Controls.Add(this.lb_class);
            this.panel_changeDateile.Controls.Add(this.lb_activeCourse);
            this.panel_changeDateile.Controls.Add(this.label2);
            this.panel_changeDateile.Location = new System.Drawing.Point(150, 59);
            this.panel_changeDateile.Name = "panel_changeDateile";
            this.panel_changeDateile.Size = new System.Drawing.Size(704, 350);
            this.panel_changeDateile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(410, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "שעה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(425, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "יום";
            // 
            // cb_hour
            // 
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Location = new System.Drawing.Point(283, 239);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(121, 21);
            this.cb_hour.TabIndex = 13;
            this.cb_hour.SelectedIndexChanged += new System.EventHandler(this.cb_hour_SelectedIndexChanged_1);
            // 
            // cb_day
            // 
            this.cb_day.FormattingEnabled = true;
            this.cb_day.Location = new System.Drawing.Point(283, 178);
            this.cb_day.Name = "cb_day";
            this.cb_day.Size = new System.Drawing.Size(121, 21);
            this.cb_day.TabIndex = 12;
            this.cb_day.SelectedIndexChanged += new System.EventHandler(this.cb_day_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(166, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "פרטי הקורס הנבחר";
            // 
            // L_detailCourse
            // 
            this.L_detailCourse.AutoSize = true;
            this.L_detailCourse.BackColor = System.Drawing.Color.Transparent;
            this.L_detailCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.L_detailCourse.ForeColor = System.Drawing.Color.Red;
            this.L_detailCourse.Location = new System.Drawing.Point(3, 44);
            this.L_detailCourse.Name = "L_detailCourse";
            this.L_detailCourse.Size = new System.Drawing.Size(0, 19);
            this.L_detailCourse.TabIndex = 10;
            // 
            // lb_name_lecOrtut
            // 
            this.lb_name_lecOrtut.FormattingEnabled = true;
            this.lb_name_lecOrtut.Location = new System.Drawing.Point(3, 126);
            this.lb_name_lecOrtut.Name = "lb_name_lecOrtut";
            this.lb_name_lecOrtut.Size = new System.Drawing.Size(128, 199);
            this.lb_name_lecOrtut.TabIndex = 9;
            // 
            // lb_class
            // 
            this.lb_class.FormattingEnabled = true;
            this.lb_class.Location = new System.Drawing.Point(170, 126);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(80, 199);
            this.lb_class.TabIndex = 8;
            // 
            // lb_activeCourse
            // 
            this.lb_activeCourse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_activeCourse.FormattingEnabled = true;
            this.lb_activeCourse.Location = new System.Drawing.Point(488, 35);
            this.lb_activeCourse.Name = "lb_activeCourse";
            this.lb_activeCourse.Size = new System.Drawing.Size(194, 290);
            this.lb_activeCourse.TabIndex = 7;
            this.lb_activeCourse.SelectedIndexChanged += new System.EventHandler(this.lb_activeCourse_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(540, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "עדכון קורס";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::Schedule.Properties.Resources.ביטול_מזכירה_2;
            this.button1.Location = new System.Drawing.Point(497, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::Schedule.Properties.Resources.אישור_מזכירה;
            this.button2.Location = new System.Drawing.Point(256, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 49);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_מזכירה;
            this.ClientSize = new System.Drawing.Size(866, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_changeDateile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeCourseDetails";
            this.Text = "Change Course Details";
            this.Load += new System.EventHandler(this.ScheduleChanges_Secretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_changeDateile.ResumeLayout(false);
            this.panel_changeDateile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_changeDateile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_hour;
        private System.Windows.Forms.ComboBox cb_day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_detailCourse;
        private System.Windows.Forms.ListBox lb_name_lecOrtut;
        private System.Windows.Forms.ListBox lb_class;
        private System.Windows.Forms.ListBox lb_activeCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}