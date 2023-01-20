namespace WorldCup
{
    partial class Tabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela));
            this.fatasmaDoFatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avanca = new System.Windows.Forms.Button();
            this.volta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fatasmaDoFatar)).BeginInit();
            this.SuspendLayout();
            // 
            // fatasmaDoFatar
            // 
            this.fatasmaDoFatar.BackColor = System.Drawing.Color.Transparent;
            this.fatasmaDoFatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fatasmaDoFatar.BackgroundImage")));
            this.fatasmaDoFatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fatasmaDoFatar.Location = new System.Drawing.Point(507, 86);
            this.fatasmaDoFatar.Name = "fatasmaDoFatar";
            this.fatasmaDoFatar.Size = new System.Drawing.Size(464, 494);
            this.fatasmaDoFatar.TabIndex = 0;
            this.fatasmaDoFatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 184);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // avanca
            // 
            this.avanca.BackColor = System.Drawing.SystemColors.Highlight;
            this.avanca.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avanca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.avanca.Location = new System.Drawing.Point(120, 275);
            this.avanca.Name = "avanca";
            this.avanca.Size = new System.Drawing.Size(112, 52);
            this.avanca.TabIndex = 3;
            this.avanca.Text = "Avança";
            this.avanca.UseVisualStyleBackColor = false;
            // 
            // volta
            // 
            this.volta.BackColor = System.Drawing.SystemColors.Highlight;
            this.volta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.volta.Location = new System.Drawing.Point(266, 275);
            this.volta.Name = "volta";
            this.volta.Size = new System.Drawing.Size(112, 52);
            this.volta.TabIndex = 4;
            this.volta.Text = "Volta";
            this.volta.UseVisualStyleBackColor = false;
            this.volta.Click += new System.EventHandler(this.volta_Click);
            // 
            // Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volta);
            this.Controls.Add(this.avanca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatasmaDoFatar);
            this.DoubleBuffered = true;
            this.Name = "Tabela";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.fatasmaDoFatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fatasmaDoFatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button avanca;
        private System.Windows.Forms.Button volta;
    }
}