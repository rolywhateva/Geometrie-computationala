﻿namespace DelaunayArii
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelPuncte = new System.Windows.Forms.Label();
            this.labelArii = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(803, 368);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(338, 390);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Deseneaza";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelPuncte
            // 
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.Location = new System.Drawing.Point(118, 400);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(63, 13);
            this.labelPuncte.TabIndex = 2;
            this.labelPuncte.Text = "labelPuncte";
            // 
            // labelArii
            // 
            this.labelArii.AutoSize = true;
            this.labelArii.Location = new System.Drawing.Point(605, 400);
            this.labelArii.Name = "labelArii";
            this.labelArii.Size = new System.Drawing.Size(43, 13);
            this.labelArii.TabIndex = 3;
            this.labelArii.Text = "labelArii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.labelArii);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Delaunay arii";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelPuncte;
        private System.Windows.Forms.Label labelArii;
    }
}

