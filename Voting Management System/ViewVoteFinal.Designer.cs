namespace Voting_Management_System
{
    partial class ViewVoteFinal
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
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblvote = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // lblvote
            // 
            this.lblvote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblvote.Location = new System.Drawing.Point(7, 39);
            this.lblvote.Name = "lblvote";
            this.lblvote.Size = new System.Drawing.Size(261, 43);
            this.lblvote.TabIndex = 60;
            this.lblvote.Text = "label2";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.ForeColor = System.Drawing.Color.DimGray;
            this.lblposition.Location = new System.Drawing.Point(7, 9);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(73, 21);
            this.lblposition.TabIndex = 59;
            this.lblposition.Text = "Position";
            // 
            // ViewVoteFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblvote);
            this.Controls.Add(this.lblposition);
            this.Name = "ViewVoteFinal";
            this.Size = new System.Drawing.Size(447, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.Label lblvote;
        public System.Windows.Forms.Label lblposition;
    }
}
