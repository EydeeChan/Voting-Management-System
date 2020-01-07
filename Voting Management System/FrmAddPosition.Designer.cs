namespace Voting_Management_System
{
    partial class FrmAddPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPosition));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPosition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAddPosition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblpositionid = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.panel6.Size = new System.Drawing.Size(407, 5);
            this.panel6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 30);
            this.label8.TabIndex = 226;
            this.label8.Text = "Add Position";
            // 
            // TxtPosition
            // 
            this.TxtPosition.Depth = 0;
            this.TxtPosition.Hint = "";
            this.TxtPosition.Location = new System.Drawing.Point(138, 85);
            this.TxtPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.PasswordChar = '\0';
            this.TxtPosition.SelectedText = "";
            this.TxtPosition.SelectionLength = 0;
            this.TxtPosition.SelectionStart = 0;
            this.TxtPosition.Size = new System.Drawing.Size(244, 23);
            this.TxtPosition.TabIndex = 232;
            this.TxtPosition.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 231;
            this.label2.Text = "Position Name";
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
            this.BtnCancel.Location = new System.Drawing.Point(267, 153);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(117)))), ((int)(((byte)(94)))));
            this.BtnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancel.selected = false;
            this.BtnCancel.Size = new System.Drawing.Size(129, 33);
            this.BtnCancel.TabIndex = 234;
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
            this.BtnAddPosition.ButtonText = "Add Position";
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
            this.BtnAddPosition.Location = new System.Drawing.Point(132, 153);
            this.BtnAddPosition.Name = "BtnAddPosition";
            this.BtnAddPosition.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnAddPosition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnAddPosition.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAddPosition.selected = false;
            this.BtnAddPosition.Size = new System.Drawing.Size(129, 33);
            this.BtnAddPosition.TabIndex = 233;
            this.BtnAddPosition.Text = "Add Position";
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
            this.BtnChangePassword.ButtonText = "Edit Position";
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
            this.BtnChangePassword.Location = new System.Drawing.Point(132, 153);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnChangePassword.selected = false;
            this.BtnChangePassword.Size = new System.Drawing.Size(129, 33);
            this.BtnChangePassword.TabIndex = 235;
            this.BtnChangePassword.Text = "Edit Position";
            this.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChangePassword.Textcolor = System.Drawing.Color.White;
            this.BtnChangePassword.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // lblpositionid
            // 
            this.lblpositionid.AutoSize = true;
            this.lblpositionid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpositionid.ForeColor = System.Drawing.Color.DimGray;
            this.lblpositionid.Location = new System.Drawing.Point(14, 198);
            this.lblpositionid.Name = "lblpositionid";
            this.lblpositionid.Size = new System.Drawing.Size(65, 17);
            this.lblpositionid.TabIndex = 236;
            this.lblpositionid.Text = "Note Title";
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
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.BtnChangePassword;
            // 
            // FrmAddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 198);
            this.Controls.Add(this.lblpositionid);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddPosition);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.BtnChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddPosition";
            this.Load += new System.EventHandler(this.FrmAddPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Panel panel6;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtPosition;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCancel;
        public Bunifu.Framework.UI.BunifuFlatButton BtnAddPosition;
        public Bunifu.Framework.UI.BunifuFlatButton BtnChangePassword;
        public System.Windows.Forms.Label lblpositionid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        public System.Windows.Forms.Label label8;
    }
}