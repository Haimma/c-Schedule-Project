/*
namespace Schedule
{
    partial class DeterminingCourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeterminingCourseDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nameCoures = new System.Windows.Forms.TextBox();
            this.tb_numOfLec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_dYear = new System.Windows.Forms.RadioButton();
            this.rb_cYear = new System.Windows.Forms.RadioButton();
            this.rb_bYear = new System.Windows.Forms.RadioButton();
            this.rb_aYear = new System.Windows.Forms.RadioButton();
            this.rb_aSemester = new System.Windows.Forms.RadioButton();
            this.rb_bSemester = new System.Windows.Forms.RadioButton();
            this.rb_cSemester = new System.Windows.Forms.RadioButton();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת קורס חדש";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם הקורס";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(454, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "מחלקה";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(479, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "שנה";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(454, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "סמסטר";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(398, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "מספר הרצאות";
            this.label6.UseWaitCursor = true;
            // 
            // tb_nameCoures
            // 
            this.tb_nameCoures.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_nameCoures.Location = new System.Drawing.Point(189, 80);
            this.tb_nameCoures.Name = "tb_nameCoures";
            this.tb_nameCoures.Size = new System.Drawing.Size(203, 20);
            this.tb_nameCoures.TabIndex = 6;
            this.tb_nameCoures.UseWaitCursor = true;
            this.tb_nameCoures.TextChanged += new System.EventHandler(this.tb_nameCoures_TextChanged);
            // 
            // tb_numOfLec
            // 
            this.tb_numOfLec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_numOfLec.Location = new System.Drawing.Point(189, 249);
            this.tb_numOfLec.Name = "tb_numOfLec";
            this.tb_numOfLec.Size = new System.Drawing.Size(203, 20);
            this.tb_numOfLec.TabIndex = 7;
            this.tb_numOfLec.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_dYear);
            this.groupBox1.Controls.Add(this.rb_cYear);
            this.groupBox1.Controls.Add(this.rb_bYear);
            this.groupBox1.Controls.Add(this.rb_aYear);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(120, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 29);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // rb_dYear
            // 
            this.rb_dYear.AutoSize = true;
            this.rb_dYear.Location = new System.Drawing.Point(21, 8);
            this.rb_dYear.Name = "rb_dYear";
            this.rb_dYear.Size = new System.Drawing.Size(34, 20);
            this.rb_dYear.TabIndex = 3;
            this.rb_dYear.TabStop = true;
            this.rb_dYear.Text = "ד";
            this.rb_dYear.UseVisualStyleBackColor = true;
            this.rb_dYear.UseWaitCursor = true;
            // 
            // rb_cYear
            // 
            this.rb_cYear.AutoSize = true;
            this.rb_cYear.Location = new System.Drawing.Point(99, 6);
            this.rb_cYear.Name = "rb_cYear";
            this.rb_cYear.Size = new System.Drawing.Size(32, 20);
            this.rb_cYear.TabIndex = 2;
            this.rb_cYear.TabStop = true;
            this.rb_cYear.Text = "ג";
            this.rb_cYear.UseVisualStyleBackColor = true;
            this.rb_cYear.UseWaitCursor = true;
            // 
            // rb_bYear
            // 
            this.rb_bYear.AutoSize = true;
            this.rb_bYear.Location = new System.Drawing.Point(175, 6);
            this.rb_bYear.Name = "rb_bYear";
            this.rb_bYear.Size = new System.Drawing.Size(34, 20);
            this.rb_bYear.TabIndex = 1;
            this.rb_bYear.TabStop = true;
            this.rb_bYear.Text = "ב";
            this.rb_bYear.UseVisualStyleBackColor = true;
            this.rb_bYear.UseWaitCursor = true;
            // 
            // rb_aYear
            // 
            this.rb_aYear.AutoSize = true;
            this.rb_aYear.Location = new System.Drawing.Point(235, 7);
            this.rb_aYear.Name = "rb_aYear";
            this.rb_aYear.Size = new System.Drawing.Size(34, 20);
            this.rb_aYear.TabIndex = 0;
            this.rb_aYear.TabStop = true;
            this.rb_aYear.Text = "א";
            this.rb_aYear.UseVisualStyleBackColor = true;
            this.rb_aYear.UseWaitCursor = true;
            // 
            // rb_aSemester
            // 
            this.rb_aSemester.AutoSize = true;
            this.rb_aSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_aSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_aSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_aSemester.Location = new System.Drawing.Point(355, 207);
            this.rb_aSemester.Name = "rb_aSemester";
            this.rb_aSemester.Size = new System.Drawing.Size(34, 20);
            this.rb_aSemester.TabIndex = 9;
            this.rb_aSemester.TabStop = true;
            this.rb_aSemester.Text = "א";
            this.rb_aSemester.UseVisualStyleBackColor = false;
            this.rb_aSemester.UseWaitCursor = true;
            // 
            // rb_bSemester
            // 
            this.rb_bSemester.AutoSize = true;
            this.rb_bSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_bSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_bSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_bSemester.Location = new System.Drawing.Point(295, 207);
            this.rb_bSemester.Name = "rb_bSemester";
            this.rb_bSemester.Size = new System.Drawing.Size(34, 20);
            this.rb_bSemester.TabIndex = 10;
            this.rb_bSemester.TabStop = true;
            this.rb_bSemester.Text = "ב";
            this.rb_bSemester.UseVisualStyleBackColor = false;
            this.rb_bSemester.UseWaitCursor = true;
            // 
            // rb_cSemester
            // 
            this.rb_cSemester.AutoSize = true;
            this.rb_cSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_cSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_cSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_cSemester.Location = new System.Drawing.Point(219, 207);
            this.rb_cSemester.Name = "rb_cSemester";
            this.rb_cSemester.Size = new System.Drawing.Size(46, 20);
            this.rb_cSemester.TabIndex = 11;
            this.rb_cSemester.TabStop = true;
            this.rb_cSemester.Text = "קיץ";
            this.rb_cSemester.UseVisualStyleBackColor = false;
            this.rb_cSemester.UseWaitCursor = true;
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(189, 120);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(203, 21);
            this.cb_department.TabIndex = 12;
            this.cb_department.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(344, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "ביטול";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(141, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "אישור";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
           this.pictureBox1.Image = Properties.Resources.Manager_Suit_Purple_Stripes_icon;
            this.pictureBox1.Location = new System.Drawing.Point(24, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 129);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // DeterminingCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.rb_cSemester);
            this.Controls.Add(this.rb_bSemester);
            this.Controls.Add(this.rb_aSemester);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_numOfLec);
            this.Controls.Add(this.tb_nameCoures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeterminingCourseDetails";
            this.Text = "הוספת קורס חדש";
            this.Load += new System.EventHandler(this.DeterminingCourseDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nameCoures;
        private System.Windows.Forms.TextBox tb_numOfLec;
        private System.Windows.Forms.RadioButton rb_dYear;
        private System.Windows.Forms.RadioButton rb_cYear;
        private System.Windows.Forms.RadioButton rb_bYear;
        private System.Windows.Forms.RadioButton rb_aYear;
        private System.Windows.Forms.RadioButton rb_aSemester;
        private System.Windows.Forms.RadioButton rb_bSemester;
        private System.Windows.Forms.RadioButton rb_cSemester;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
*/
namespace Schedule
{
    partial class DeterminingCourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeterminingCourseDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nameCoures = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_dYear = new System.Windows.Forms.RadioButton();
            this.rb_cYear = new System.Windows.Forms.RadioButton();
            this.rb_bYear = new System.Windows.Forms.RadioButton();
            this.rb_aYear = new System.Windows.Forms.RadioButton();
            this.rb_aSemester = new System.Windows.Forms.RadioButton();
            this.rb_bSemester = new System.Windows.Forms.RadioButton();
            this.rb_cSemester = new System.Windows.Forms.RadioButton();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_lec = new System.Windows.Forms.ComboBox();
            this.cb_tirgul = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת קורס חדש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם הקורס";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(454, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "מחלקה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(479, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "שנה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(454, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "סמסטר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(397, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "שעות להרצאה";
            // 
            // tb_nameCoures
            // 
            this.tb_nameCoures.Location = new System.Drawing.Point(189, 80);
            this.tb_nameCoures.Name = "tb_nameCoures";
            this.tb_nameCoures.Size = new System.Drawing.Size(203, 20);
            this.tb_nameCoures.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_dYear);
            this.groupBox1.Controls.Add(this.rb_cYear);
            this.groupBox1.Controls.Add(this.rb_bYear);
            this.groupBox1.Controls.Add(this.rb_aYear);
            this.groupBox1.Location = new System.Drawing.Point(120, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 29);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rb_dYear
            // 
            this.rb_dYear.AutoSize = true;
            this.rb_dYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_dYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_dYear.Location = new System.Drawing.Point(21, 8);
            this.rb_dYear.Name = "rb_dYear";
            this.rb_dYear.Size = new System.Drawing.Size(34, 20);
            this.rb_dYear.TabIndex = 3;
            this.rb_dYear.TabStop = true;
            this.rb_dYear.Text = "ד";
            this.rb_dYear.UseVisualStyleBackColor = true;
            // 
            // rb_cYear
            // 
            this.rb_cYear.AutoSize = true;
            this.rb_cYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_cYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_cYear.Location = new System.Drawing.Point(99, 6);
            this.rb_cYear.Name = "rb_cYear";
            this.rb_cYear.Size = new System.Drawing.Size(32, 20);
            this.rb_cYear.TabIndex = 2;
            this.rb_cYear.TabStop = true;
            this.rb_cYear.Text = "ג";
            this.rb_cYear.UseVisualStyleBackColor = true;
            // 
            // rb_bYear
            // 
            this.rb_bYear.AutoSize = true;
            this.rb_bYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_bYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_bYear.Location = new System.Drawing.Point(173, 6);
            this.rb_bYear.Name = "rb_bYear";
            this.rb_bYear.Size = new System.Drawing.Size(34, 20);
            this.rb_bYear.TabIndex = 1;
            this.rb_bYear.TabStop = true;
            this.rb_bYear.Text = "ב";
            this.rb_bYear.UseVisualStyleBackColor = true;
            // 
            // rb_aYear
            // 
            this.rb_aYear.AutoSize = true;
            this.rb_aYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_aYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_aYear.Location = new System.Drawing.Point(235, 7);
            this.rb_aYear.Name = "rb_aYear";
            this.rb_aYear.Size = new System.Drawing.Size(34, 20);
            this.rb_aYear.TabIndex = 0;
            this.rb_aYear.TabStop = true;
            this.rb_aYear.Text = "א";
            this.rb_aYear.UseVisualStyleBackColor = true;
            // 
            // rb_aSemester
            // 
            this.rb_aSemester.AutoSize = true;
            this.rb_aSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_aSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_aSemester.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_aSemester.Location = new System.Drawing.Point(355, 207);
            this.rb_aSemester.Name = "rb_aSemester";
            this.rb_aSemester.Size = new System.Drawing.Size(34, 20);
            this.rb_aSemester.TabIndex = 9;
            this.rb_aSemester.TabStop = true;
            this.rb_aSemester.Text = "א";
            this.rb_aSemester.UseVisualStyleBackColor = false;
            // 
            // rb_bSemester
            // 
            this.rb_bSemester.AutoSize = true;
            this.rb_bSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_bSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_bSemester.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_bSemester.Location = new System.Drawing.Point(293, 207);
            this.rb_bSemester.Name = "rb_bSemester";
            this.rb_bSemester.Size = new System.Drawing.Size(34, 20);
            this.rb_bSemester.TabIndex = 10;
            this.rb_bSemester.TabStop = true;
            this.rb_bSemester.Text = "ב";
            this.rb_bSemester.UseVisualStyleBackColor = false;
            // 
            // rb_cSemester
            // 
            this.rb_cSemester.AutoSize = true;
            this.rb_cSemester.BackColor = System.Drawing.Color.Transparent;
            this.rb_cSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rb_cSemester.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rb_cSemester.Location = new System.Drawing.Point(219, 207);
            this.rb_cSemester.Name = "rb_cSemester";
            this.rb_cSemester.Size = new System.Drawing.Size(46, 20);
            this.rb_cSemester.TabIndex = 11;
            this.rb_cSemester.TabStop = true;
            this.rb_cSemester.Text = "קיץ";
            this.rb_cSemester.UseVisualStyleBackColor = false;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(189, 120);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(203, 21);
            this.cb_department.TabIndex = 12;
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.cb_department_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Schedule.Properties.Resources.ביטל___ראש_מחלקה;
            this.button1.Location = new System.Drawing.Point(345, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::Schedule.Properties.Resources.אישור__ראש_מחלקה;
            this.button2.Location = new System.Drawing.Point(141, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 128);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cb_lec
            // 
            this.cb_lec.FormattingEnabled = true;
            this.cb_lec.Location = new System.Drawing.Point(189, 241);
            this.cb_lec.Name = "cb_lec";
            this.cb_lec.Size = new System.Drawing.Size(200, 21);
            this.cb_lec.TabIndex = 16;
            // 
            // cb_tirgul
            // 
            this.cb_tirgul.FormattingEnabled = true;
            this.cb_tirgul.Location = new System.Drawing.Point(189, 283);
            this.cb_tirgul.Name = "cb_tirgul";
            this.cb_tirgul.Size = new System.Drawing.Size(200, 21);
            this.cb_tirgul.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(407, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "שעות לתרגול";
            // 
            // DeterminingCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_ראש_מחלקה;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_tirgul);
            this.Controls.Add(this.cb_lec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.rb_cSemester);
            this.Controls.Add(this.rb_bSemester);
            this.Controls.Add(this.rb_aSemester);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_nameCoures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeterminingCourseDetails";
            this.Text = "הוספת קורס חדש";
            this.Load += new System.EventHandler(this.DeterminingCourseDetails_Load_2);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nameCoures;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_dYear;
        private System.Windows.Forms.RadioButton rb_cYear;
        private System.Windows.Forms.RadioButton rb_bYear;
        private System.Windows.Forms.RadioButton rb_aYear;
        private System.Windows.Forms.RadioButton rb_aSemester;
        private System.Windows.Forms.RadioButton rb_bSemester;
        private System.Windows.Forms.RadioButton rb_cSemester;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_lec;
        private System.Windows.Forms.ComboBox cb_tirgul;
        private System.Windows.Forms.Label label7;
    }
}