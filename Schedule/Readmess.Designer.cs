namespace Schedule
{
    partial class Readmess
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
            this.lb_message = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.FormattingEnabled = true;
            this.lb_message.Location = new System.Drawing.Point(146, 134);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(456, 238);
            this.lb_message.TabIndex = 0;
            this.lb_message.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Return
            // 
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Return.ForeColor = System.Drawing.Color.SeaShell;
            this.Return.Image = global::Schedule.Properties.Resources.כפתור_כללי1;
            this.Return.Location = new System.Drawing.Point(48, 422);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(228, 85);
            this.Return.TabIndex = 2;
            this.Return.Text = "חזרה";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Guttman Kav", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(238, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 38);
            this.label10.TabIndex = 27;
            this.label10.Text = "הודעות אישיות";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Schedule.Properties.Resources.strok__ראש_מחלקה;
            this.pictureBox1.Location = new System.Drawing.Point(211, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 10);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Readmess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(685, 511);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lb_message);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Readmess";
            this.Text = "Readmess";
            this.Load += new System.EventHandler(this.Readmess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}