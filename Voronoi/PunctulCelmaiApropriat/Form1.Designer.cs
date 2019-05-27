namespace PunctulCelmaiApropriat
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
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelCordonate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(803, 377);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(99, 382);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 20);
            this.inputX.TabIndex = 1;
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(291, 382);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(100, 20);
            this.inputY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(586, 385);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(202, 23);
            this.buttonDraw.TabIndex = 5;
            this.buttonDraw.Text = "Deseneaza punctele";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(586, 414);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(203, 22);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Text = "Verifica punctul";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelCordonate
            // 
            this.labelCordonate.AutoSize = true;
            this.labelCordonate.Location = new System.Drawing.Point(46, 425);
            this.labelCordonate.Name = "labelCordonate";
            this.labelCordonate.Size = new System.Drawing.Size(78, 13);
            this.labelCordonate.TabIndex = 8;
            this.labelCordonate.Text = "labelCordonate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.labelCordonate);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputY);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "PunctulCelMaiApropriat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelCordonate;
    }
}

