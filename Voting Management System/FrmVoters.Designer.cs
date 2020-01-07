namespace Voting_Management_System
{
    partial class FrmVoters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoters));
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAddPosition = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(203)))), ((int)(((byte)(198)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 81);
            this.panel3.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 46);
            this.label1.TabIndex = 45;
            this.label1.Text = "Manage Voters\r\nInformation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(893, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 26);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 41;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 5);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtSearch);
            this.panel2.Controls.Add(this.TxtSearchBy);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnRefresh);
            this.panel2.Controls.Add(this.BtnSearch);
            this.panel2.Controls.Add(this.BtnAddPosition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 42);
            this.panel2.TabIndex = 222;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(162, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 225;
            this.label2.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Depth = 0;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Hint = "";
            this.TxtSearch.Location = new System.Drawing.Point(241, 13);
            this.TxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.Size = new System.Drawing.Size(283, 23);
            this.TxtSearch.TabIndex = 226;
            this.TxtSearch.Text = "Search here..";
            this.TxtSearch.UseSystemPasswordChar = false;
            this.TxtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.TxtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // TxtSearchBy
            // 
            this.TxtSearchBy.FormattingEnabled = true;
            this.TxtSearchBy.ItemHeight = 23;
            this.TxtSearchBy.Items.AddRange(new object[] {
            "First Name",
            "Middle Name",
            "Last Name",
            "Grade",
            "Track",
            "Strand"});
            this.TxtSearchBy.Location = new System.Drawing.Point(638, 7);
            this.TxtSearchBy.Name = "TxtSearchBy";
            this.TxtSearchBy.Size = new System.Drawing.Size(214, 29);
            this.TxtSearchBy.TabIndex = 5;
            this.TxtSearchBy.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(534, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 223;
            this.label4.Text = "Search By:";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageActive = null;
            this.BtnRefresh.Location = new System.Drawing.Point(894, 7);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(30, 29);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRefresh.TabIndex = 224;
            this.BtnRefresh.TabStop = false;
            this.BtnRefresh.Zoom = 10;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.ImageActive = null;
            this.BtnSearch.Location = new System.Drawing.Point(858, 7);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(30, 29);
            this.BtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSearch.TabIndex = 222;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.Zoom = 10;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddPosition
            // 
            this.BtnAddPosition.Active = false;
            this.BtnAddPosition.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.BtnAddPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAddPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddPosition.BorderRadius = 0;
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
            this.BtnAddPosition.Location = new System.Drawing.Point(12, 6);
            this.BtnAddPosition.Name = "BtnAddPosition";
            this.BtnAddPosition.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnAddPosition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.BtnAddPosition.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAddPosition.selected = false;
            this.BtnAddPosition.Size = new System.Drawing.Size(144, 29);
            this.BtnAddPosition.TabIndex = 220;
            this.BtnAddPosition.Text = "Add Voter";
            this.BtnAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddPosition.Textcolor = System.Drawing.Color.White;
            this.BtnAddPosition.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddPosition.Click += new System.EventHandler(this.BtnAddPosition_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.BtnAddPosition;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 483);
            this.flowLayoutPanel1.TabIndex = 223;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // FrmVoters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 612);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVoters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVoters";
            this.Load += new System.EventHandler(this.FrmVoters_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton BtnAddPosition;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton BtnRefresh;
        private Bunifu.Framework.UI.BunifuImageButton BtnSearch;
        public MetroFramework.Controls.MetroComboBox TxtSearchBy;
        private System.Windows.Forms.Label label2;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtSearch;
    }
}