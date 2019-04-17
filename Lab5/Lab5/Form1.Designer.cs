namespace Lab5
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
            this.pB = new System.Windows.Forms.PictureBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.labelIndic = new System.Windows.Forms.Label();
            this.labelPuncte = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // pB
            // 
            this.pB.Location = new System.Drawing.Point(-6, 0);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(878, 392);
            this.pB.TabIndex = 0;
            this.pB.TabStop = false;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(779, 398);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(93, 40);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelIndic
            // 
            this.labelIndic.AutoSize = true;
            this.labelIndic.Location = new System.Drawing.Point(179, 411);
            this.labelIndic.Name = "labelIndic";
            this.labelIndic.Size = new System.Drawing.Size(44, 13);
            this.labelIndic.TabIndex = 2;
            this.labelIndic.Text = "Puncte:";
            // 
            // labelPuncte
            // 
            this.labelPuncte.AutoSize = true;
            this.labelPuncte.Location = new System.Drawing.Point(245, 410);
            this.labelPuncte.Name = "labelPuncte";
            this.labelPuncte.Size = new System.Drawing.Size(66, 13);
            this.labelPuncte.TabIndex = 3;
            this.labelPuncte.Text = "label Puncte";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(658, 398);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(99, 40);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPuncte);
            this.Controls.Add(this.labelIndic);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.pB);
            this.Name = "Form1";
            this.Text = "Scanare Graham";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label labelIndic;
        private System.Windows.Forms.Label labelPuncte;
        private System.Windows.Forms.Button buttonNext;
    }
}

