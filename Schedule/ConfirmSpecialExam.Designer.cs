namespace Schedule
{
    partial class ConfirmSpecialExam
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
            this.confirm = new System.Windows.Forms.Button();
            this.decline = new System.Windows.Forms.Button();
            this.reson = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.ListBox();
            this.course = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "אישור בקשת מועד מיוחד";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.confirm.Image = global::Schedule.Properties.Resources.אישור__ראש_מחלקה;
            this.confirm.Location = new System.Drawing.Point(55, 465);
            this.confirm.Name = "confirm";
            this.confirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirm.Size = new System.Drawing.Size(161, 49);
            this.confirm.TabIndex = 1;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // decline
            // 
            this.decline.BackColor = System.Drawing.Color.Transparent;
            this.decline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.decline.Image = global::Schedule.Properties.Resources.ביטל___ראש_מחלקה;
            this.decline.Location = new System.Drawing.Point(393, 465);
            this.decline.Name = "decline";
            this.decline.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.decline.Size = new System.Drawing.Size(172, 49);
            this.decline.TabIndex = 2;
            this.decline.UseVisualStyleBackColor = false;
            this.decline.Click += new System.EventHandler(this.decline_Click_1);
            // 
            // reson
            // 
            this.reson.FormattingEnabled = true;
            this.reson.Location = new System.Drawing.Point(55, 241);
            this.reson.Name = "reson";
            this.reson.Size = new System.Drawing.Size(281, 186);
            this.reson.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 214);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "סיבת המבקש:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(592, 123);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "בחר ת\"ז:";
            // 
            // s_id
            // 
            this.s_id.FormattingEnabled = true;
            this.s_id.Location = new System.Drawing.Point(393, 150);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(281, 277);
            this.s_id.TabIndex = 6;
            this.s_id.SelectedIndexChanged += new System.EventHandler(this.s_id_SelectedIndexChanged);
            // 
            // course
            // 
            this.course.FormattingEnabled = true;
            this.course.Location = new System.Drawing.Point(55, 150);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(281, 56);
            this.course.TabIndex = 7;
            this.course.SelectedIndexChanged += new System.EventHandler(this.course_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 123);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "שם הקורס:";
            // 
            // ConfirmSpecialExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_ראש_מחלקה;
            this.ClientSize = new System.Drawing.Size(733, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.course);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reson);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmSpecialExam";
            this.Text = "ConfirmSpecialExamData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.ListBox reson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox s_id;
        private System.Windows.Forms.ListBox course;
        private System.Windows.Forms.Label label4;
    }
}