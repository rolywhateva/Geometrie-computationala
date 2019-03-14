namespace Laborator2
{
    partial class Form1
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
            this.Box = new System.Windows.Forms.PictureBox();
            this.BTriunghi = new System.Windows.Forms.Button();
            this.BPatrate = new System.Windows.Forms.Button();
            this.BPatrat2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(1057, 632);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // BTriunghi
            // 
            this.BTriunghi.Location = new System.Drawing.Point(171, 661);
            this.BTriunghi.Name = "BTriunghi";
            this.BTriunghi.Size = new System.Drawing.Size(75, 23);
            this.BTriunghi.TabIndex = 1;
            this.BTriunghi.Text = "Triunghiuri";
            this.BTriunghi.UseVisualStyleBackColor = true;
            this.BTriunghi.Click += new System.EventHandler(this.BTriunghi_Click);
            // 
            // BPatrate
            // 
            this.BPatrate.Location = new System.Drawing.Point(283, 661);
            this.BPatrate.Name = "BPatrate";
            this.BPatrate.Size = new System.Drawing.Size(75, 23);
            this.BPatrate.TabIndex = 2;
            this.BPatrate.Text = "Clepsidre";
            this.BPatrate.UseVisualStyleBackColor = true;
            this.BPatrate.Click += new System.EventHandler(this.BPatrate_Click);
            // 
            // BPatrat2
            // 
            this.BPatrat2.Location = new System.Drawing.Point(396, 661);
            this.BPatrat2.Name = "BPatrat2";
            this.BPatrat2.Size = new System.Drawing.Size(75, 23);
            this.BPatrat2.TabIndex = 3;
            this.BPatrat2.Text = "Patrate";
            this.BPatrat2.UseVisualStyleBackColor = true;
            this.BPatrat2.Click += new System.EventHandler(this.BPatrat2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 741);
            this.Controls.Add(this.BPatrat2);
            this.Controls.Add(this.BPatrate);
            this.Controls.Add(this.BTriunghi);
            this.Controls.Add(this.Box);
            this.Name = "Form1";
            this.Text = "Laborator2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Button BTriunghi;
        private System.Windows.Forms.Button BPatrate;
        private System.Windows.Forms.Button BPatrat2;
    }
}

