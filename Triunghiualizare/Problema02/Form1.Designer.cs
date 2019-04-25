namespace Problema02
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
            this.ButtonAddPoint = new System.Windows.Forms.Button();
            this.labelPuncte = new System.Windows.Forms.Label();
            this.ButtonDesenare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(928, 427);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ButtonAddPoint
            // 
            this.ButtonAddPoint.Location = new System.Drawing.Point(805, 558);
            this.ButtonAddPoint.Name = "ButtonAddPoint";
            this.ButtonAddPoint.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddPoint.TabIndex = 1;
            this.ButtonAddPoint.Text = "Adauga Punct";
            this.ButtonAddPoint.UseVisualStyleBackColor = true;
            this.ButtonAddPoint.Click += new System.EventHandler(this.ButtonAddPoint_Click);
            // 
            // labelPuncte
            // 
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.Location = new System.Drawing.Point(465, 463);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(41, 13);
            this.labelPuncte.TabIndex = 2;
            this.labelPuncte.Text = "Puncte";
            // 
            // ButtonDesenare
            // 
            this.ButtonDesenare.Location = new System.Drawing.Point(724, 558);
            this.ButtonDesenare.Name = "ButtonDesenare";
            this.ButtonDesenare.Size = new System.Drawing.Size(75, 23);
            this.ButtonDesenare.TabIndex = 3;
            this.ButtonDesenare.Text = "Deseneaza";
            this.ButtonDesenare.UseVisualStyleBackColor = true;
            this.ButtonDesenare.Click += new System.EventHandler(this.ButtonDesenare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(47, 430);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(47, 456);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(633, 558);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 593);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonDesenare);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.ButtonAddPoint);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Problema2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ButtonAddPoint;
        private System.Windows.Forms.Label labelPuncte;
        private System.Windows.Forms.Button ButtonDesenare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonClear;
    }
}

