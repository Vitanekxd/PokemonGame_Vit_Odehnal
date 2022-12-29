using System;

namespace PokemonGame_Vit_Odehnal
{
    partial class Battle
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBenemy = new System.Windows.Forms.PictureBox();
            this.PBplayer = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBenemy = new System.Windows.Forms.Label();
            this.ProgBarEnemy = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBplayer = new System.Windows.Forms.Label();
            this.ProgBarPlayer = new System.Windows.Forms.ProgressBar();
            this.BtnDefend = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAtk1 = new System.Windows.Forms.Button();
            this.BtnAtk2 = new System.Windows.Forms.Button();
            this.TimerEnAtk = new System.Windows.Forms.Timer(this.components);
            this.LBinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBenemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBenemy
            // 
            this.PBenemy.BackColor = System.Drawing.Color.Transparent;
            this.PBenemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBenemy.Image = global::PokemonGame_Vit_Odehnal.Properties.Resources.charmander;
            this.PBenemy.Location = new System.Drawing.Point(801, 12);
            this.PBenemy.Name = "PBenemy";
            this.PBenemy.Size = new System.Drawing.Size(200, 200);
            this.PBenemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBenemy.TabIndex = 1;
            this.PBenemy.TabStop = false;
            this.PBenemy.UseWaitCursor = true;
            // 
            // PBplayer
            // 
            this.PBplayer.BackColor = System.Drawing.Color.Transparent;
            this.PBplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBplayer.Image = global::PokemonGame_Vit_Odehnal.Properties.Resources._007;
            this.PBplayer.Location = new System.Drawing.Point(12, 281);
            this.PBplayer.Name = "PBplayer";
            this.PBplayer.Size = new System.Drawing.Size(200, 200);
            this.PBplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBplayer.TabIndex = 2;
            this.PBplayer.TabStop = false;
            this.PBplayer.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LBenemy);
            this.panel2.Controls.Add(this.ProgBarEnemy);
            this.panel2.Location = new System.Drawing.Point(388, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 77);
            this.panel2.TabIndex = 5;
            // 
            // LBenemy
            // 
            this.LBenemy.AutoSize = true;
            this.LBenemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBenemy.Location = new System.Drawing.Point(3, 9);
            this.LBenemy.Name = "LBenemy";
            this.LBenemy.Size = new System.Drawing.Size(156, 29);
            this.LBenemy.TabIndex = 4;
            this.LBenemy.Text = "Charmander";
            // 
            // ProgBarEnemy
            // 
            this.ProgBarEnemy.Location = new System.Drawing.Point(3, 41);
            this.ProgBarEnemy.Name = "ProgBarEnemy";
            this.ProgBarEnemy.Size = new System.Drawing.Size(400, 25);
            this.ProgBarEnemy.TabIndex = 3;
            this.ProgBarEnemy.Value = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LBplayer);
            this.panel3.Controls.Add(this.ProgBarPlayer);
            this.panel3.Location = new System.Drawing.Point(218, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 77);
            this.panel3.TabIndex = 5;
            // 
            // LBplayer
            // 
            this.LBplayer.AutoSize = true;
            this.LBplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBplayer.Location = new System.Drawing.Point(3, 9);
            this.LBplayer.Name = "LBplayer";
            this.LBplayer.Size = new System.Drawing.Size(104, 29);
            this.LBplayer.TabIndex = 4;
            this.LBplayer.Text = "Squirtle";
            // 
            // ProgBarPlayer
            // 
            this.ProgBarPlayer.Location = new System.Drawing.Point(3, 41);
            this.ProgBarPlayer.Name = "ProgBarPlayer";
            this.ProgBarPlayer.Size = new System.Drawing.Size(400, 25);
            this.ProgBarPlayer.TabIndex = 3;
            this.ProgBarPlayer.Value = 100;
            // 
            // BtnDefend
            // 
            this.BtnDefend.BackgroundImage = global::PokemonGame_Vit_Odehnal.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.BtnDefend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDefend.Location = new System.Drawing.Point(766, 413);
            this.BtnDefend.Name = "BtnDefend";
            this.BtnDefend.Size = new System.Drawing.Size(124, 68);
            this.BtnDefend.TabIndex = 7;
            this.BtnDefend.Text = "Protect";
            this.BtnDefend.UseVisualStyleBackColor = true;
            this.BtnDefend.Click += new System.EventHandler(this.BtnDefend_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExit.BackgroundImage = global::PokemonGame_Vit_Odehnal.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnExit.Location = new System.Drawing.Point(896, 413);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 68);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnAtk1
            // 
            this.BtnAtk1.BackgroundImage = global::PokemonGame_Vit_Odehnal.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.BtnAtk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAtk1.Location = new System.Drawing.Point(766, 339);
            this.BtnAtk1.Name = "BtnAtk1";
            this.BtnAtk1.Size = new System.Drawing.Size(124, 68);
            this.BtnAtk1.TabIndex = 9;
            this.BtnAtk1.Text = "Attack 1";
            this.BtnAtk1.UseVisualStyleBackColor = true;
            this.BtnAtk1.Click += new System.EventHandler(this.BtnAtk1_Click);
            // 
            // BtnAtk2
            // 
            this.BtnAtk2.BackgroundImage = global::PokemonGame_Vit_Odehnal.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.BtnAtk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAtk2.Location = new System.Drawing.Point(896, 339);
            this.BtnAtk2.Name = "BtnAtk2";
            this.BtnAtk2.Size = new System.Drawing.Size(124, 68);
            this.BtnAtk2.TabIndex = 10;
            this.BtnAtk2.Text = "Attack 2";
            this.BtnAtk2.UseVisualStyleBackColor = true;
            this.BtnAtk2.Click += new System.EventHandler(this.BtnAtk2_Click);
            // 
            // TimerEnAtk
            // 
            this.TimerEnAtk.Interval = 1500;
            this.TimerEnAtk.Tick += new System.EventHandler(this.TimerEnAtk_Tick);
            // 
            // LBinfo
            // 
            this.LBinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBinfo.Location = new System.Drawing.Point(766, 253);
            this.LBinfo.Name = "LBinfo";
            this.LBinfo.Size = new System.Drawing.Size(254, 83);
            this.LBinfo.TabIndex = 11;
            this.LBinfo.Text = "The Enemy Pokemon has appeared !!\r\nThe Battle has Begun !!\r\n";
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonGame_Vit_Odehnal.Properties.Resources.background_1;
            this.ClientSize = new System.Drawing.Size(1032, 493);
            this.Controls.Add(this.LBinfo);
            this.Controls.Add(this.BtnAtk2);
            this.Controls.Add(this.BtnAtk1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDefend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PBplayer);
            this.Controls.Add(this.PBenemy);
            this.Name = "Battle";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBenemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBplayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBenemy;
        private System.Windows.Forms.PictureBox PBplayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBenemy;
        private System.Windows.Forms.ProgressBar ProgBarEnemy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBplayer;
        private System.Windows.Forms.ProgressBar ProgBarPlayer;
        private System.Windows.Forms.Button BtnDefend;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAtk1;
        private System.Windows.Forms.Button BtnAtk2;
        private EventHandler button3_Click;
        private System.Windows.Forms.Timer TimerEnAtk;
        private System.Windows.Forms.Label LBinfo;
    }
}

