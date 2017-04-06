namespace Dactylo9
{
    partial class insertPlayerFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.btnSendScore = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre nom:";
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(100, 81);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerName.TabIndex = 1;
            // 
            // btnSendScore
            // 
            this.btnSendScore.Location = new System.Drawing.Point(100, 116);
            this.btnSendScore.Name = "btnSendScore";
            this.btnSendScore.Size = new System.Drawing.Size(100, 32);
            this.btnSendScore.TabIndex = 2;
            this.btnSendScore.Text = "Valider";
            this.btnSendScore.UseVisualStyleBackColor = true;
            this.btnSendScore.Click += new System.EventHandler(this.btnSendScore_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMessage.Location = new System.Drawing.Point(12, 12);
            this.lblMessage.Multiline = true;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.ReadOnly = true;
            this.lblMessage.Size = new System.Drawing.Size(188, 40);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "-";
            // 
            // insertPlayerFrm
            // 
            this.AcceptButton = this.btnSendScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 169);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSendScore);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "insertPlayerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertPlayerFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.insertPlayerFrm_FormClosed);
            this.Load += new System.EventHandler(this.insertPlayerFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.Button btnSendScore;
        private System.Windows.Forms.TextBox lblMessage;
    }
}