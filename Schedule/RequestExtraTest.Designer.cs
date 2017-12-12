namespace Schedule
{
    partial class RequestExtraTest
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
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reson = new System.Windows.Forms.TextBox();
            this.nameCourse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.BackgroundImage = global::Schedule.Properties.Resources.אישור_סטודנט_1;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.send.Location = new System.Drawing.Point(43, 366);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(165, 39);
            this.send.TabIndex = 0;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.application_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(401, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "בקשה למועד מיוחד";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BackgroundImage = global::Schedule.Properties.Resources.ביטול_סטודנט_3;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancel.Location = new System.Drawing.Point(460, 366);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(160, 39);
            this.cancel.TabIndex = 3;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(747, 100);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "בחר קורס:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "סיבה (עד 200 תוים) :";
            // 
            // reson
            // 
            this.reson.Location = new System.Drawing.Point(43, 154);
            this.reson.Name = "reson";
            this.reson.Size = new System.Drawing.Size(577, 20);
            this.reson.TabIndex = 7;
            this.reson.TextChanged += new System.EventHandler(this.reson_TextChanged);
            // 
            // nameCourse
            // 
            this.nameCourse.FormattingEnabled = true;
            this.nameCourse.Location = new System.Drawing.Point(667, 154);
            this.nameCourse.Name = "nameCourse";
            this.nameCourse.Size = new System.Drawing.Size(193, 251);
            this.nameCourse.TabIndex = 9;
            this.nameCourse.SelectedIndexChanged += new System.EventHandler(this.nameCourse_SelectedIndexChanged);
            // 
            // RequestExtraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_סטודנט_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 452);
            this.Controls.Add(this.nameCourse);
            this.Controls.Add(this.reson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Name = "RequestExtraTest";
            this.Text = "RequestExtraTest";
            this.Load += new System.EventHandler(this.RequestExtraTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reson;
        private System.Windows.Forms.ListBox nameCourse;
    }
}