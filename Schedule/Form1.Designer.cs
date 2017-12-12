namespace Schedule
{
    partial class Form1
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
            this.b_kaftoris = new System.Windows.Forms.Button();
            this.cb_sasa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // b_kaftoris
            // 
            this.b_kaftoris.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.b_kaftoris.Location = new System.Drawing.Point(138, 72);
            this.b_kaftoris.Name = "b_kaftoris";
            this.b_kaftoris.Size = new System.Drawing.Size(95, 79);
            this.b_kaftoris.TabIndex = 0;
            this.b_kaftoris.Text = "כפתורי";
            this.b_kaftoris.UseVisualStyleBackColor = true;
            this.b_kaftoris.Click += new System.EventHandler(this.b_kaftoris_Click);
            // 
            // cb_sasa
            // 
            this.cb_sasa.AutoSize = true;
            this.cb_sasa.Location = new System.Drawing.Point(155, 237);
            this.cb_sasa.Name = "cb_sasa";
            this.cb_sasa.Size = new System.Drawing.Size(98, 21);
            this.cb_sasa.TabIndex = 1;
            this.cb_sasa.Text = "checkBox1";
            this.cb_sasa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this.cb_sasa);
            this.Controls.Add(this.b_kaftoris);
            this.Name = "Form1";
            this.Text = "הוספת משתמש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_kaftoris;
        private System.Windows.Forms.CheckBox cb_sasa;
    }
}