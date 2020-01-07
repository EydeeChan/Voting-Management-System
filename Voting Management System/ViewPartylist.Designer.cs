namespace Voting_Management_System
{
    partial class ViewPartylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPartylist));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblpartylistid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblpartylist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // lblpartylistid
            // 
            this.lblpartylistid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartylistid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblpartylistid.Location = new System.Drawing.Point(127, 18);
            this.lblpartylistid.Name = "lblpartylistid";
            this.lblpartylistid.Size = new System.Drawing.Size(86, 26);
            this.lblpartylistid.TabIndex = 68;
            this.lblpartylistid.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Partylist ID:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageActive = null;
            this.BtnEdit.Location = new System.Drawing.Point(565, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(40, 40);
            this.BtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEdit.TabIndex = 66;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.Zoom = 10;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageActive = null;
            this.BtnDelete.Location = new System.Drawing.Point(611, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(40, 40);
            this.BtnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnDelete.TabIndex = 65;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Zoom = 10;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblpartylist
            // 
            this.lblpartylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblpartylist.Location = new System.Drawing.Point(298, 18);
            this.lblpartylist.Name = "lblpartylist";
            this.lblpartylist.Size = new System.Drawing.Size(261, 48);
            this.lblpartylist.TabIndex = 64;
            this.lblpartylist.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(219, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Position";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 68);
            this.panel6.TabIndex = 69;
            // 
            // ViewPartylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblpartylistid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.lblpartylist);
            this.Controls.Add(this.label3);
            this.Name = "ViewPartylist";
            this.Size = new System.Drawing.Size(660, 68);
            this.Load += new System.EventHandler(this.ViewPartylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Label lblpartylistid;
        public System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton BtnEdit;
        private Bunifu.Framework.UI.BunifuImageButton BtnDelete;
        public System.Windows.Forms.Label lblpartylist;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
    }
}
