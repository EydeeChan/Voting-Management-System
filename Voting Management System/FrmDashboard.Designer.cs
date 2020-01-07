namespace Voting_Management_System
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnVote = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtPosition = new MetroFramework.Controls.MetroComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPreview = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(173, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(552, 48);
            this.label12.TabIndex = 243;
            this.label12.Text = "Supreme Student Goverment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(185, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(552, 48);
            this.label14.TabIndex = 242;
            this.label14.Text = "Taytay Senior High School";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 48);
            this.label1.TabIndex = 241;
            this.label1.Text = "Voting Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(203)))), ((int)(((byte)(198)))));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(883, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 244;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(203)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 150);
            this.panel1.TabIndex = 245;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(945, 5);
            this.panel6.TabIndex = 244;
            // 
            // BtnVote
            // 
            this.BtnVote.Active = false;
            this.BtnVote.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVote.BorderRadius = 5;
            this.BtnVote.ButtonText = "Finalize Vote";
            this.BtnVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVote.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVote.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVote.Iconimage = null;
            this.BtnVote.Iconimage_right = null;
            this.BtnVote.Iconimage_right_Selected = null;
            this.BtnVote.Iconimage_Selected = null;
            this.BtnVote.IconMarginLeft = 0;
            this.BtnVote.IconMarginRight = 0;
            this.BtnVote.IconRightVisible = true;
            this.BtnVote.IconRightZoom = 0D;
            this.BtnVote.IconVisible = true;
            this.BtnVote.IconZoom = 90D;
            this.BtnVote.IsTab = false;
            this.BtnVote.Location = new System.Drawing.Point(738, 691);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnVote.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnVote.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVote.selected = false;
            this.BtnVote.Size = new System.Drawing.Size(192, 36);
            this.BtnVote.TabIndex = 235;
            this.BtnVote.Text = "Finalize Vote";
            this.BtnVote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVote.Textcolor = System.Drawing.Color.White;
            this.BtnVote.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // TxtPosition
            // 
            this.TxtPosition.FormattingEnabled = true;
            this.TxtPosition.ItemHeight = 23;
            this.TxtPosition.Location = new System.Drawing.Point(716, 156);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(214, 29);
            this.TxtPosition.TabIndex = 247;
            this.TxtPosition.UseSelectable = true;
            this.TxtPosition.SelectedIndexChanged += new System.EventHandler(this.TxtPosition_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(924, 495);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Active = false;
            this.BtnPreview.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPreview.BorderRadius = 5;
            this.BtnPreview.ButtonText = "Preview";
            this.BtnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPreview.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPreview.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPreview.Iconimage = null;
            this.BtnPreview.Iconimage_right = null;
            this.BtnPreview.Iconimage_right_Selected = null;
            this.BtnPreview.Iconimage_Selected = null;
            this.BtnPreview.IconMarginLeft = 0;
            this.BtnPreview.IconMarginRight = 0;
            this.BtnPreview.IconRightVisible = true;
            this.BtnPreview.IconRightZoom = 0D;
            this.BtnPreview.IconVisible = true;
            this.BtnPreview.IconZoom = 90D;
            this.BtnPreview.IsTab = false;
            this.BtnPreview.Location = new System.Drawing.Point(540, 691);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.BtnPreview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(117)))), ((int)(((byte)(94)))));
            this.BtnPreview.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPreview.selected = false;
            this.BtnPreview.Size = new System.Drawing.Size(192, 36);
            this.BtnPreview.TabIndex = 248;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPreview.Textcolor = System.Drawing.Color.White;
            this.BtnPreview.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 732);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        public Bunifu.Framework.UI.BunifuFlatButton BtnVote;
        public MetroFramework.Controls.MetroComboBox TxtPosition;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Bunifu.Framework.UI.BunifuFlatButton BtnPreview;
    }
}