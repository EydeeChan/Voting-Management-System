namespace Voting_Management_System
{
    partial class ViewPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPosition));
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblposition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblpositionid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 68);
            this.panel6.TabIndex = 50;
            // 
            // lblposition
            // 
            this.lblposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblposition.Location = new System.Drawing.Point(298, 18);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(261, 48);
            this.lblposition.TabIndex = 58;
            this.lblposition.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(219, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Position";
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
            this.BtnEdit.TabIndex = 60;
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
            this.BtnDelete.TabIndex = 59;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Zoom = 10;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // lblpositionid
            // 
            this.lblpositionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpositionid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblpositionid.Location = new System.Drawing.Point(127, 18);
            this.lblpositionid.Name = "lblpositionid";
            this.lblpositionid.Size = new System.Drawing.Size(86, 26);
            this.lblpositionid.TabIndex = 62;
            this.lblpositionid.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Position ID:";
            // 
            // ViewPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblpositionid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Name = "ViewPosition";
            this.Size = new System.Drawing.Size(660, 68);
            this.Load += new System.EventHandler(this.ViewPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton BtnEdit;
        private Bunifu.Framework.UI.BunifuImageButton BtnDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Label lblpositionid;
        public System.Windows.Forms.Label label2;
    }
}
