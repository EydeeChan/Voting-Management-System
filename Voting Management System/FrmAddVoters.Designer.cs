namespace Voting_Management_System
{
    partial class FrmAddVoters
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddVoters));
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAddPosition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblvotersrid = new System.Windows.Forms.Label();
            this.TxtMiddleName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGrade = new MetroFramework.Controls.MetroComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtStrand = new MetroFramework.Controls.MetroComboBox();
            this.TxtTrack = new MetroFramework.Controls.MetroComboBox();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.lblvotersid = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(799, 5);
            this.panel6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 226;
            this.label8.Text = "Add Voter";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Active = false;
            this.BtnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancel.BorderRadius = 5;
            this.BtnCancel.ButtonText = "Cancel";
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCancel.Iconimage = null;
            this.BtnCancel.Iconimage_right = null;
            this.BtnCancel.Iconimage_right_Selected = null;
            this.BtnCancel.Iconimage_Selected = null;
            this.BtnCancel.IconMarginLeft = 0;
            this.BtnCancel.IconMarginRight = 0;
            this.BtnCancel.IconRightVisible = true;
            this.BtnCancel.IconRightZoom = 0D;
            this.BtnCancel.IconVisible = true;
            this.BtnCancel.IconZoom = 90D;
            this.BtnCancel.IsTab = false;
            this.BtnCancel.Location = new System.Drawing.Point(651, 418);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(117)))), ((int)(((byte)(94)))));
            this.BtnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancel.selected = false;
            this.BtnCancel.Size = new System.Drawing.Size(129, 33);
            this.BtnCancel.TabIndex = 261;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.Textcolor = System.Drawing.Color.White;
            this.BtnCancel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddPosition
            // 
            this.BtnAddPosition.Active = false;
            this.BtnAddPosition.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAddPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnAddPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddPosition.BorderRadius = 5;
            this.BtnAddPosition.ButtonText = "Add Voter";
            this.BtnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddPosition.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAddPosition.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAddPosition.Iconimage = null;
            this.BtnAddPosition.Iconimage_right = null;
            this.BtnAddPosition.Iconimage_right_Selected = null;
            this.BtnAddPosition.Iconimage_Selected = null;
            this.BtnAddPosition.IconMarginLeft = 0;
            this.BtnAddPosition.IconMarginRight = 0;
            this.BtnAddPosition.IconRightVisible = true;
            this.BtnAddPosition.IconRightZoom = 0D;
            this.BtnAddPosition.IconVisible = true;
            this.BtnAddPosition.IconZoom = 90D;
            this.BtnAddPosition.IsTab = false;
            this.BtnAddPosition.Location = new System.Drawing.Point(516, 418);
            this.BtnAddPosition.Name = "BtnAddPosition";
            this.BtnAddPosition.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnAddPosition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnAddPosition.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAddPosition.selected = false;
            this.BtnAddPosition.Size = new System.Drawing.Size(129, 33);
            this.BtnAddPosition.TabIndex = 260;
            this.BtnAddPosition.Text = "Add Voter";
            this.BtnAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddPosition.Textcolor = System.Drawing.Color.White;
            this.BtnAddPosition.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddPosition.Click += new System.EventHandler(this.BtnAddPosition_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Active = false;
            this.BtnChangePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChangePassword.BorderRadius = 5;
            this.BtnChangePassword.ButtonText = "Edit Voter";
            this.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.BtnChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnChangePassword.Iconimage = null;
            this.BtnChangePassword.Iconimage_right = null;
            this.BtnChangePassword.Iconimage_right_Selected = null;
            this.BtnChangePassword.Iconimage_Selected = null;
            this.BtnChangePassword.IconMarginLeft = 0;
            this.BtnChangePassword.IconMarginRight = 0;
            this.BtnChangePassword.IconRightVisible = true;
            this.BtnChangePassword.IconRightZoom = 0D;
            this.BtnChangePassword.IconVisible = true;
            this.BtnChangePassword.IconZoom = 90D;
            this.BtnChangePassword.IsTab = false;
            this.BtnChangePassword.Location = new System.Drawing.Point(516, 418);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnChangePassword.selected = false;
            this.BtnChangePassword.Size = new System.Drawing.Size(129, 33);
            this.BtnChangePassword.TabIndex = 262;
            this.BtnChangePassword.Text = "Edit Voter";
            this.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChangePassword.Textcolor = System.Drawing.Color.White;
            this.BtnChangePassword.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // lblvotersrid
            // 
            this.lblvotersrid.AutoSize = true;
            this.lblvotersrid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvotersrid.ForeColor = System.Drawing.Color.DimGray;
            this.lblvotersrid.Location = new System.Drawing.Point(12, 462);
            this.lblvotersrid.Name = "lblvotersrid";
            this.lblvotersrid.Size = new System.Drawing.Size(80, 20);
            this.lblvotersrid.TabIndex = 265;
            this.lblvotersrid.Text = "First Name";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.Depth = 0;
            this.TxtMiddleName.Hint = "";
            this.TxtMiddleName.Location = new System.Drawing.Point(542, 113);
            this.TxtMiddleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.PasswordChar = '\0';
            this.TxtMiddleName.SelectedText = "";
            this.TxtMiddleName.SelectionLength = 0;
            this.TxtMiddleName.SelectionStart = 0;
            this.TxtMiddleName.Size = new System.Drawing.Size(220, 23);
            this.TxtMiddleName.TabIndex = 272;
            this.TxtMiddleName.Text = "E.G. ALONSO REALONDA";
            this.TxtMiddleName.UseSystemPasswordChar = false;
            this.TxtMiddleName.Enter += new System.EventHandler(this.TxtStudentMName_Enter);
            this.TxtMiddleName.Leave += new System.EventHandler(this.TxtStudentMName_Leave);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Depth = 0;
            this.TxtFirstName.Hint = "";
            this.TxtFirstName.Location = new System.Drawing.Point(292, 113);
            this.TxtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.PasswordChar = '\0';
            this.TxtFirstName.SelectedText = "";
            this.TxtFirstName.SelectionLength = 0;
            this.TxtFirstName.SelectionStart = 0;
            this.TxtFirstName.Size = new System.Drawing.Size(220, 23);
            this.TxtFirstName.TabIndex = 271;
            this.TxtFirstName.Text = "E.G. JOSE PROTASIO JR.";
            this.TxtFirstName.UseSystemPasswordChar = false;
            this.TxtFirstName.Enter += new System.EventHandler(this.TxtStudentFName_Enter);
            this.TxtFirstName.Leave += new System.EventHandler(this.TxtStudentFName_Leave);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Depth = 0;
            this.TxtLastName.Hint = "";
            this.TxtLastName.Location = new System.Drawing.Point(33, 113);
            this.TxtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.PasswordChar = '\0';
            this.TxtLastName.SelectedText = "";
            this.TxtLastName.SelectionLength = 0;
            this.TxtLastName.SelectionStart = 0;
            this.TxtLastName.Size = new System.Drawing.Size(220, 23);
            this.TxtLastName.TabIndex = 270;
            this.TxtLastName.Text = "E.G. MERCADO RIZAL";
            this.TxtLastName.UseSystemPasswordChar = false;
            this.TxtLastName.Enter += new System.EventHandler(this.TxtStudentLName_Enter);
            this.TxtLastName.Leave += new System.EventHandler(this.TxtStudentLName_Leave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DimGray;
            this.label31.Location = new System.Drawing.Point(289, 139);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(200, 17);
            this.label31.TabIndex = 269;
            this.label31.Text = "Include suffix name on first name";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(289, 89);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 17);
            this.label30.TabIndex = 268;
            this.label30.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 267;
            this.label4.Text = "Last Name";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(539, 89);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 17);
            this.label32.TabIndex = 266;
            this.label32.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 278;
            this.label1.Text = "Grade";
            // 
            // TxtGrade
            // 
            this.TxtGrade.FormattingEnabled = true;
            this.TxtGrade.ItemHeight = 23;
            this.TxtGrade.Items.AddRange(new object[] {
            "11",
            "12"});
            this.TxtGrade.Location = new System.Drawing.Point(33, 224);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(121, 29);
            this.TxtGrade.TabIndex = 277;
            this.TxtGrade.UseSelectable = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(554, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 276;
            this.label12.Text = "Strand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(295, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 275;
            this.label11.Text = "Track";
            // 
            // TxtStrand
            // 
            this.TxtStrand.FormattingEnabled = true;
            this.TxtStrand.ItemHeight = 23;
            this.TxtStrand.Location = new System.Drawing.Point(557, 224);
            this.TxtStrand.Name = "TxtStrand";
            this.TxtStrand.Size = new System.Drawing.Size(121, 29);
            this.TxtStrand.TabIndex = 274;
            this.TxtStrand.UseSelectable = true;
            // 
            // TxtTrack
            // 
            this.TxtTrack.FormattingEnabled = true;
            this.TxtTrack.ItemHeight = 23;
            this.TxtTrack.Location = new System.Drawing.Point(298, 224);
            this.TxtTrack.Name = "TxtTrack";
            this.TxtTrack.Size = new System.Drawing.Size(121, 29);
            this.TxtTrack.TabIndex = 273;
            this.TxtTrack.UseSelectable = true;
            this.TxtTrack.SelectedIndexChanged += new System.EventHandler(this.TxtTrack_SelectedIndexChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(33, 338);
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(220, 23);
            this.TxtUsername.TabIndex = 280;
            this.TxtUsername.UseSystemPasswordChar = false;
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 279;
            this.label2.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(292, 338);
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(220, 23);
            this.TxtPassword.TabIndex = 282;
            this.TxtPassword.UseSystemPasswordChar = false;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(289, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 281;
            this.label3.Text = "Password";
            // 
            // lblvotersid
            // 
            this.lblvotersid.AutoSize = true;
            this.lblvotersid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvotersid.ForeColor = System.Drawing.Color.Black;
            this.lblvotersid.Location = new System.Drawing.Point(106, 473);
            this.lblvotersid.Name = "lblvotersid";
            this.lblvotersid.Size = new System.Drawing.Size(69, 17);
            this.lblvotersid.TabIndex = 283;
            this.lblvotersid.Text = "Username";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.BtnChangePassword;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.BtnAddPosition;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.BtnCancel;
            // 
            // FrmAddVoters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 463);
            this.Controls.Add(this.lblvotersid);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtStrand);
            this.Controls.Add(this.TxtTrack);
            this.Controls.Add(this.TxtMiddleName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.lblvotersrid);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddPosition);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddVoters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddVoters";
            this.Load += new System.EventHandler(this.FrmAddVoters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel6;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCancel;
        public Bunifu.Framework.UI.BunifuFlatButton BtnAddPosition;
        public Bunifu.Framework.UI.BunifuFlatButton BtnChangePassword;
        public System.Windows.Forms.Label lblvotersrid;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtMiddleName;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtFirstName;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtLastName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private System.Windows.Forms.Label label3;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvotersid;
        public MetroFramework.Controls.MetroComboBox TxtGrade;
        public MetroFramework.Controls.MetroComboBox TxtStrand;
        public MetroFramework.Controls.MetroComboBox TxtTrack;
        public System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}