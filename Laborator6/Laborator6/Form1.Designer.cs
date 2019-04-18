namespace Laborator6
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
            this.ButtonGenerare = new System.Windows.Forms.Button();
            this.LabelRaspuns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(804, 388);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ButtonGenerare
            // 
            this.ButtonGenerare.Location = new System.Drawing.Point(703, 415);
            this.ButtonGenerare.Name = "ButtonGenerare";
            this.ButtonGenerare.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerare.TabIndex = 1;
            this.ButtonGenerare.Text = "Generare";
            this.ButtonGenerare.UseVisualStyleBackColor = true;
            this.ButtonGenerare.Click += new System.EventHandler(this.ButtonGenerare_Click);
            // 
            // LabelRaspuns
            // 
            this.LabelRaspuns.AutoSize = true;
            this.LabelRaspuns.Location = new System.Drawing.Point(83, 403);
            this.LabelRaspuns.Name = "LabelRaspuns";
            this.LabelRaspuns.Size = new System.Drawing.Size(49, 13);
            this.LabelRaspuns.TabIndex = 2;
            this.LabelRaspuns.Text = "Raspuns";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.LabelRaspuns);
            this.Controls.Add(this.ButtonGenerare);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Quick Hull";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ButtonGenerare;
        private System.Windows.Forms.Label LabelRaspuns;
    }
}

