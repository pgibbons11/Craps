namespace Craps
{
    partial class Menu
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCraps = new System.Windows.Forms.Label();
            this.lblByPG = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnLoadPlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblPlayingAs = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(210, 167);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCraps
            // 
            this.lblCraps.AutoSize = true;
            this.lblCraps.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCraps.Location = new System.Drawing.Point(196, 40);
            this.lblCraps.Name = "lblCraps";
            this.lblCraps.Size = new System.Drawing.Size(108, 39);
            this.lblCraps.TabIndex = 3;
            this.lblCraps.Text = "Craps";
            // 
            // lblByPG
            // 
            this.lblByPG.AutoSize = true;
            this.lblByPG.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByPG.Location = new System.Drawing.Point(165, 80);
            this.lblByPG.Name = "lblByPG";
            this.lblByPG.Size = new System.Drawing.Size(170, 21);
            this.lblByPG.TabIndex = 4;
            this.lblByPG.Text = "by Patrick Gibbons";
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlayer.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(188, 203);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(125, 30);
            this.btnNewPlayer.TabIndex = 5;
            this.btnNewPlayer.Text = "New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPlayer.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlayer.Location = new System.Drawing.Point(188, 239);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(125, 30);
            this.btnLoadPlayer.TabIndex = 6;
            this.btnLoadPlayer.Text = "Load Player";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.btnLoadPlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPlayer.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPlayer.Location = new System.Drawing.Point(188, 275);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(125, 30);
            this.btnEditPlayer.TabIndex = 7;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(210, 311);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 30);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblPlayingAs
            // 
            this.lblPlayingAs.AutoSize = true;
            this.lblPlayingAs.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingAs.Location = new System.Drawing.Point(190, 413);
            this.lblPlayingAs.Name = "lblPlayingAs";
            this.lblPlayingAs.Size = new System.Drawing.Size(75, 15);
            this.lblPlayingAs.TabIndex = 9;
            this.lblPlayingAs.Text = "Playing as: ";
            this.lblPlayingAs.UseMnemonic = false;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblStats.Location = new System.Drawing.Point(108, 437);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(284, 15);
            this.lblStats.TabIndex = 10;
            this.lblStats.Text = "Games Played: 0   Wins: 0   Losses: 0   Roll Sum: 0";
            this.lblStats.UseMnemonic = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblPlayingAs);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnLoadPlayer);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.lblByPG);
            this.Controls.Add(this.lblCraps);
            this.Controls.Add(this.btnPlay);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps by Patrick Gibbons";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCraps;
        private System.Windows.Forms.Label lblByPG;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnLoadPlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblPlayingAs;
        private System.Windows.Forms.Label lblStats;
    }
}

