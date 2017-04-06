namespace Dactylo9
{
    partial class mainFrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbxTextSample = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.tmTheTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetScores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTextSample
            // 
            this.tbxTextSample.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTextSample.Location = new System.Drawing.Point(24, 34);
            this.tbxTextSample.Multiline = true;
            this.tbxTextSample.Name = "tbxTextSample";
            this.tbxTextSample.ReadOnly = true;
            this.tbxTextSample.Size = new System.Drawing.Size(563, 278);
            this.tbxTextSample.TabIndex = 1;
            this.tbxTextSample.TabStop = false;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(30, 330);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(48, 13);
            this.lblF.TabIndex = 1;
            this.lblF.Text = "Fautes : ";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(395, 330);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(80, 13);
            this.lblT.TabIndex = 2;
            this.lblT.Text = "Temps écoulé :";
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(24, 366);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.ReadOnly = true;
            this.tbxInput.Size = new System.Drawing.Size(347, 220);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            this.tbxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyUp);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(392, 366);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 47);
            this.btn1.TabIndex = 4;
            this.btn1.TabStop = false;
            this.btn1.Text = "1\r\n,.!?";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(457, 366);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 47);
            this.btn2.TabIndex = 5;
            this.btn2.TabStop = false;
            this.btn2.Text = "2\r\nABC";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(522, 366);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 47);
            this.btn3.TabIndex = 6;
            this.btn3.TabStop = false;
            this.btn3.Text = "3\r\nDEF";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(522, 424);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 47);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6\r\nMNO";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(457, 424);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 47);
            this.btn5.TabIndex = 8;
            this.btn5.TabStop = false;
            this.btn5.Text = "5\r\nJKL";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(392, 424);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 47);
            this.btn4.TabIndex = 7;
            this.btn4.TabStop = false;
            this.btn4.Text = "4\r\nGHI";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(522, 486);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 47);
            this.btn9.TabIndex = 12;
            this.btn9.TabStop = false;
            this.btn9.Text = "9\r\nWXYZ";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(457, 486);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 47);
            this.btn8.TabIndex = 11;
            this.btn8.TabStop = false;
            this.btn8.Text = "8\r\nTUV";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(392, 486);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 47);
            this.btn7.TabIndex = 10;
            this.btn7.TabStop = false;
            this.btn7.Text = "7\r\nPQRS";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(457, 539);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(59, 47);
            this.btn10.TabIndex = 13;
            this.btn10.TabStop = false;
            this.btn10.Text = "0\r\n␣";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(84, 330);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(10, 13);
            this.lblErrors.TabIndex = 14;
            this.lblErrors.Text = "-";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(481, 330);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(10, 13);
            this.lblTimeElapsed.TabIndex = 15;
            this.lblTimeElapsed.Text = "-";
            // 
            // tmTheTimer
            // 
            this.tmTheTimer.Tick += new System.EventHandler(this.tmTheTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partieToolStripMenuItem,
            this.scoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partieToolStripMenuItem
            // 
            this.partieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame});
            this.partieToolStripMenuItem.Name = "partieToolStripMenuItem";
            this.partieToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.partieToolStripMenuItem.Text = "Partie";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(154, 22);
            this.tsmiNewGame.Text = "Nouvelle partie";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetScores});
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.scoresToolStripMenuItem.Text = "Scores";
            // 
            // tsmiGetScores
            // 
            this.tsmiGetScores.Name = "tsmiGetScores";
            this.tsmiGetScores.Size = new System.Drawing.Size(169, 22);
            this.tsmiGetScores.Text = "Afficher les scores";
            this.tsmiGetScores.Click += new System.EventHandler(this.tsmiGetScores_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 614);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.tbxTextSample);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dactylo9";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTextSample;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Timer tmTheTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetScores;
    }
}

