namespace Schedule
{
    partial class Lecturers_Appeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturers_Appeals));
            this.pnl_Lecturer_Appeals = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Decline_Appeal = new System.Windows.Forms.Button();
            this.btn_Confirm_Appeal = new System.Windows.Forms.Button();
            this.txtB_New_Grade = new System.Windows.Forms.TextBox();
            this.lbl_New_Grade = new System.Windows.Forms.Label();
            this.grpB_Reason = new System.Windows.Forms.GroupBox();
            this.rtxtB_Reason = new System.Windows.Forms.RichTextBox();
            this.txtB_Title = new System.Windows.Forms.TextBox();
            this.lstB_Appeals_List = new System.Windows.Forms.ListBox();
            this.lbl_Lecturer_Appeals = new System.Windows.Forms.Label();
            this.pnl_Lecturer_Appeals.SuspendLayout();
            this.grpB_Reason.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Lecturer_Appeals
            // 
            this.pnl_Lecturer_Appeals.BackgroundImage = global::Schedule.Properties.Resources.backgrounds__מרצה;
            this.pnl_Lecturer_Appeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Lecturer_Appeals.Controls.Add(this.btn_Back);
            this.pnl_Lecturer_Appeals.Controls.Add(this.btn_Decline_Appeal);
            this.pnl_Lecturer_Appeals.Controls.Add(this.btn_Confirm_Appeal);
            this.pnl_Lecturer_Appeals.Controls.Add(this.txtB_New_Grade);
            this.pnl_Lecturer_Appeals.Controls.Add(this.lbl_New_Grade);
            this.pnl_Lecturer_Appeals.Controls.Add(this.grpB_Reason);
            this.pnl_Lecturer_Appeals.Controls.Add(this.txtB_Title);
            this.pnl_Lecturer_Appeals.Controls.Add(this.lstB_Appeals_List);
            this.pnl_Lecturer_Appeals.Controls.Add(this.lbl_Lecturer_Appeals);
            this.pnl_Lecturer_Appeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Lecturer_Appeals.Location = new System.Drawing.Point(0, 0);
            this.pnl_Lecturer_Appeals.Name = "pnl_Lecturer_Appeals";
            this.pnl_Lecturer_Appeals.Size = new System.Drawing.Size(1127, 506);
            this.pnl_Lecturer_Appeals.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Back.Location = new System.Drawing.Point(830, 418);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(272, 60);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "חזור";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_Decline_Appeal
            // 
            this.btn_Decline_Appeal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Decline_Appeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Decline_Appeal.BackgroundImage")));
            this.btn_Decline_Appeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Decline_Appeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Decline_Appeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decline_Appeal.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Decline_Appeal.Location = new System.Drawing.Point(76, 376);
            this.btn_Decline_Appeal.Name = "btn_Decline_Appeal";
            this.btn_Decline_Appeal.Size = new System.Drawing.Size(272, 60);
            this.btn_Decline_Appeal.TabIndex = 7;
            this.btn_Decline_Appeal.Text = "דחיית ערעור";
            this.btn_Decline_Appeal.UseVisualStyleBackColor = false;
            this.btn_Decline_Appeal.Click += new System.EventHandler(this.btn_Decline_Appeal_Click);
            // 
            // btn_Confirm_Appeal
            // 
            this.btn_Confirm_Appeal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Appeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Confirm_Appeal.BackgroundImage")));
            this.btn_Confirm_Appeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Confirm_Appeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm_Appeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm_Appeal.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Confirm_Appeal.Location = new System.Drawing.Point(76, 310);
            this.btn_Confirm_Appeal.Name = "btn_Confirm_Appeal";
            this.btn_Confirm_Appeal.Size = new System.Drawing.Size(272, 60);
            this.btn_Confirm_Appeal.TabIndex = 6;
            this.btn_Confirm_Appeal.Text = "אישור ערעור";
            this.btn_Confirm_Appeal.UseVisualStyleBackColor = false;
            this.btn_Confirm_Appeal.Click += new System.EventHandler(this.btn_Confirm_Appeal_Click);
            // 
            // txtB_New_Grade
            // 
            this.txtB_New_Grade.Location = new System.Drawing.Point(386, 339);
            this.txtB_New_Grade.Name = "txtB_New_Grade";
            this.txtB_New_Grade.Size = new System.Drawing.Size(100, 26);
            this.txtB_New_Grade.TabIndex = 5;
            // 
            // lbl_New_Grade
            // 
            this.lbl_New_Grade.AutoSize = true;
            this.lbl_New_Grade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_New_Grade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_New_Grade.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_New_Grade.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_New_Grade.Location = new System.Drawing.Point(492, 333);
            this.lbl_New_Grade.Name = "lbl_New_Grade";
            this.lbl_New_Grade.Size = new System.Drawing.Size(114, 37);
            this.lbl_New_Grade.TabIndex = 4;
            this.lbl_New_Grade.Text = "ציון חדש";
            // 
            // grpB_Reason
            // 
            this.grpB_Reason.BackColor = System.Drawing.Color.Transparent;
            this.grpB_Reason.Controls.Add(this.rtxtB_Reason);
            this.grpB_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB_Reason.ForeColor = System.Drawing.SystemColors.Window;
            this.grpB_Reason.Location = new System.Drawing.Point(181, 89);
            this.grpB_Reason.Name = "grpB_Reason";
            this.grpB_Reason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpB_Reason.Size = new System.Drawing.Size(431, 215);
            this.grpB_Reason.TabIndex = 3;
            this.grpB_Reason.TabStop = false;
            this.grpB_Reason.Text = "סיבה לערעור";
            // 
            // rtxtB_Reason
            // 
            this.rtxtB_Reason.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtB_Reason.Location = new System.Drawing.Point(6, 28);
            this.rtxtB_Reason.Name = "rtxtB_Reason";
            this.rtxtB_Reason.ReadOnly = true;
            this.rtxtB_Reason.Size = new System.Drawing.Size(419, 177);
            this.rtxtB_Reason.TabIndex = 0;
            this.rtxtB_Reason.Text = "";
            // 
            // txtB_Title
            // 
            this.txtB_Title.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtB_Title.ForeColor = System.Drawing.SystemColors.Window;
            this.txtB_Title.Location = new System.Drawing.Point(618, 89);
            this.txtB_Title.Name = "txtB_Title";
            this.txtB_Title.ReadOnly = true;
            this.txtB_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtB_Title.Size = new System.Drawing.Size(484, 26);
            this.txtB_Title.TabIndex = 2;
            // 
            // lstB_Appeals_List
            // 
            this.lstB_Appeals_List.FormattingEnabled = true;
            this.lstB_Appeals_List.ItemHeight = 20;
            this.lstB_Appeals_List.Location = new System.Drawing.Point(618, 116);
            this.lstB_Appeals_List.Name = "lstB_Appeals_List";
            this.lstB_Appeals_List.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstB_Appeals_List.Size = new System.Drawing.Size(484, 284);
            this.lstB_Appeals_List.TabIndex = 1;
            this.lstB_Appeals_List.SelectedIndexChanged += new System.EventHandler(this.lstB_Appeals_List_SelectedIndexChanged);
            // 
            // lbl_Lecturer_Appeals
            // 
            this.lbl_Lecturer_Appeals.AutoSize = true;
            this.lbl_Lecturer_Appeals.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Lecturer_Appeals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Lecturer_Appeals.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Lecturer_Appeals.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Lecturer_Appeals.Image = global::Schedule.Properties.Resources.strok__מרצה;
            this.lbl_Lecturer_Appeals.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Lecturer_Appeals.Location = new System.Drawing.Point(399, 9);
            this.lbl_Lecturer_Appeals.Name = "lbl_Lecturer_Appeals";
            this.lbl_Lecturer_Appeals.Size = new System.Drawing.Size(383, 63);
            this.lbl_Lecturer_Appeals.TabIndex = 0;
            this.lbl_Lecturer_Appeals.Text = "ערעורי סטודנטים";
            // 
            // Lecturers_Appeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 506);
            this.Controls.Add(this.pnl_Lecturer_Appeals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecturers_Appeals";
            this.Text = "Lecturers_Appeals";
            this.pnl_Lecturer_Appeals.ResumeLayout(false);
            this.pnl_Lecturer_Appeals.PerformLayout();
            this.grpB_Reason.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Lecturer_Appeals;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Decline_Appeal;
        private System.Windows.Forms.Button btn_Confirm_Appeal;
        private System.Windows.Forms.TextBox txtB_New_Grade;
        private System.Windows.Forms.Label lbl_New_Grade;
        private System.Windows.Forms.GroupBox grpB_Reason;
        private System.Windows.Forms.RichTextBox rtxtB_Reason;
        private System.Windows.Forms.TextBox txtB_Title;
        private System.Windows.Forms.ListBox lstB_Appeals_List;
        private System.Windows.Forms.Label lbl_Lecturer_Appeals;
    }
}