namespace InPolgionSauNu
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(985, 430);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 437);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Deseneaza";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(82, 466);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(82, 493);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(12, 519);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "Verifica";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(375, 446);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(35, 13);
            this.labelResponse.TabIndex = 7;
            this.labelResponse.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Curata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "InPoligonSauNu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button button1;
    }
}

