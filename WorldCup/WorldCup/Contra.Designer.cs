﻿namespace WorldCup
{
    partial class Contra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contra));
            this.Equipa1 = new System.Windows.Forms.PictureBox();
            this.Equipa2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Equipa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equipa2)).BeginInit();
            this.SuspendLayout();
            // 
            // Equipa1
            // 
            this.Equipa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Equipa1.BackgroundImage")));
            this.Equipa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Equipa1.Location = new System.Drawing.Point(81, 153);
            this.Equipa1.Name = "Equipa1";
            this.Equipa1.Size = new System.Drawing.Size(222, 131);
            this.Equipa1.TabIndex = 0;
            this.Equipa1.TabStop = false;
            // 
            // Equipa2
            // 
            this.Equipa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Equipa2.BackgroundImage")));
            this.Equipa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Equipa2.Location = new System.Drawing.Point(492, 153);
            this.Equipa2.Name = "Equipa2";
            this.Equipa2.Size = new System.Drawing.Size(222, 131);
            this.Equipa2.TabIndex = 1;
            this.Equipa2.TabStop = false;
            // 
            // Contra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Equipa2);
            this.Controls.Add(this.Equipa1);
            this.Name = "Contra";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Equipa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equipa2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Equipa1;
        private System.Windows.Forms.PictureBox Equipa2;
    }
}