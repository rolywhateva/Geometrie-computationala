namespace Triunghi
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
            this.buttonDesenare = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelAB = new System.Windows.Forms.Label();
            this.labelAC = new System.Windows.Forms.Label();
            this.labelBC = new System.Windows.Forms.Label();
            this.BoxLiniiMijlocii = new System.Windows.Forms.CheckBox();
            this.BoxMediana = new System.Windows.Forms.CheckBox();
            this.BoxBisectoare = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(0, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1068, 502);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonDesenare
            // 
            this.buttonDesenare.Location = new System.Drawing.Point(799, 563);
            this.buttonDesenare.Name = "buttonDesenare";
            this.buttonDesenare.Size = new System.Drawing.Size(139, 44);
            this.buttonDesenare.TabIndex = 1;
            this.buttonDesenare.Text = "Deseneaza";
            this.buttonDesenare.UseVisualStyleBackColor = true;
            this.buttonDesenare.Click += new System.EventHandler(this.buttonDesenare_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(98, 539);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(48, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Punct A ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(98, 563);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(48, 13);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Punct A ";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(98, 594);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(48, 13);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Punct A ";
            // 
            // labelAB
            // 
            this.labelAB.AutoSize = true;
            this.labelAB.Location = new System.Drawing.Point(226, 539);
            this.labelAB.Name = "labelAB";
            this.labelAB.Size = new System.Drawing.Size(21, 13);
            this.labelAB.TabIndex = 5;
            this.labelAB.Text = "AB";
            // 
            // labelAC
            // 
            this.labelAC.AutoSize = true;
            this.labelAC.Location = new System.Drawing.Point(226, 563);
            this.labelAC.Name = "labelAC";
            this.labelAC.Size = new System.Drawing.Size(21, 13);
            this.labelAC.TabIndex = 6;
            this.labelAC.Text = "AB";
            // 
            // labelBC
            // 
            this.labelBC.AutoSize = true;
            this.labelBC.Location = new System.Drawing.Point(226, 594);
            this.labelBC.Name = "labelBC";
            this.labelBC.Size = new System.Drawing.Size(21, 13);
            this.labelBC.TabIndex = 7;
            this.labelBC.Text = "AB";
            // 
            // BoxLiniiMijlocii
            // 
            this.BoxLiniiMijlocii.AutoSize = true;
            this.BoxLiniiMijlocii.Location = new System.Drawing.Point(429, 578);
            this.BoxLiniiMijlocii.Name = "BoxLiniiMijlocii";
            this.BoxLiniiMijlocii.Size = new System.Drawing.Size(83, 17);
            this.BoxLiniiMijlocii.TabIndex = 8;
            this.BoxLiniiMijlocii.Text = "LinieMijlocie";
            this.BoxLiniiMijlocii.UseVisualStyleBackColor = true;
            this.BoxLiniiMijlocii.Click += new System.EventHandler(this.BoxLiniiMijlocii_Click);
            // 
            // BoxMediana
            // 
            this.BoxMediana.AutoSize = true;
            this.BoxMediana.Location = new System.Drawing.Point(429, 602);
            this.BoxMediana.Name = "BoxMediana";
            this.BoxMediana.Size = new System.Drawing.Size(67, 17);
            this.BoxMediana.TabIndex = 9;
            this.BoxMediana.Text = "Mediana";
            this.BoxMediana.UseVisualStyleBackColor = true;
            // 
            // BoxBisectoare
            // 
            this.BoxBisectoare.AutoSize = true;
            this.BoxBisectoare.Location = new System.Drawing.Point(429, 626);
            this.BoxBisectoare.Name = "BoxBisectoare";
            this.BoxBisectoare.Size = new System.Drawing.Size(76, 17);
            this.BoxBisectoare.TabIndex = 10;
            this.BoxBisectoare.Text = "Bisectoare";
            this.BoxBisectoare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 747);
            this.Controls.Add(this.BoxBisectoare);
            this.Controls.Add(this.BoxMediana);
            this.Controls.Add(this.BoxLiniiMijlocii);
            this.Controls.Add(this.labelBC);
            this.Controls.Add(this.labelAC);
            this.Controls.Add(this.labelAB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonDesenare);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonDesenare;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelAB;
        private System.Windows.Forms.Label labelAC;
        private System.Windows.Forms.Label labelBC;
        private System.Windows.Forms.CheckBox BoxLiniiMijlocii;
        private System.Windows.Forms.CheckBox BoxMediana;
        private System.Windows.Forms.CheckBox BoxBisectoare;
    }
}

