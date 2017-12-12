namespace Schedule
{
    partial class Display_Student_Grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_Student_Grades));
            this.pnl_Appeal_Grade = new System.Windows.Forms.Panel();
            this.pnl_Display_Grades = new System.Windows.Forms.Panel();
            this.btn_Display_Grades_Back = new System.Windows.Forms.Button();
            this.btn_Make_Appeal = new System.Windows.Forms.Button();
            this.lstB_Dysplay_Grades = new System.Windows.Forms.ListBox();
            this.txtB__Diplay_Grades_TitleBar = new System.Windows.Forms.TextBox();
            this.lbl_Display_Grades = new System.Windows.Forms.Label();
            this.btn_Appeal_Back = new System.Windows.Forms.Button();
            this.btn_Appeal_Confirm = new System.Windows.Forms.Button();
            this.grpB_Appeal_Reason = new System.Windows.Forms.GroupBox();
            this.rtxtB_Appeal = new System.Windows.Forms.RichTextBox();
            this.txtB_Appeal_Grade = new System.Windows.Forms.TextBox();
            this.lbl_Appeal_Grade = new System.Windows.Forms.Label();
            this.txtB_Appeal_Lecturer = new System.Windows.Forms.TextBox();
            this.lbl_Appeal_Lecturer = new System.Windows.Forms.Label();
            this.txtB_Appela_Course = new System.Windows.Forms.TextBox();
            this.lbl_Appeal_Course = new System.Windows.Forms.Label();
            this.lbl_Appeal_Grade_Title = new System.Windows.Forms.Label();
            this.pnl_Appeal_Grade.SuspendLayout();
            this.pnl_Display_Grades.SuspendLayout();
            this.grpB_Appeal_Reason.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Appeal_Grade
            // 
            this.pnl_Appeal_Grade.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_סטודנט_1;
            this.pnl_Appeal_Grade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Appeal_Grade.Controls.Add(this.pnl_Display_Grades);
            this.pnl_Appeal_Grade.Controls.Add(this.btn_Appeal_Back);
            this.pnl_Appeal_Grade.Controls.Add(this.btn_Appeal_Confirm);
            this.pnl_Appeal_Grade.Controls.Add(this.grpB_Appeal_Reason);
            this.pnl_Appeal_Grade.Controls.Add(this.txtB_Appeal_Grade);
            this.pnl_Appeal_Grade.Controls.Add(this.lbl_Appeal_Grade);
            this.pnl_Appeal_Grade.Controls.Add(this.txtB_Appeal_Lecturer);
            this.pnl_Appeal_Grade.Controls.Add(this.lbl_Appeal_Lecturer);
            this.pnl_Appeal_Grade.Controls.Add(this.txtB_Appela_Course);
            this.pnl_Appeal_Grade.Controls.Add(this.lbl_Appeal_Course);
            this.pnl_Appeal_Grade.Controls.Add(this.lbl_Appeal_Grade_Title);
            this.pnl_Appeal_Grade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Appeal_Grade.Location = new System.Drawing.Point(0, 0);
            this.pnl_Appeal_Grade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Appeal_Grade.Name = "pnl_Appeal_Grade";
            this.pnl_Appeal_Grade.Size = new System.Drawing.Size(511, 267);
            this.pnl_Appeal_Grade.TabIndex = 0;
            // 
            // pnl_Display_Grades
            // 
            this.pnl_Display_Grades.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_סטודנט_1;
            this.pnl_Display_Grades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Display_Grades.Controls.Add(this.btn_Display_Grades_Back);
            this.pnl_Display_Grades.Controls.Add(this.btn_Make_Appeal);
            this.pnl_Display_Grades.Controls.Add(this.lstB_Dysplay_Grades);
            this.pnl_Display_Grades.Controls.Add(this.txtB__Diplay_Grades_TitleBar);
            this.pnl_Display_Grades.Controls.Add(this.lbl_Display_Grades);
            this.pnl_Display_Grades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Display_Grades.Location = new System.Drawing.Point(0, 0);
            this.pnl_Display_Grades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Display_Grades.Name = "pnl_Display_Grades";
            this.pnl_Display_Grades.Size = new System.Drawing.Size(511, 267);
            this.pnl_Display_Grades.TabIndex = 10;
            // 
            // btn_Display_Grades_Back
            // 
            this.btn_Display_Grades_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Display_Grades_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Display_Grades_Back.BackgroundImage")));
            this.btn_Display_Grades_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Display_Grades_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Display_Grades_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Display_Grades_Back.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Display_Grades_Back.Location = new System.Drawing.Point(8, 191);
            this.btn_Display_Grades_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Display_Grades_Back.Name = "btn_Display_Grades_Back";
            this.btn_Display_Grades_Back.Size = new System.Drawing.Size(159, 47);
            this.btn_Display_Grades_Back.TabIndex = 4;
            this.btn_Display_Grades_Back.Text = "חזור";
            this.btn_Display_Grades_Back.UseVisualStyleBackColor = false;
            this.btn_Display_Grades_Back.Click += new System.EventHandler(this.btn_Display_Grades_Back_Click);
            // 
            // btn_Make_Appeal
            // 
            this.btn_Make_Appeal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Make_Appeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Make_Appeal.BackgroundImage")));
            this.btn_Make_Appeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Make_Appeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Make_Appeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Make_Appeal.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Make_Appeal.Location = new System.Drawing.Point(8, 140);
            this.btn_Make_Appeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Make_Appeal.Name = "btn_Make_Appeal";
            this.btn_Make_Appeal.Size = new System.Drawing.Size(159, 47);
            this.btn_Make_Appeal.TabIndex = 3;
            this.btn_Make_Appeal.Text = "הגש ערעור";
            this.btn_Make_Appeal.UseVisualStyleBackColor = false;
            this.btn_Make_Appeal.Click += new System.EventHandler(this.btn_Make_Appeal_Click);
            // 
            // lstB_Dysplay_Grades
            // 
            this.lstB_Dysplay_Grades.FormattingEnabled = true;
            this.lstB_Dysplay_Grades.Location = new System.Drawing.Point(171, 81);
            this.lstB_Dysplay_Grades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstB_Dysplay_Grades.Name = "lstB_Dysplay_Grades";
            this.lstB_Dysplay_Grades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstB_Dysplay_Grades.Size = new System.Drawing.Size(325, 160);
            this.lstB_Dysplay_Grades.TabIndex = 2;
            // 
            // txtB__Diplay_Grades_TitleBar
            // 
            this.txtB__Diplay_Grades_TitleBar.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtB__Diplay_Grades_TitleBar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtB__Diplay_Grades_TitleBar.Location = new System.Drawing.Point(171, 64);
            this.txtB__Diplay_Grades_TitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB__Diplay_Grades_TitleBar.Name = "txtB__Diplay_Grades_TitleBar";
            this.txtB__Diplay_Grades_TitleBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtB__Diplay_Grades_TitleBar.Size = new System.Drawing.Size(325, 20);
            this.txtB__Diplay_Grades_TitleBar.TabIndex = 1;
            // 
            // lbl_Display_Grades
            // 
            this.lbl_Display_Grades.AutoSize = true;
            this.lbl_Display_Grades.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Display_Grades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Display_Grades.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Display_Grades.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Display_Grades.Image = global::Schedule.Properties.Resources.strok_סטודנט_1;
            this.lbl_Display_Grades.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Display_Grades.Location = new System.Drawing.Point(201, 6);
            this.lbl_Display_Grades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Display_Grades.Name = "lbl_Display_Grades";
            this.lbl_Display_Grades.Size = new System.Drawing.Size(200, 42);
            this.lbl_Display_Grades.TabIndex = 0;
            this.lbl_Display_Grades.Text = "תצוגת ציונים";
            // 
            // btn_Appeal_Back
            // 
            this.btn_Appeal_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Appeal_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Appeal_Back.BackgroundImage")));
            this.btn_Appeal_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Appeal_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Appeal_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Appeal_Back.Location = new System.Drawing.Point(178, 218);
            this.btn_Appeal_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Appeal_Back.Name = "btn_Appeal_Back";
            this.btn_Appeal_Back.Size = new System.Drawing.Size(152, 41);
            this.btn_Appeal_Back.TabIndex = 9;
            this.btn_Appeal_Back.Text = "חזור";
            this.btn_Appeal_Back.UseVisualStyleBackColor = false;
            this.btn_Appeal_Back.Click += new System.EventHandler(this.btn_Appeal_Back_Click);
            // 
            // btn_Appeal_Confirm
            // 
            this.btn_Appeal_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Appeal_Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Appeal_Confirm.BackgroundImage")));
            this.btn_Appeal_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Appeal_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Appeal_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Appeal_Confirm.Location = new System.Drawing.Point(334, 218);
            this.btn_Appeal_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Appeal_Confirm.Name = "btn_Appeal_Confirm";
            this.btn_Appeal_Confirm.Size = new System.Drawing.Size(155, 41);
            this.btn_Appeal_Confirm.TabIndex = 8;
            this.btn_Appeal_Confirm.Text = "אישור";
            this.btn_Appeal_Confirm.UseVisualStyleBackColor = false;
            this.btn_Appeal_Confirm.Click += new System.EventHandler(this.btn_Appeal_Confirm_Click);
            // 
            // grpB_Appeal_Reason
            // 
            this.grpB_Appeal_Reason.BackColor = System.Drawing.Color.Transparent;
            this.grpB_Appeal_Reason.Controls.Add(this.rtxtB_Appeal);
            this.grpB_Appeal_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB_Appeal_Reason.ForeColor = System.Drawing.SystemColors.Window;
            this.grpB_Appeal_Reason.Location = new System.Drawing.Point(35, 94);
            this.grpB_Appeal_Reason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpB_Appeal_Reason.Name = "grpB_Appeal_Reason";
            this.grpB_Appeal_Reason.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpB_Appeal_Reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpB_Appeal_Reason.Size = new System.Drawing.Size(455, 121);
            this.grpB_Appeal_Reason.TabIndex = 7;
            this.grpB_Appeal_Reason.TabStop = false;
            this.grpB_Appeal_Reason.Text = "סיבה לערעור";
            // 
            // rtxtB_Appeal
            // 
            this.rtxtB_Appeal.Location = new System.Drawing.Point(4, 16);
            this.rtxtB_Appeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtB_Appeal.Name = "rtxtB_Appeal";
            this.rtxtB_Appeal.Size = new System.Drawing.Size(448, 102);
            this.rtxtB_Appeal.TabIndex = 0;
            this.rtxtB_Appeal.Text = "";
            // 
            // txtB_Appeal_Grade
            // 
            this.txtB_Appeal_Grade.Location = new System.Drawing.Point(87, 64);
            this.txtB_Appeal_Grade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_Appeal_Grade.Name = "txtB_Appeal_Grade";
            this.txtB_Appeal_Grade.ReadOnly = true;
            this.txtB_Appeal_Grade.ShortcutsEnabled = false;
            this.txtB_Appeal_Grade.Size = new System.Drawing.Size(68, 20);
            this.txtB_Appeal_Grade.TabIndex = 6;
            // 
            // lbl_Appeal_Grade
            // 
            this.lbl_Appeal_Grade.AutoSize = true;
            this.lbl_Appeal_Grade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Appeal_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Appeal_Grade.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Appeal_Grade.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Appeal_Grade.Location = new System.Drawing.Point(155, 59);
            this.lbl_Appeal_Grade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Appeal_Grade.Name = "lbl_Appeal_Grade";
            this.lbl_Appeal_Grade.Size = new System.Drawing.Size(40, 26);
            this.lbl_Appeal_Grade.TabIndex = 5;
            this.lbl_Appeal_Grade.Text = "ציון";
            // 
            // txtB_Appeal_Lecturer
            // 
            this.txtB_Appeal_Lecturer.Location = new System.Drawing.Point(191, 64);
            this.txtB_Appeal_Lecturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_Appeal_Lecturer.Name = "txtB_Appeal_Lecturer";
            this.txtB_Appeal_Lecturer.ReadOnly = true;
            this.txtB_Appeal_Lecturer.Size = new System.Drawing.Size(109, 20);
            this.txtB_Appeal_Lecturer.TabIndex = 4;
            // 
            // lbl_Appeal_Lecturer
            // 
            this.lbl_Appeal_Lecturer.AutoSize = true;
            this.lbl_Appeal_Lecturer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Appeal_Lecturer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Appeal_Lecturer.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Appeal_Lecturer.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Appeal_Lecturer.Location = new System.Drawing.Point(299, 59);
            this.lbl_Appeal_Lecturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Appeal_Lecturer.Name = "lbl_Appeal_Lecturer";
            this.lbl_Appeal_Lecturer.Size = new System.Drawing.Size(59, 26);
            this.lbl_Appeal_Lecturer.TabIndex = 3;
            this.lbl_Appeal_Lecturer.Text = "מרצה";
            // 
            // txtB_Appela_Course
            // 
            this.txtB_Appela_Course.Location = new System.Drawing.Point(361, 64);
            this.txtB_Appela_Course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB_Appela_Course.Name = "txtB_Appela_Course";
            this.txtB_Appela_Course.ReadOnly = true;
            this.txtB_Appela_Course.Size = new System.Drawing.Size(93, 20);
            this.txtB_Appela_Course.TabIndex = 2;
            // 
            // lbl_Appeal_Course
            // 
            this.lbl_Appeal_Course.AutoSize = true;
            this.lbl_Appeal_Course.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Appeal_Course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Appeal_Course.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Appeal_Course.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Appeal_Course.Location = new System.Drawing.Point(454, 59);
            this.lbl_Appeal_Course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Appeal_Course.Name = "lbl_Appeal_Course";
            this.lbl_Appeal_Course.Size = new System.Drawing.Size(53, 26);
            this.lbl_Appeal_Course.TabIndex = 1;
            this.lbl_Appeal_Course.Text = "קורס";
            // 
            // lbl_Appeal_Grade_Title
            // 
            this.lbl_Appeal_Grade_Title.AutoSize = true;
            this.lbl_Appeal_Grade_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Appeal_Grade_Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Appeal_Grade_Title.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Appeal_Grade_Title.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Appeal_Grade_Title.Image = global::Schedule.Properties.Resources.strok_סטודנט_1;
            this.lbl_Appeal_Grade_Title.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Appeal_Grade_Title.Location = new System.Drawing.Point(166, 6);
            this.lbl_Appeal_Grade_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Appeal_Grade_Title.Name = "lbl_Appeal_Grade_Title";
            this.lbl_Appeal_Grade_Title.Size = new System.Drawing.Size(206, 42);
            this.lbl_Appeal_Grade_Title.TabIndex = 0;
            this.lbl_Appeal_Grade_Title.Text = "ערעור על ציון";
            // 
            // Display_Student_Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 267);
            this.Controls.Add(this.pnl_Appeal_Grade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Display_Student_Grades";
            this.Text = "Display_Student_Grades";
            this.pnl_Appeal_Grade.ResumeLayout(false);
            this.pnl_Appeal_Grade.PerformLayout();
            this.pnl_Display_Grades.ResumeLayout(false);
            this.pnl_Display_Grades.PerformLayout();
            this.grpB_Appeal_Reason.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Appeal_Grade;
        private System.Windows.Forms.Panel pnl_Display_Grades;
        private System.Windows.Forms.Button btn_Display_Grades_Back;
        private System.Windows.Forms.Button btn_Make_Appeal;
        private System.Windows.Forms.ListBox lstB_Dysplay_Grades;
        private System.Windows.Forms.TextBox txtB__Diplay_Grades_TitleBar;
        private System.Windows.Forms.Label lbl_Display_Grades;
        private System.Windows.Forms.Button btn_Appeal_Back;
        private System.Windows.Forms.Button btn_Appeal_Confirm;
        private System.Windows.Forms.GroupBox grpB_Appeal_Reason;
        private System.Windows.Forms.RichTextBox rtxtB_Appeal;
        private System.Windows.Forms.TextBox txtB_Appeal_Grade;
        private System.Windows.Forms.Label lbl_Appeal_Grade;
        private System.Windows.Forms.TextBox txtB_Appeal_Lecturer;
        private System.Windows.Forms.Label lbl_Appeal_Lecturer;
        private System.Windows.Forms.TextBox txtB_Appela_Course;
        private System.Windows.Forms.Label lbl_Appeal_Course;
        private System.Windows.Forms.Label lbl_Appeal_Grade_Title;
    }
}