namespace Interface1
{
    partial class Form2
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
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.lblgen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(681, 45);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbf);
            this.groupBox1.Controls.Add(this.rbm);
            this.groupBox1.Location = new System.Drawing.Point(206, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "generos";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(28, 35);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(34, 17);
            this.rbm.TabIndex = 0;
            this.rbm.TabStop = true;
            this.rbm.Text = "M";
            this.rbm.UseVisualStyleBackColor = true;
            this.rbm.CheckedChanged += new System.EventHandler(this.rbm_CheckedChanged);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(28, 58);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(31, 17);
            this.rbf.TabIndex = 1;
            this.rbf.TabStop = true;
            this.rbf.Text = "F";
            this.rbf.UseVisualStyleBackColor = true;
            this.rbf.CheckedChanged += new System.EventHandler(this.rbf_CheckedChanged);
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Location = new System.Drawing.Point(234, 241);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(35, 13);
            this.lblgen.TabIndex = 2;
            this.lblgen.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblgen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnclose);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.Label lblgen;
    }
}