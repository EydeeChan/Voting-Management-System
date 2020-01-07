namespace Voting_Management_System
{
    partial class NotificationDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationDelete));
            this.BorderlessForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ElipseRadius = 12;
            this.BorderlessForm.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(96, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Voting Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.White;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DimGray;
            this.lbltitle.Location = new System.Drawing.Point(96, 33);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(248, 57);
            this.lbltitle.TabIndex = 37;
            this.lbltitle.Text = "Are you sure you want to delete ?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 5);
            this.panel4.TabIndex = 33;
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
            this.BtnCancel.Location = new System.Drawing.Point(240, 93);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(117)))), ((int)(((byte)(94)))));
            this.BtnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancel.selected = false;
            this.BtnCancel.Size = new System.Drawing.Size(113, 27);
            this.BtnCancel.TabIndex = 237;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.Textcolor = System.Drawing.Color.White;
            this.BtnCancel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Active = false;
            this.BtnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.BorderRadius = 5;
            this.BtnDelete.ButtonText = "Delete";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDelete.Iconimage = null;
            this.BtnDelete.Iconimage_right = null;
            this.BtnDelete.Iconimage_right_Selected = null;
            this.BtnDelete.Iconimage_Selected = null;
            this.BtnDelete.IconMarginLeft = 0;
            this.BtnDelete.IconMarginRight = 0;
            this.BtnDelete.IconRightVisible = true;
            this.BtnDelete.IconRightZoom = 0D;
            this.BtnDelete.IconVisible = true;
            this.BtnDelete.IconZoom = 90D;
            this.BtnDelete.IsTab = false;
            this.BtnDelete.Location = new System.Drawing.Point(121, 93);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDelete.selected = false;
            this.BtnDelete.Size = new System.Drawing.Size(113, 27);
            this.BtnDelete.TabIndex = 236;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDelete.Textcolor = System.Drawing.Color.White;
            this.BtnDelete.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.BtnDelete;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.BtnCancel;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Maroon;
            this.lblid.Location = new System.Drawing.Point(88, 138);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(188, 20);
            this.lblid.TabIndex = 238;
            this.lblid.Text = "Voting Management System";
            // 
            // NotificationDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 132);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotificationDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationDelete";
            this.Load += new System.EventHandler(this.NotificationDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BorderlessForm;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCancel;
        public Bunifu.Framework.UI.BunifuFlatButton BtnDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lbltitle;
        public System.Windows.Forms.Label lblid;
    }
}