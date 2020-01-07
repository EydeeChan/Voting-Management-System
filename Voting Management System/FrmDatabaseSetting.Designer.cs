namespace Voting_Management_System
{
    partial class FrmDatabaseSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabaseSetting));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.RememberMeCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDatabasePort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDatabasePassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDatabaseUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.RememberMeCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.RememberMeCheckBox.Checked = false;
            this.RememberMeCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.RememberMeCheckBox.ForeColor = System.Drawing.Color.White;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(128, 291);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(20, 20);
            this.RememberMeCheckBox.TabIndex = 269;
            this.RememberMeCheckBox.OnChange += new System.EventHandler(this.RememberMeCheckBox_OnChange);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(154, 292);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 268;
            this.materialLabel1.Text = "Remember Settings";
            // 
            // TxtDatabasePort
            // 
            this.TxtDatabasePort.Depth = 0;
            this.TxtDatabasePort.Hint = "";
            this.TxtDatabasePort.Location = new System.Drawing.Point(128, 251);
            this.TxtDatabasePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDatabasePort.Name = "TxtDatabasePort";
            this.TxtDatabasePort.PasswordChar = '\0';
            this.TxtDatabasePort.SelectedText = "";
            this.TxtDatabasePort.SelectionLength = 0;
            this.TxtDatabasePort.SelectionStart = 0;
            this.TxtDatabasePort.Size = new System.Drawing.Size(257, 23);
            this.TxtDatabasePort.TabIndex = 267;
            this.TxtDatabasePort.UseSystemPasswordChar = false;
            // 
            // TxtDatabasePassword
            // 
            this.TxtDatabasePassword.Depth = 0;
            this.TxtDatabasePassword.Hint = "";
            this.TxtDatabasePassword.Location = new System.Drawing.Point(128, 205);
            this.TxtDatabasePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDatabasePassword.Name = "TxtDatabasePassword";
            this.TxtDatabasePassword.PasswordChar = '\0';
            this.TxtDatabasePassword.SelectedText = "";
            this.TxtDatabasePassword.SelectionLength = 0;
            this.TxtDatabasePassword.SelectionStart = 0;
            this.TxtDatabasePassword.Size = new System.Drawing.Size(257, 23);
            this.TxtDatabasePassword.TabIndex = 266;
            this.TxtDatabasePassword.UseSystemPasswordChar = true;
            // 
            // TxtDatabaseUsername
            // 
            this.TxtDatabaseUsername.Depth = 0;
            this.TxtDatabaseUsername.Hint = "";
            this.TxtDatabaseUsername.Location = new System.Drawing.Point(128, 159);
            this.TxtDatabaseUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDatabaseUsername.Name = "TxtDatabaseUsername";
            this.TxtDatabaseUsername.PasswordChar = '\0';
            this.TxtDatabaseUsername.SelectedText = "";
            this.TxtDatabaseUsername.SelectionLength = 0;
            this.TxtDatabaseUsername.SelectionStart = 0;
            this.TxtDatabaseUsername.Size = new System.Drawing.Size(257, 23);
            this.TxtDatabaseUsername.TabIndex = 265;
            this.TxtDatabaseUsername.UseSystemPasswordChar = false;
            // 
            // TxtDatabase
            // 
            this.TxtDatabase.Depth = 0;
            this.TxtDatabase.Hint = "";
            this.TxtDatabase.Location = new System.Drawing.Point(128, 114);
            this.TxtDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDatabase.Name = "TxtDatabase";
            this.TxtDatabase.PasswordChar = '\0';
            this.TxtDatabase.SelectedText = "";
            this.TxtDatabase.SelectionLength = 0;
            this.TxtDatabase.SelectionStart = 0;
            this.TxtDatabase.Size = new System.Drawing.Size(257, 23);
            this.TxtDatabase.TabIndex = 264;
            this.TxtDatabase.UseSystemPasswordChar = false;
            // 
            // TxtServer
            // 
            this.TxtServer.Depth = 0;
            this.TxtServer.Hint = "";
            this.TxtServer.Location = new System.Drawing.Point(128, 71);
            this.TxtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.PasswordChar = '\0';
            this.TxtServer.SelectedText = "";
            this.TxtServer.SelectionLength = 0;
            this.TxtServer.SelectionStart = 0;
            this.TxtServer.Size = new System.Drawing.Size(257, 23);
            this.TxtServer.TabIndex = 263;
            this.TxtServer.UseSystemPasswordChar = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Active = false;
            this.BtnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSave.BorderRadius = 5;
            this.BtnSave.ButtonText = "  SAVE";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSave.Iconimage = null;
            this.BtnSave.Iconimage_right = null;
            this.BtnSave.Iconimage_right_Selected = null;
            this.BtnSave.Iconimage_Selected = null;
            this.BtnSave.IconMarginLeft = 0;
            this.BtnSave.IconMarginRight = 0;
            this.BtnSave.IconRightVisible = true;
            this.BtnSave.IconRightZoom = 0D;
            this.BtnSave.IconVisible = true;
            this.BtnSave.IconZoom = 90D;
            this.BtnSave.IsTab = false;
            this.BtnSave.Location = new System.Drawing.Point(259, 326);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.BtnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSave.selected = false;
            this.BtnSave.Size = new System.Drawing.Size(165, 36);
            this.BtnSave.TabIndex = 262;
            this.BtnSave.Text = "  SAVE";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Textcolor = System.Drawing.Color.White;
            this.BtnSave.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(29, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 261;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 260;
            this.label1.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 259;
            this.label5.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(29, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 258;
            this.label10.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(29, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 257;
            this.label6.Text = "Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 30);
            this.label8.TabIndex = 256;
            this.label8.Text = "Database Setting";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(394, 13);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 255;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 50;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(436, 5);
            this.panel6.TabIndex = 254;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.BtnSave;
            // 
            // FrmDatabaseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 374);
            this.Controls.Add(this.RememberMeCheckBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtDatabasePort);
            this.Controls.Add(this.TxtDatabasePassword);
            this.Controls.Add(this.TxtDatabaseUsername);
            this.Controls.Add(this.TxtDatabase);
            this.Controls.Add(this.TxtServer);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatabaseSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatabaseSetting";
            this.Load += new System.EventHandler(this.FrmDatabaseSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer t1;
        private Bunifu.Framework.UI.BunifuCheckbox RememberMeCheckBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDatabasePort;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDatabasePassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDatabaseUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDatabase;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtServer;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}