namespace Schedule
{
    partial class AddSpecialDateExtraExam
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
            this.do_it = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameCourse = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_hourse = new System.Windows.Forms.ComboBox();
            this.lb_class = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // do_it
            // 
            this.do_it.BackColor = System.Drawing.Color.Transparent;
            this.do_it.BackgroundImage = global::Schedule.Properties.Resources.אישור__ראש_מחלקה;
            this.do_it.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.do_it.Location = new System.Drawing.Point(64, 422);
            this.do_it.Name = "do_it";
            this.do_it.Size = new System.Drawing.Size(162, 39);
            this.do_it.TabIndex = 0;
            this.do_it.UseVisualStyleBackColor = false;
            this.do_it.Click += new System.EventHandler(this.do_it_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BackgroundImage = global::Schedule.Properties.Resources.ביטל___ראש_מחלקה;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Location = new System.Drawing.Point(359, 421);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(163, 40);
            this.cancel.TabIndex = 1;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(401, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "קביעת תאריך למועד מיוחד";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameCourse
            // 
            this.nameCourse.FormattingEnabled = true;
            this.nameCourse.Location = new System.Drawing.Point(636, 171);
            this.nameCourse.Name = "nameCourse";
            this.nameCourse.Size = new System.Drawing.Size(193, 290);
            this.nameCourse.TabIndex = 8;
            this.nameCourse.SelectedIndexChanged += new System.EventHandler(this.nameCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(636, 109);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "בחר קורס עבורו תרצה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(665, 133);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "לקבוע מועד מיוחד:";
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(359, 191);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(202, 20);
            this.dt_date.TabIndex = 11;
            this.dt_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(454, 146);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "בחר תאריך:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(512, 251);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "שעה:";
            // 
            // cb_hourse
            // 
            this.cb_hourse.FormattingEnabled = true;
            this.cb_hourse.Location = new System.Drawing.Point(359, 304);
            this.cb_hourse.Name = "cb_hourse";
            this.cb_hourse.Size = new System.Drawing.Size(202, 21);
            this.cb_hourse.TabIndex = 36;
            this.cb_hourse.SelectedIndexChanged += new System.EventHandler(this.cb_hourse_SelectedIndexChanged);
            // 
            // lb_class
            // 
            this.lb_class.FormattingEnabled = true;
            this.lb_class.Location = new System.Drawing.Point(64, 146);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(202, 225);
            this.lb_class.TabIndex = 39;
            this.lb_class.SelectedIndexChanged += new System.EventHandler(this.lb_class_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 109);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "בחר כיתה:";
            // 
            // AddSpecialDateExtraExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_ראש_מחלקה;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_class);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_hourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.do_it);
            this.Name = "AddSpecialDateExtraExam";
            this.Text = "AddSpecialDateExtraExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button do_it;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox nameCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_hourse;
        private System.Windows.Forms.ListBox lb_class;
        private System.Windows.Forms.Label label5;
    }
}