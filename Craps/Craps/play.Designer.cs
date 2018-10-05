namespace Craps
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.btnRoll = new System.Windows.Forms.Button();
            this.die1 = new System.Windows.Forms.PictureBox();
            this.die2 = new System.Windows.Forms.PictureBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoll.Font = new System.Drawing.Font("Bauhaus 93", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(332, 389);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(140, 60);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // die1
            // 
            this.die1.Image = ((System.Drawing.Image)(resources.GetObject("die1.Image")));
            this.die1.Location = new System.Drawing.Point(148, 100);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(82, 82);
            this.die1.TabIndex = 4;
            this.die1.TabStop = false;
            // 
            // die2
            // 
            this.die2.Image = ((System.Drawing.Image)(resources.GetObject("die2.Image")));
            this.die2.Location = new System.Drawing.Point(270, 100);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(82, 82);
            this.die2.TabIndex = 5;
            this.die2.TabStop = false;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(184, 270);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(138, 24);
            this.lblShow.TabIndex = 6;
            this.lblShow.Text = "Roll the dice!";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(12, 419);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(160, 30);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblStats.Location = new System.Drawing.Point(9, 389);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(284, 15);
            this.lblStats.TabIndex = 11;
            this.lblStats.Text = "Games Played: 0   Wins: 0   Losses: 0   Roll Sum: 0";
            this.lblStats.UseMnemonic = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps by Patrick Gibbons";
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox die1;
        private System.Windows.Forms.PictureBox die2;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblStats;
    }
}