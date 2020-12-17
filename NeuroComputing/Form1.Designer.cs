namespace NeuroComputing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.minFreqTextBox = new System.Windows.Forms.TextBox();
            this.maxFreqTextBox = new System.Windows.Forms.TextBox();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.sinusoidCentreButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCovariance = new System.Windows.Forms.Label();
            this.covarianceButton = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.readFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "(число осцилляций на N) Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "(число осцилляций на N) Max";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.Color.Yellow;
            this.resultLabel.Location = new System.Drawing.Point(222, 89);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minFreqTextBox
            // 
            this.minFreqTextBox.Location = new System.Drawing.Point(257, 13);
            this.minFreqTextBox.Name = "minFreqTextBox";
            this.minFreqTextBox.Size = new System.Drawing.Size(100, 26);
            this.minFreqTextBox.TabIndex = 3;
            // 
            // maxFreqTextBox
            // 
            this.maxFreqTextBox.Location = new System.Drawing.Point(257, 58);
            this.maxFreqTextBox.Name = "maxFreqTextBox";
            this.maxFreqTextBox.Size = new System.Drawing.Size(100, 26);
            this.maxFreqTextBox.TabIndex = 4;
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Location = new System.Drawing.Point(257, 144);
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(100, 26);
            this.stepsTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "общая длинна сигнала (N)";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(257, 105);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 26);
            this.NTextBox.TabIndex = 7;
            // 
            // sinusoidCentreButton
            // 
            this.sinusoidCentreButton.Location = new System.Drawing.Point(14, 76);
            this.sinusoidCentreButton.Name = "sinusoidCentreButton";
            this.sinusoidCentreButton.Size = new System.Drawing.Size(148, 47);
            this.sinusoidCentreButton.TabIndex = 8;
            this.sinusoidCentreButton.Text = "Centralization";
            this.sinusoidCentreButton.UseVisualStyleBackColor = true;
            this.sinusoidCentreButton.Click += new System.EventHandler(this.sinusoidCentreButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maxFreqTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.stepsTextBox);
            this.panel1.Controls.Add(this.minFreqTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 199);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "шаги";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCovariance);
            this.panel2.Controls.Add(this.covarianceButton);
            this.panel2.Controls.Add(this.sinusoidCentreButton);
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Controls.Add(this.readFileButton);
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Location = new System.Drawing.Point(13, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 337);
            this.panel2.TabIndex = 10;
            // 
            // labelCovariance
            // 
            this.labelCovariance.AutoSize = true;
            this.labelCovariance.ForeColor = System.Drawing.Color.Blue;
            this.labelCovariance.Location = new System.Drawing.Point(182, 259);
            this.labelCovariance.Name = "labelCovariance";
            this.labelCovariance.Size = new System.Drawing.Size(0, 20);
            this.labelCovariance.TabIndex = 3;
            // 
            // covarianceButton
            // 
            this.covarianceButton.Enabled = false;
            this.covarianceButton.Location = new System.Drawing.Point(10, 250);
            this.covarianceButton.Name = "covarianceButton";
            this.covarianceButton.Size = new System.Drawing.Size(137, 39);
            this.covarianceButton.TabIndex = 2;
            this.covarianceButton.Text = "Covariance";
            this.covarianceButton.UseVisualStyleBackColor = true;
            this.covarianceButton.Click += new System.EventHandler(this.covarianceButton_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.ForeColor = System.Drawing.Color.Blue;
            this.labelFileName.Location = new System.Drawing.Point(192, 187);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 20);
            this.labelFileName.TabIndex = 1;
            // 
            // readFileButton
            // 
            this.readFileButton.Enabled = false;
            this.readFileButton.Location = new System.Drawing.Point(11, 175);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(137, 44);
            this.readFileButton.TabIndex = 0;
            this.readFileButton.Text = "ReadFromFile";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox minFreqTextBox;
        private System.Windows.Forms.TextBox maxFreqTextBox;
        private System.Windows.Forms.TextBox stepsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Button sinusoidCentreButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button covarianceButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label labelCovariance;
        private System.Windows.Forms.Label label3;
    }
}

