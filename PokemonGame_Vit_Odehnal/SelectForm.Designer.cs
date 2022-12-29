using System;

namespace PokemonGame_Vit_Odehnal
{
    partial class SelectForm
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
            this.PBchar = new System.Windows.Forms.PictureBox();
            this.PBbulba = new System.Windows.Forms.PictureBox();
            this.PBsquirt = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBchar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbulba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsquirt)).BeginInit();
            this.SuspendLayout();
            // 
            // PBchar
            // 
            this.PBchar.BackColor = System.Drawing.Color.White;
            this.PBchar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBchar.Image = global::PokemonGame_Vit_Odehnal.Properties.Resources.charmander;
            this.PBchar.Location = new System.Drawing.Point(550, 120);
            this.PBchar.Name = "PBchar";
            this.PBchar.Size = new System.Drawing.Size(200, 200);
            this.PBchar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBchar.TabIndex = 2;
            this.PBchar.TabStop = false;
            this.PBchar.Click += new System.EventHandler(this.PBchar_Click);
            // 
            // PBbulba
            // 
            this.PBbulba.BackColor = System.Drawing.Color.White;
            this.PBbulba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBbulba.Image = global::PokemonGame_Vit_Odehnal.Properties.Resources.bulbasaur;
            this.PBbulba.Location = new System.Drawing.Point(50, 120);
            this.PBbulba.Name = "PBbulba";
            this.PBbulba.Size = new System.Drawing.Size(200, 200);
            this.PBbulba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBbulba.TabIndex = 1;
            this.PBbulba.TabStop = false;
            this.PBbulba.Click += new System.EventHandler(this.PBbulba_Click);
            // 
            // PBsquirt
            // 
            this.PBsquirt.BackColor = System.Drawing.Color.White;
            this.PBsquirt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBsquirt.Image = global::PokemonGame_Vit_Odehnal.Properties.Resources._007;
            this.PBsquirt.Location = new System.Drawing.Point(300, 120);
            this.PBsquirt.Name = "PBsquirt";
            this.PBsquirt.Size = new System.Drawing.Size(200, 200);
            this.PBsquirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBsquirt.TabIndex = 0;
            this.PBsquirt.TabStop = false;
            this.PBsquirt.Click += new System.EventHandler(this.PBsquirt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(340, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Squirtle";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(70, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 32);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Bulbasaur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(560, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Charmander";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(210, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Your Pokemon";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnStart.Location = new System.Drawing.Point(300, 350);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(200, 60);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "START BATTLE";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PBchar);
            this.Controls.Add(this.PBbulba);
            this.Controls.Add(this.PBsquirt);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.PBchar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbulba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsquirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBsquirt;
        private System.Windows.Forms.PictureBox PBbulba;
        private System.Windows.Forms.PictureBox PBchar;
        private System.Windows.Forms.Label label2;
        private EventHandler label1_Click;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnStart;
    }
}