namespace PartitionareArie
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonDraw = new System.Windows.Forms.Button();
            this.labelArie = new System.Windows.Forms.Label();
            this.labelPuncte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(2, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(904, 546);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // ButtonDraw
            // 
            this.ButtonDraw.Location = new System.Drawing.Point(1058, 2);
            this.ButtonDraw.Name = "ButtonDraw";
            this.ButtonDraw.Size = new System.Drawing.Size(84, 23);
            this.ButtonDraw.TabIndex = 1;
            this.ButtonDraw.Text = "Desenare";
            this.ButtonDraw.UseVisualStyleBackColor = true;
            this.ButtonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // labelArie
            // 
            this.labelArie.AutoSize = true;
            this.labelArie.Location = new System.Drawing.Point(926, 62);
            this.labelArie.Name = "labelArie";
            this.labelArie.Size = new System.Drawing.Size(0, 13);
            this.labelArie.TabIndex = 2;
            // 
            // labelPuncte
            // 
            this.labelPuncte.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.Location = new System.Drawing.Point(926, 136);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(0, 13);
            this.labelPuncte.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 649);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.labelArie);
            this.Controls.Add(this.ButtonDraw);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Partitionare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ButtonDraw;
        private System.Windows.Forms.Label labelArie;
        private System.Windows.Forms.Label labelPuncte;
    }
}

