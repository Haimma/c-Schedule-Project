namespace Schedule
{
    partial class Requests_Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests_Check));
            this.lbl_StudentReq = new System.Windows.Forms.Label();
            this.cbo_ID_StudentReq = new System.Windows.Forms.ComboBox();
            this.lbl_ID_StudentReq = new System.Windows.Forms.Label();
            this.lbl_PName_StudentReq = new System.Windows.Forms.Label();
            this.txtB_PName_StudentReq = new System.Windows.Forms.TextBox();
            this.lbl_LName_StudentReq = new System.Windows.Forms.Label();
            this.txtB_LName_StudentReq = new System.Windows.Forms.TextBox();
            this.grpB_StudentReq = new System.Windows.Forms.GroupBox();
            this.txtB_StudentReq_Title = new System.Windows.Forms.TextBox();
            this.btn_StudentReq_Back = new System.Windows.Forms.Button();
            this.btn_StudentReq_Decline = new System.Windows.Forms.Button();
            this.btn_StudentReq_Confirm = new System.Windows.Forms.Button();
            this.lstB_StudentReq = new System.Windows.Forms.ListBox();
            this.pnl_LecTutReq = new System.Windows.Forms.Panel();
            this.pnl_Requests_Check = new System.Windows.Forms.Panel();
            this.btn_ReqCheck_Back = new System.Windows.Forms.Button();
            this.btn_StudentReq = new System.Windows.Forms.Button();
            this.btn_TutorReq = new System.Windows.Forms.Button();
            this.btn_LecturerReq = new System.Windows.Forms.Button();
            this.lbl_Requests_Check = new System.Windows.Forms.Label();
            this.grpB_LecTutReq = new System.Windows.Forms.GroupBox();
            this.txtB_LecTut_Title = new System.Windows.Forms.TextBox();
            this.btn_LecTutReq_Back = new System.Windows.Forms.Button();
            this.btn_LecTutReq_Deny = new System.Windows.Forms.Button();
            this.btn_LecTutReq_Confirm = new System.Windows.Forms.Button();
            this.lstB_LecTutReq = new System.Windows.Forms.ListBox();
            this.txtB_LecTutReq_LName = new System.Windows.Forms.TextBox();
            this.lbl_LecTut_LName = new System.Windows.Forms.Label();
            this.txtB_LecTut_PName = new System.Windows.Forms.TextBox();
            this.lbl_LecTutReq_PName = new System.Windows.Forms.Label();
            this.lbl_LecTutReq_ID = new System.Windows.Forms.Label();
            this.cbo_LecTutReq_ID = new System.Windows.Forms.ComboBox();
            this.lbl_LecTutReq = new System.Windows.Forms.Label();
            this.grpB_StudentReq.SuspendLayout();
            this.pnl_LecTutReq.SuspendLayout();
            this.pnl_Requests_Check.SuspendLayout();
            this.grpB_LecTutReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_StudentReq
            // 
            this.lbl_StudentReq.AutoSize = true;
            this.lbl_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_StudentReq.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_StudentReq.Image = global::Schedule.Properties.Resources.strok_מזכירה;
            this.lbl_StudentReq.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_StudentReq.Location = new System.Drawing.Point(184, 8);
            this.lbl_StudentReq.Name = "lbl_StudentReq";
            this.lbl_StudentReq.Size = new System.Drawing.Size(388, 63);
            this.lbl_StudentReq.TabIndex = 0;
            this.lbl_StudentReq.Text = "בקשות סטודנטים";
            this.lbl_StudentReq.Click += new System.EventHandler(this.lbl_StudentCourse_Click);
            // 
            // cbo_ID_StudentReq
            // 
            this.cbo_ID_StudentReq.FormattingEnabled = true;
            this.cbo_ID_StudentReq.Location = new System.Drawing.Point(581, 93);
            this.cbo_ID_StudentReq.Name = "cbo_ID_StudentReq";
            this.cbo_ID_StudentReq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbo_ID_StudentReq.Size = new System.Drawing.Size(121, 28);
            this.cbo_ID_StudentReq.TabIndex = 1;
            this.cbo_ID_StudentReq.SelectedIndexChanged += new System.EventHandler(this.cbo_ID_StudentReq_SelectedIndexChanged);
            // 
            // lbl_ID_StudentReq
            // 
            this.lbl_ID_StudentReq.AutoSize = true;
            this.lbl_ID_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ID_StudentReq.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_ID_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_ID_StudentReq.Location = new System.Drawing.Point(708, 83);
            this.lbl_ID_StudentReq.Name = "lbl_ID_StudentReq";
            this.lbl_ID_StudentReq.Size = new System.Drawing.Size(59, 37);
            this.lbl_ID_StudentReq.TabIndex = 2;
            this.lbl_ID_StudentReq.Text = ".ת.ז";
            // 
            // lbl_PName_StudentReq
            // 
            this.lbl_PName_StudentReq.AutoSize = true;
            this.lbl_PName_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PName_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_PName_StudentReq.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_PName_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_PName_StudentReq.Location = new System.Drawing.Point(448, 83);
            this.lbl_PName_StudentReq.Name = "lbl_PName_StudentReq";
            this.lbl_PName_StudentReq.Size = new System.Drawing.Size(120, 37);
            this.lbl_PName_StudentReq.TabIndex = 3;
            this.lbl_PName_StudentReq.Text = "שם פרטי";
            // 
            // txtB_PName_StudentReq
            // 
            this.txtB_PName_StudentReq.Location = new System.Drawing.Point(342, 94);
            this.txtB_PName_StudentReq.Name = "txtB_PName_StudentReq";
            this.txtB_PName_StudentReq.Size = new System.Drawing.Size(100, 26);
            this.txtB_PName_StudentReq.TabIndex = 4;
            // 
            // lbl_LName_StudentReq
            // 
            this.lbl_LName_StudentReq.AutoSize = true;
            this.lbl_LName_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LName_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LName_StudentReq.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_LName_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_LName_StudentReq.Location = new System.Drawing.Point(173, 83);
            this.lbl_LName_StudentReq.Name = "lbl_LName_StudentReq";
            this.lbl_LName_StudentReq.Size = new System.Drawing.Size(150, 37);
            this.lbl_LName_StudentReq.TabIndex = 5;
            this.lbl_LName_StudentReq.Text = "שם משפחה";
            // 
            // txtB_LName_StudentReq
            // 
            this.txtB_LName_StudentReq.Location = new System.Drawing.Point(67, 94);
            this.txtB_LName_StudentReq.Name = "txtB_LName_StudentReq";
            this.txtB_LName_StudentReq.Size = new System.Drawing.Size(100, 26);
            this.txtB_LName_StudentReq.TabIndex = 6;
            // 
            // grpB_StudentReq
            // 
            this.grpB_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.grpB_StudentReq.Controls.Add(this.txtB_StudentReq_Title);
            this.grpB_StudentReq.Controls.Add(this.btn_StudentReq_Back);
            this.grpB_StudentReq.Controls.Add(this.btn_StudentReq_Decline);
            this.grpB_StudentReq.Controls.Add(this.btn_StudentReq_Confirm);
            this.grpB_StudentReq.Controls.Add(this.lstB_StudentReq);
            this.grpB_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpB_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.grpB_StudentReq.Location = new System.Drawing.Point(69, 127);
            this.grpB_StudentReq.Name = "grpB_StudentReq";
            this.grpB_StudentReq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpB_StudentReq.Size = new System.Drawing.Size(655, 306);
            this.grpB_StudentReq.TabIndex = 7;
            this.grpB_StudentReq.TabStop = false;
            this.grpB_StudentReq.Text = "בקשות";
            // 
            // txtB_StudentReq_Title
            // 
            this.txtB_StudentReq_Title.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtB_StudentReq_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_StudentReq_Title.ForeColor = System.Drawing.SystemColors.Window;
            this.txtB_StudentReq_Title.Location = new System.Drawing.Point(6, 25);
            this.txtB_StudentReq_Title.Name = "txtB_StudentReq_Title";
            this.txtB_StudentReq_Title.Size = new System.Drawing.Size(643, 26);
            this.txtB_StudentReq_Title.TabIndex = 3;
            this.txtB_StudentReq_Title.TextChanged += new System.EventHandler(this.txtB_StudentReq_Title_TextChanged);
            // 
            // btn_StudentReq_Back
            // 
            this.btn_StudentReq_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_StudentReq_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StudentReq_Back.BackgroundImage")));
            this.btn_StudentReq_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StudentReq_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StudentReq_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentReq_Back.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_StudentReq_Back.Location = new System.Drawing.Point(6, 224);
            this.btn_StudentReq_Back.Name = "btn_StudentReq_Back";
            this.btn_StudentReq_Back.Size = new System.Drawing.Size(198, 59);
            this.btn_StudentReq_Back.TabIndex = 8;
            this.btn_StudentReq_Back.Text = "חזור";
            this.btn_StudentReq_Back.UseVisualStyleBackColor = false;
            this.btn_StudentReq_Back.Click += new System.EventHandler(this.btn_StudentReq_Back_Click);
            // 
            // btn_StudentReq_Decline
            // 
            this.btn_StudentReq_Decline.BackColor = System.Drawing.Color.Transparent;
            this.btn_StudentReq_Decline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StudentReq_Decline.BackgroundImage")));
            this.btn_StudentReq_Decline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StudentReq_Decline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StudentReq_Decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentReq_Decline.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_StudentReq_Decline.Location = new System.Drawing.Point(209, 224);
            this.btn_StudentReq_Decline.Name = "btn_StudentReq_Decline";
            this.btn_StudentReq_Decline.Size = new System.Drawing.Size(216, 59);
            this.btn_StudentReq_Decline.TabIndex = 2;
            this.btn_StudentReq_Decline.Text = "דחיית בקשה";
            this.btn_StudentReq_Decline.UseVisualStyleBackColor = false;
            this.btn_StudentReq_Decline.Click += new System.EventHandler(this.btn_StudentReq_Decline_Click);
            // 
            // btn_StudentReq_Confirm
            // 
            this.btn_StudentReq_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_StudentReq_Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StudentReq_Confirm.BackgroundImage")));
            this.btn_StudentReq_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StudentReq_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StudentReq_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentReq_Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_StudentReq_Confirm.Location = new System.Drawing.Point(433, 223);
            this.btn_StudentReq_Confirm.Name = "btn_StudentReq_Confirm";
            this.btn_StudentReq_Confirm.Size = new System.Drawing.Size(216, 60);
            this.btn_StudentReq_Confirm.TabIndex = 1;
            this.btn_StudentReq_Confirm.Text = "אישור בקשה";
            this.btn_StudentReq_Confirm.UseVisualStyleBackColor = false;
            this.btn_StudentReq_Confirm.Click += new System.EventHandler(this.btn_StudentReq_Confirm_Click);
            // 
            // lstB_StudentReq
            // 
            this.lstB_StudentReq.FormattingEnabled = true;
            this.lstB_StudentReq.ItemHeight = 20;
            this.lstB_StudentReq.Location = new System.Drawing.Point(6, 54);
            this.lstB_StudentReq.Name = "lstB_StudentReq";
            this.lstB_StudentReq.Size = new System.Drawing.Size(642, 164);
            this.lstB_StudentReq.TabIndex = 0;
            // 
            // pnl_LecTutReq
            // 
            this.pnl_LecTutReq.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_מזכירה;
            this.pnl_LecTutReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_LecTutReq.Controls.Add(this.pnl_Requests_Check);
            this.pnl_LecTutReq.Controls.Add(this.grpB_LecTutReq);
            this.pnl_LecTutReq.Controls.Add(this.txtB_LecTutReq_LName);
            this.pnl_LecTutReq.Controls.Add(this.lbl_LecTut_LName);
            this.pnl_LecTutReq.Controls.Add(this.txtB_LecTut_PName);
            this.pnl_LecTutReq.Controls.Add(this.lbl_LecTutReq_PName);
            this.pnl_LecTutReq.Controls.Add(this.lbl_LecTutReq_ID);
            this.pnl_LecTutReq.Controls.Add(this.cbo_LecTutReq_ID);
            this.pnl_LecTutReq.Controls.Add(this.lbl_LecTutReq);
            this.pnl_LecTutReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LecTutReq.Location = new System.Drawing.Point(0, 0);
            this.pnl_LecTutReq.Name = "pnl_LecTutReq";
            this.pnl_LecTutReq.Size = new System.Drawing.Size(772, 445);
            this.pnl_LecTutReq.TabIndex = 9;
            // 
            // pnl_Requests_Check
            // 
            this.pnl_Requests_Check.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_מזכירה;
            this.pnl_Requests_Check.Controls.Add(this.btn_ReqCheck_Back);
            this.pnl_Requests_Check.Controls.Add(this.btn_StudentReq);
            this.pnl_Requests_Check.Controls.Add(this.btn_TutorReq);
            this.pnl_Requests_Check.Controls.Add(this.btn_LecturerReq);
            this.pnl_Requests_Check.Controls.Add(this.lbl_Requests_Check);
            this.pnl_Requests_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Requests_Check.Location = new System.Drawing.Point(0, 0);
            this.pnl_Requests_Check.Name = "pnl_Requests_Check";
            this.pnl_Requests_Check.Size = new System.Drawing.Size(772, 445);
            this.pnl_Requests_Check.TabIndex = 17;
            // 
            // btn_ReqCheck_Back
            // 
            this.btn_ReqCheck_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_ReqCheck_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReqCheck_Back.BackgroundImage")));
            this.btn_ReqCheck_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ReqCheck_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReqCheck_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReqCheck_Back.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ReqCheck_Back.Location = new System.Drawing.Point(382, 312);
            this.btn_ReqCheck_Back.Name = "btn_ReqCheck_Back";
            this.btn_ReqCheck_Back.Size = new System.Drawing.Size(271, 77);
            this.btn_ReqCheck_Back.TabIndex = 4;
            this.btn_ReqCheck_Back.Text = "חזור";
            this.btn_ReqCheck_Back.UseVisualStyleBackColor = false;
            this.btn_ReqCheck_Back.Click += new System.EventHandler(this.btn_ReqCheck_Back_Click);
            // 
            // btn_StudentReq
            // 
            this.btn_StudentReq.BackColor = System.Drawing.Color.Transparent;
            this.btn_StudentReq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StudentReq.BackgroundImage")));
            this.btn_StudentReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StudentReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StudentReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentReq.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_StudentReq.Location = new System.Drawing.Point(382, 217);
            this.btn_StudentReq.Name = "btn_StudentReq";
            this.btn_StudentReq.Size = new System.Drawing.Size(271, 71);
            this.btn_StudentReq.TabIndex = 3;
            this.btn_StudentReq.Text = "בקשות סטודנטים";
            this.btn_StudentReq.UseVisualStyleBackColor = false;
            this.btn_StudentReq.Click += new System.EventHandler(this.btn_StudentReq_Click);
            // 
            // btn_TutorReq
            // 
            this.btn_TutorReq.BackColor = System.Drawing.Color.Transparent;
            this.btn_TutorReq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TutorReq.BackgroundImage")));
            this.btn_TutorReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_TutorReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TutorReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TutorReq.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_TutorReq.Location = new System.Drawing.Point(382, 150);
            this.btn_TutorReq.Name = "btn_TutorReq";
            this.btn_TutorReq.Size = new System.Drawing.Size(271, 71);
            this.btn_TutorReq.TabIndex = 2;
            this.btn_TutorReq.Text = "בקשות מתרגלים";
            this.btn_TutorReq.UseVisualStyleBackColor = false;
            this.btn_TutorReq.Click += new System.EventHandler(this.btn_TutorReq_Click);
            // 
            // btn_LecturerReq
            // 
            this.btn_LecturerReq.BackColor = System.Drawing.Color.Transparent;
            this.btn_LecturerReq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LecturerReq.BackgroundImage")));
            this.btn_LecturerReq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LecturerReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LecturerReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LecturerReq.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_LecturerReq.Location = new System.Drawing.Point(382, 89);
            this.btn_LecturerReq.Name = "btn_LecturerReq";
            this.btn_LecturerReq.Size = new System.Drawing.Size(271, 70);
            this.btn_LecturerReq.TabIndex = 1;
            this.btn_LecturerReq.Text = "בקשות מרצים";
            this.btn_LecturerReq.UseVisualStyleBackColor = false;
            this.btn_LecturerReq.Click += new System.EventHandler(this.btn_LecturerReq_Click);
            // 
            // lbl_Requests_Check
            // 
            this.lbl_Requests_Check.AutoSize = true;
            this.lbl_Requests_Check.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Requests_Check.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Requests_Check.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Requests_Check.Image = global::Schedule.Properties.Resources.strok_מזכירה;
            this.lbl_Requests_Check.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Requests_Check.Location = new System.Drawing.Point(183, 12);
            this.lbl_Requests_Check.Name = "lbl_Requests_Check";
            this.lbl_Requests_Check.Size = new System.Drawing.Size(313, 63);
            this.lbl_Requests_Check.TabIndex = 0;
            this.lbl_Requests_Check.Text = "בחינת בקשות";
            // 
            // grpB_LecTutReq
            // 
            this.grpB_LecTutReq.BackColor = System.Drawing.Color.Transparent;
            this.grpB_LecTutReq.Controls.Add(this.txtB_LecTut_Title);
            this.grpB_LecTutReq.Controls.Add(this.btn_LecTutReq_Back);
            this.grpB_LecTutReq.Controls.Add(this.btn_LecTutReq_Deny);
            this.grpB_LecTutReq.Controls.Add(this.btn_LecTutReq_Confirm);
            this.grpB_LecTutReq.Controls.Add(this.lstB_LecTutReq);
            this.grpB_LecTutReq.ForeColor = System.Drawing.SystemColors.Window;
            this.grpB_LecTutReq.Location = new System.Drawing.Point(47, 138);
            this.grpB_LecTutReq.Name = "grpB_LecTutReq";
            this.grpB_LecTutReq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpB_LecTutReq.Size = new System.Drawing.Size(722, 283);
            this.grpB_LecTutReq.TabIndex = 15;
            this.grpB_LecTutReq.TabStop = false;
            this.grpB_LecTutReq.Text = "בקשות";
            // 
            // txtB_LecTut_Title
            // 
            this.txtB_LecTut_Title.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtB_LecTut_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_LecTut_Title.ForeColor = System.Drawing.SystemColors.Window;
            this.txtB_LecTut_Title.Location = new System.Drawing.Point(249, 25);
            this.txtB_LecTut_Title.Name = "txtB_LecTut_Title";
            this.txtB_LecTut_Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtB_LecTut_Title.Size = new System.Drawing.Size(462, 26);
            this.txtB_LecTut_Title.TabIndex = 3;
            // 
            // btn_LecTutReq_Back
            // 
            this.btn_LecTutReq_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LecTutReq_Back.BackgroundImage")));
            this.btn_LecTutReq_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LecTutReq_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LecTutReq_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LecTutReq_Back.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_LecTutReq_Back.Location = new System.Drawing.Point(6, 199);
            this.btn_LecTutReq_Back.Name = "btn_LecTutReq_Back";
            this.btn_LecTutReq_Back.Size = new System.Drawing.Size(237, 67);
            this.btn_LecTutReq_Back.TabIndex = 16;
            this.btn_LecTutReq_Back.Text = "חזור";
            this.btn_LecTutReq_Back.UseVisualStyleBackColor = true;
            this.btn_LecTutReq_Back.Click += new System.EventHandler(this.btn_LecTutReq_Back_Click);
            // 
            // btn_LecTutReq_Deny
            // 
            this.btn_LecTutReq_Deny.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LecTutReq_Deny.BackgroundImage")));
            this.btn_LecTutReq_Deny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LecTutReq_Deny.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LecTutReq_Deny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LecTutReq_Deny.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_LecTutReq_Deny.Location = new System.Drawing.Point(6, 97);
            this.btn_LecTutReq_Deny.Name = "btn_LecTutReq_Deny";
            this.btn_LecTutReq_Deny.Size = new System.Drawing.Size(237, 65);
            this.btn_LecTutReq_Deny.TabIndex = 2;
            this.btn_LecTutReq_Deny.Text = "דחיית בקשה";
            this.btn_LecTutReq_Deny.UseVisualStyleBackColor = true;
            this.btn_LecTutReq_Deny.Click += new System.EventHandler(this.btn_LecTutReq_Deny_Click);
            // 
            // btn_LecTutReq_Confirm
            // 
            this.btn_LecTutReq_Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LecTutReq_Confirm.BackgroundImage")));
            this.btn_LecTutReq_Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LecTutReq_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LecTutReq_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LecTutReq_Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_LecTutReq_Confirm.Location = new System.Drawing.Point(6, 25);
            this.btn_LecTutReq_Confirm.Name = "btn_LecTutReq_Confirm";
            this.btn_LecTutReq_Confirm.Size = new System.Drawing.Size(237, 66);
            this.btn_LecTutReq_Confirm.TabIndex = 1;
            this.btn_LecTutReq_Confirm.Text = "אישור בקשה";
            this.btn_LecTutReq_Confirm.UseVisualStyleBackColor = true;
            this.btn_LecTutReq_Confirm.Click += new System.EventHandler(this.btn_LecTutReq_Confirm_Click);
            // 
            // lstB_LecTutReq
            // 
            this.lstB_LecTutReq.FormattingEnabled = true;
            this.lstB_LecTutReq.ItemHeight = 20;
            this.lstB_LecTutReq.Location = new System.Drawing.Point(249, 52);
            this.lstB_LecTutReq.Name = "lstB_LecTutReq";
            this.lstB_LecTutReq.Size = new System.Drawing.Size(462, 204);
            this.lstB_LecTutReq.TabIndex = 0;
            // 
            // txtB_LecTutReq_LName
            // 
            this.txtB_LecTutReq_LName.Location = new System.Drawing.Point(49, 100);
            this.txtB_LecTutReq_LName.Name = "txtB_LecTutReq_LName";
            this.txtB_LecTutReq_LName.Size = new System.Drawing.Size(100, 26);
            this.txtB_LecTutReq_LName.TabIndex = 14;
            // 
            // lbl_LecTut_LName
            // 
            this.lbl_LecTut_LName.AutoSize = true;
            this.lbl_LecTut_LName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LecTut_LName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LecTut_LName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_LecTut_LName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_LecTut_LName.Location = new System.Drawing.Point(155, 85);
            this.lbl_LecTut_LName.Name = "lbl_LecTut_LName";
            this.lbl_LecTut_LName.Size = new System.Drawing.Size(150, 37);
            this.lbl_LecTut_LName.TabIndex = 13;
            this.lbl_LecTut_LName.Text = "שם משפחה";
            // 
            // txtB_LecTut_PName
            // 
            this.txtB_LecTut_PName.Location = new System.Drawing.Point(324, 100);
            this.txtB_LecTut_PName.Name = "txtB_LecTut_PName";
            this.txtB_LecTut_PName.Size = new System.Drawing.Size(100, 26);
            this.txtB_LecTut_PName.TabIndex = 12;
            // 
            // lbl_LecTutReq_PName
            // 
            this.lbl_LecTutReq_PName.AutoSize = true;
            this.lbl_LecTutReq_PName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LecTutReq_PName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LecTutReq_PName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_LecTutReq_PName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_LecTutReq_PName.Location = new System.Drawing.Point(430, 85);
            this.lbl_LecTutReq_PName.Name = "lbl_LecTutReq_PName";
            this.lbl_LecTutReq_PName.Size = new System.Drawing.Size(120, 37);
            this.lbl_LecTutReq_PName.TabIndex = 11;
            this.lbl_LecTutReq_PName.Text = "שם פרטי";
            // 
            // lbl_LecTutReq_ID
            // 
            this.lbl_LecTutReq_ID.AutoSize = true;
            this.lbl_LecTutReq_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LecTutReq_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LecTutReq_ID.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_LecTutReq_ID.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_LecTutReq_ID.Location = new System.Drawing.Point(685, 85);
            this.lbl_LecTutReq_ID.Name = "lbl_LecTutReq_ID";
            this.lbl_LecTutReq_ID.Size = new System.Drawing.Size(59, 37);
            this.lbl_LecTutReq_ID.TabIndex = 10;
            this.lbl_LecTutReq_ID.Text = ".ת.ז";
            // 
            // cbo_LecTutReq_ID
            // 
            this.cbo_LecTutReq_ID.FormattingEnabled = true;
            this.cbo_LecTutReq_ID.Location = new System.Drawing.Point(558, 99);
            this.cbo_LecTutReq_ID.Name = "cbo_LecTutReq_ID";
            this.cbo_LecTutReq_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbo_LecTutReq_ID.Size = new System.Drawing.Size(121, 28);
            this.cbo_LecTutReq_ID.TabIndex = 9;
            this.cbo_LecTutReq_ID.SelectedIndexChanged += new System.EventHandler(this.cbo_LecTutReq_ID_SelectedIndexChanged);
            // 
            // lbl_LecTutReq
            // 
            this.lbl_LecTutReq.AutoSize = true;
            this.lbl_LecTutReq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LecTutReq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_LecTutReq.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_LecTutReq.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_LecTutReq.Location = new System.Drawing.Point(247, 9);
            this.lbl_LecTutReq.Name = "lbl_LecTutReq";
            this.lbl_LecTutReq.Size = new System.Drawing.Size(320, 63);
            this.lbl_LecTutReq.TabIndex = 0;
            this.lbl_LecTutReq.Text = "בקשות מרצים";
            // 
            // Requests_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Schedule.Properties.Resources.backgrounds_מזכירה;
            this.ClientSize = new System.Drawing.Size(772, 445);
            this.Controls.Add(this.pnl_LecTutReq);
            this.Controls.Add(this.grpB_StudentReq);
            this.Controls.Add(this.txtB_LName_StudentReq);
            this.Controls.Add(this.lbl_LName_StudentReq);
            this.Controls.Add(this.txtB_PName_StudentReq);
            this.Controls.Add(this.lbl_PName_StudentReq);
            this.Controls.Add(this.lbl_ID_StudentReq);
            this.Controls.Add(this.cbo_ID_StudentReq);
            this.Controls.Add(this.lbl_StudentReq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Requests_Check";
            this.Text = "Requests_Check";
            this.grpB_StudentReq.ResumeLayout(false);
            this.grpB_StudentReq.PerformLayout();
            this.pnl_LecTutReq.ResumeLayout(false);
            this.pnl_LecTutReq.PerformLayout();
            this.pnl_Requests_Check.ResumeLayout(false);
            this.pnl_Requests_Check.PerformLayout();
            this.grpB_LecTutReq.ResumeLayout(false);
            this.grpB_LecTutReq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentReq;
        private System.Windows.Forms.ComboBox cbo_ID_StudentReq;
        private System.Windows.Forms.Label lbl_ID_StudentReq;
        private System.Windows.Forms.Label lbl_PName_StudentReq;
        private System.Windows.Forms.TextBox txtB_PName_StudentReq;
        private System.Windows.Forms.Label lbl_LName_StudentReq;
        private System.Windows.Forms.TextBox txtB_LName_StudentReq;
        private System.Windows.Forms.GroupBox grpB_StudentReq;
        private System.Windows.Forms.Button btn_StudentReq_Decline;
        private System.Windows.Forms.Button btn_StudentReq_Confirm;
        private System.Windows.Forms.ListBox lstB_StudentReq;
        private System.Windows.Forms.Button btn_StudentReq_Back;
        private System.Windows.Forms.Panel pnl_LecTutReq;
        private System.Windows.Forms.Panel pnl_Requests_Check;
        private System.Windows.Forms.Button btn_ReqCheck_Back;
        private System.Windows.Forms.Button btn_StudentReq;
        private System.Windows.Forms.Button btn_TutorReq;
        private System.Windows.Forms.Button btn_LecturerReq;
        private System.Windows.Forms.Label lbl_Requests_Check;
        private System.Windows.Forms.Button btn_LecTutReq_Back;
        private System.Windows.Forms.GroupBox grpB_LecTutReq;
        private System.Windows.Forms.Button btn_LecTutReq_Deny;
        private System.Windows.Forms.Button btn_LecTutReq_Confirm;
        private System.Windows.Forms.ListBox lstB_LecTutReq;
        private System.Windows.Forms.TextBox txtB_LecTutReq_LName;
        private System.Windows.Forms.Label lbl_LecTut_LName;
        private System.Windows.Forms.TextBox txtB_LecTut_PName;
        private System.Windows.Forms.Label lbl_LecTutReq_PName;
        private System.Windows.Forms.Label lbl_LecTutReq_ID;
        private System.Windows.Forms.ComboBox cbo_LecTutReq_ID;
        private System.Windows.Forms.Label lbl_LecTutReq;
        private System.Windows.Forms.TextBox txtB_LecTut_Title;
        private System.Windows.Forms.TextBox txtB_StudentReq_Title;
    }
}