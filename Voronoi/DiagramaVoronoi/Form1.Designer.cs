namespace DiagramaVoronoi
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
            this.textBoxNrPuncte = new System.Windows.Forms.TextBox();
            this.labelTextNrPuncte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, -2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(970, 425);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(484, 439);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Desenare";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxNrPuncte
            // 
            this.textBoxNrPuncte.Location = new System.Drawing.Point(735, 442);
            this.textBoxNrPuncte.Name = "textBoxNrPuncte";
            this.textBoxNrPuncte.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrPuncte.TabIndex = 2;
            // 
            // labelTextNrPuncte
            // 
            this.labelTextNrPuncte.AutoSize = true;
            this.labelTextNrPuncte.Location = new System.Drawing.Point(618, 439);
            this.labelTextNrPuncte.Name = "labelTextNrPuncte";
            this.labelTextNrPuncte.Size = new System.Drawing.Size(75, 13);
            this.labelTextNrPuncte.TabIndex = 3;
            this.labelTextNrPuncte.Text = "Nr. de puncte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 535);
            this.Controls.Add(this.labelTextNrPuncte);
            this.Controls.Add(this.textBoxNrPuncte);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Diagrama Voronoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxNrPuncte;
        private System.Windows.Forms.Label labelTextNrPuncte;
    }
}

