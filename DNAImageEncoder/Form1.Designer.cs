namespace DNAImageEncoder
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
            this.DNASequanceTextBox = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumberOfLinesAndSymbols = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.labelPеrcent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAFreq = new System.Windows.Forms.Label();
            this.labelCFreq = new System.Windows.Forms.Label();
            this.labelGFreq = new System.Windows.Forms.Label();
            this.labelTFreq = new System.Windows.Forms.Label();
            this.labelAPercent = new System.Windows.Forms.Label();
            this.labelCPercent = new System.Windows.Forms.Label();
            this.labelGPercent = new System.Windows.Forms.Label();
            this.labelTPercent = new System.Windows.Forms.Label();
            this.buttonRandomGenerator = new System.Windows.Forms.Button();
            this.comboBoxRandomGenerator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelAllNucleotids = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DNASequanceTextBox
            // 
            this.DNASequanceTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.DNASequanceTextBox.Location = new System.Drawing.Point(12, 345);
            this.DNASequanceTextBox.Multiline = true;
            this.DNASequanceTextBox.Name = "DNASequanceTextBox";
            this.DNASequanceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DNASequanceTextBox.Size = new System.Drawing.Size(667, 110);
            this.DNASequanceTextBox.TabIndex = 0;
            this.DNASequanceTextBox.TextChanged += new System.EventHandler(this.DNASequanceTextBox_TextChanged);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(686, 345);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(102, 110);
            this.btnEncode.TabIndex = 1;
            this.btnEncode.Text = "Encod";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Nucleotide sequance (without whitespace). Encode up to 1500 pieces on page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNumberOfLinesAndSymbols
            // 
            this.labelNumberOfLinesAndSymbols.AutoSize = true;
            this.labelNumberOfLinesAndSymbols.Location = new System.Drawing.Point(9, 281);
            this.labelNumberOfLinesAndSymbols.Name = "labelNumberOfLinesAndSymbols";
            this.labelNumberOfLinesAndSymbols.Size = new System.Drawing.Size(141, 13);
            this.labelNumberOfLinesAndSymbols.TabIndex = 3;
            this.labelNumberOfLinesAndSymbols.Text = "Number of lines and symbols";
            this.labelNumberOfLinesAndSymbols.Click += new System.EventHandler(this.labelNumberOfLinesAndSymbols_Click);
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(729, 34);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(28, 13);
            this.labelFreq.TabIndex = 5;
            this.labelFreq.Text = "Freq";
            // 
            // labelPеrcent
            // 
            this.labelPеrcent.AutoSize = true;
            this.labelPеrcent.Location = new System.Drawing.Point(790, 34);
            this.labelPеrcent.Name = "labelPеrcent";
            this.labelPеrcent.Size = new System.Drawing.Size(44, 13);
            this.labelPеrcent.TabIndex = 6;
            this.labelPеrcent.Text = "Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(694, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(694, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(693, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "G:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(693, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "T:";
            // 
            // labelAFreq
            // 
            this.labelAFreq.AutoSize = true;
            this.labelAFreq.Location = new System.Drawing.Point(729, 63);
            this.labelAFreq.Name = "labelAFreq";
            this.labelAFreq.Size = new System.Drawing.Size(0, 13);
            this.labelAFreq.TabIndex = 11;
            // 
            // labelCFreq
            // 
            this.labelCFreq.AutoSize = true;
            this.labelCFreq.Location = new System.Drawing.Point(729, 95);
            this.labelCFreq.Name = "labelCFreq";
            this.labelCFreq.Size = new System.Drawing.Size(0, 13);
            this.labelCFreq.TabIndex = 12;
            // 
            // labelGFreq
            // 
            this.labelGFreq.AutoSize = true;
            this.labelGFreq.Location = new System.Drawing.Point(729, 129);
            this.labelGFreq.Name = "labelGFreq";
            this.labelGFreq.Size = new System.Drawing.Size(0, 13);
            this.labelGFreq.TabIndex = 13;
            // 
            // labelTFreq
            // 
            this.labelTFreq.AutoSize = true;
            this.labelTFreq.Location = new System.Drawing.Point(729, 163);
            this.labelTFreq.Name = "labelTFreq";
            this.labelTFreq.Size = new System.Drawing.Size(0, 13);
            this.labelTFreq.TabIndex = 14;
            // 
            // labelAPercent
            // 
            this.labelAPercent.AutoSize = true;
            this.labelAPercent.Location = new System.Drawing.Point(793, 63);
            this.labelAPercent.Name = "labelAPercent";
            this.labelAPercent.Size = new System.Drawing.Size(0, 13);
            this.labelAPercent.TabIndex = 15;
            // 
            // labelCPercent
            // 
            this.labelCPercent.AutoSize = true;
            this.labelCPercent.Location = new System.Drawing.Point(793, 94);
            this.labelCPercent.Name = "labelCPercent";
            this.labelCPercent.Size = new System.Drawing.Size(0, 13);
            this.labelCPercent.TabIndex = 16;
            // 
            // labelGPercent
            // 
            this.labelGPercent.AutoSize = true;
            this.labelGPercent.Location = new System.Drawing.Point(793, 129);
            this.labelGPercent.Name = "labelGPercent";
            this.labelGPercent.Size = new System.Drawing.Size(0, 13);
            this.labelGPercent.TabIndex = 17;
            // 
            // labelTPercent
            // 
            this.labelTPercent.AutoSize = true;
            this.labelTPercent.Location = new System.Drawing.Point(793, 163);
            this.labelTPercent.Name = "labelTPercent";
            this.labelTPercent.Size = new System.Drawing.Size(0, 13);
            this.labelTPercent.TabIndex = 18;
            // 
            // buttonRandomGenerator
            // 
            this.buttonRandomGenerator.Location = new System.Drawing.Point(793, 372);
            this.buttonRandomGenerator.Name = "buttonRandomGenerator";
            this.buttonRandomGenerator.Size = new System.Drawing.Size(132, 35);
            this.buttonRandomGenerator.TabIndex = 19;
            this.buttonRandomGenerator.Text = "Generate Random Sequence";
            this.buttonRandomGenerator.UseVisualStyleBackColor = true;
            this.buttonRandomGenerator.Click += new System.EventHandler(this.buttonRandomGenerator_Click);
            // 
            // comboBoxRandomGenerator
            // 
            this.comboBoxRandomGenerator.FormattingEnabled = true;
            this.comboBoxRandomGenerator.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "500",
            "1000",
            "2000",
            "5000",
            "10000"});
            this.comboBoxRandomGenerator.Location = new System.Drawing.Point(793, 345);
            this.comboBoxRandomGenerator.Name = "comboBoxRandomGenerator";
            this.comboBoxRandomGenerator.Size = new System.Drawing.Size(132, 21);
            this.comboBoxRandomGenerator.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Random Sequence Length";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(523, 309);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(604, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(601, 281);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 24;
            this.labelPages.Text = "Pages";
            // 
            // labelAllNucleotids
            // 
            this.labelAllNucleotids.AutoSize = true;
            this.labelAllNucleotids.Location = new System.Drawing.Point(13, 462);
            this.labelAllNucleotids.Name = "labelAllNucleotids";
            this.labelAllNucleotids.Size = new System.Drawing.Size(71, 13);
            this.labelAllNucleotids.TabIndex = 25;
            this.labelAllNucleotids.Text = "All Nucleotids";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(997, 499);
            this.Controls.Add(this.labelAllNucleotids);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxRandomGenerator);
            this.Controls.Add(this.buttonRandomGenerator);
            this.Controls.Add(this.labelTPercent);
            this.Controls.Add(this.labelGPercent);
            this.Controls.Add(this.labelCPercent);
            this.Controls.Add(this.labelAPercent);
            this.Controls.Add(this.labelTFreq);
            this.Controls.Add(this.labelGFreq);
            this.Controls.Add(this.labelCFreq);
            this.Controls.Add(this.labelAFreq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPеrcent);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.labelNumberOfLinesAndSymbols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.DNASequanceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DNAImageEncoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNASequanceTextBox;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumberOfLinesAndSymbols;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Label labelPеrcent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAFreq;
        private System.Windows.Forms.Label labelCFreq;
        private System.Windows.Forms.Label labelGFreq;
        private System.Windows.Forms.Label labelTFreq;
        private System.Windows.Forms.Label labelAPercent;
        private System.Windows.Forms.Label labelCPercent;
        private System.Windows.Forms.Label labelGPercent;
        private System.Windows.Forms.Label labelTPercent;
        private System.Windows.Forms.Button buttonRandomGenerator;
        private System.Windows.Forms.ComboBox comboBoxRandomGenerator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelAllNucleotids;
    }
}

