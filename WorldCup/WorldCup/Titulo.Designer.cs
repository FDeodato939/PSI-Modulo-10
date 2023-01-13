namespace WorldCup
{
    partial class Titulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titulo));
            this.worldCup = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worldCup
            // 
            this.worldCup.AutoSize = true;
            this.worldCup.BackColor = System.Drawing.Color.Black;
            this.worldCup.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldCup.ForeColor = System.Drawing.SystemColors.Control;
            this.worldCup.Location = new System.Drawing.Point(199, 58);
            this.worldCup.Name = "worldCup";
            this.worldCup.Size = new System.Drawing.Size(407, 67);
            this.worldCup.TabIndex = 1;
            this.worldCup.Text = "World Cup 2022";
            this.worldCup.Click += new System.EventHandler(this.label1_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.HotTrack;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(323, 185);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(125, 60);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.butt_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(323, 270);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 60);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // Titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.play);
            this.Controls.Add(this.worldCup);
            this.Name = "Titulo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label worldCup;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button exit;
    }
}

