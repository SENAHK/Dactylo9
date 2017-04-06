namespace Dactylo9
{
    partial class scoresFrm
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
            this.dgvScores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScores
            // 
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvScores.Location = new System.Drawing.Point(0, 0);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.Size = new System.Drawing.Size(276, 150);
            this.dgvScores.TabIndex = 0;
            this.dgvScores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvScores_DataBindingComplete);
            // 
            // scoresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 144);
            this.Controls.Add(this.dgvScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "scoresFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.scoresFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScores;
    }
}