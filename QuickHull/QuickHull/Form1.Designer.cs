namespace QuickHull
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
            this.butonGenerare = new System.Windows.Forms.Button();
            this.UpDownPointCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSet1 = new System.Windows.Forms.Button();
            this.ButtonSet2 = new System.Windows.Forms.Button();
            this.ButonSet3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(877, 559);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // butonGenerare
            // 
            this.butonGenerare.Location = new System.Drawing.Point(12, 591);
            this.butonGenerare.Name = "butonGenerare";
            this.butonGenerare.Size = new System.Drawing.Size(214, 40);
            this.butonGenerare.TabIndex = 1;
            this.butonGenerare.Text = "Genereaza aleator";
            this.butonGenerare.UseVisualStyleBackColor = true;
            this.butonGenerare.Click += new System.EventHandler(this.butonGenerare_Click);
            // 
            // UpDownPointCount
            // 
            this.UpDownPointCount.Location = new System.Drawing.Point(106, 565);
            this.UpDownPointCount.Name = "UpDownPointCount";
            this.UpDownPointCount.Size = new System.Drawing.Size(120, 20);
            this.UpDownPointCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nr. de puncte";
            // 
            // ButtonSet1
            // 
            this.ButtonSet1.Location = new System.Drawing.Point(389, 584);
            this.ButtonSet1.Name = "ButtonSet1";
            this.ButtonSet1.Size = new System.Drawing.Size(152, 54);
            this.ButtonSet1.TabIndex = 4;
            this.ButtonSet1.Text = "Set1";
            this.ButtonSet1.UseVisualStyleBackColor = true;
            this.ButtonSet1.Click += new System.EventHandler(this.ButtonSet1_Click);
            // 
            // ButtonSet2
            // 
            this.ButtonSet2.Location = new System.Drawing.Point(621, 584);
            this.ButtonSet2.Name = "ButtonSet2";
            this.ButtonSet2.Size = new System.Drawing.Size(152, 54);
            this.ButtonSet2.TabIndex = 5;
            this.ButtonSet2.Text = "Set2";
            this.ButtonSet2.UseVisualStyleBackColor = true;
            this.ButtonSet2.Click += new System.EventHandler(this.ButtonSet2_Click);
            // 
            // ButonSet3
            // 
            this.ButonSet3.Location = new System.Drawing.Point(494, 663);
            this.ButonSet3.Name = "ButonSet3";
            this.ButonSet3.Size = new System.Drawing.Size(172, 54);
            this.ButonSet3.TabIndex = 6;
            this.ButonSet3.Text = "Set3";
            this.ButonSet3.UseVisualStyleBackColor = true;
            this.ButonSet3.Click += new System.EventHandler(this.ButonSet3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 795);
            this.Controls.Add(this.ButonSet3);
            this.Controls.Add(this.ButtonSet2);
            this.Controls.Add(this.ButtonSet1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownPointCount);
            this.Controls.Add(this.butonGenerare);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Quick Hull";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button butonGenerare;
        private System.Windows.Forms.NumericUpDown UpDownPointCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSet1;
        private System.Windows.Forms.Button ButtonSet2;
        private System.Windows.Forms.Button ButonSet3;
    }
}

