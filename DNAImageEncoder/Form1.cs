using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNAImageEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string input = string.Empty;
        char[] arrayNucleo = { 'A', 'C', 'G', 'T' };
        int countNumbersNucleotids = 0;
        public static int subSequenceLength = 0;
        public static int countPages = 1;
        //public static int allDNASeqLength = DNASequanceTextBox.Text.Length;
        public static int allPages = 0;
        bool checkLastPage = false;
        bool checkFirstPage = false;

        Pen red = new Pen(Color.Red);
        Pen blue = new Pen(Color.Blue);
        Pen green = new Pen(Color.Green);
        Pen yellow = new Pen(Color.Yellow);

        SolidBrush fillRed = new SolidBrush(Color.Red);
        SolidBrush fillBlue = new SolidBrush(Color.Blue);
        SolidBrush fillGreen = new SolidBrush(Color.Green);
        SolidBrush fillYellow = new SolidBrush(Color.Yellow);
        SolidBrush fillBlack = new SolidBrush(Color.Black);
        //Brush brush = new Brush();

        Rectangle rect = new Rectangle(10, 10, 10, 10);//in this order (position, position, width, height)
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 10;
            int y = 20;
            int allNucleotides = 0;
            int countOfLines = 0;
            //int xGetValue = 0;
            int allDNASeqLength = DNASequanceTextBox.Text.Length;
            allPages = allDNASeqLength / 1500 + 1;

            Dictionary<char, double> dict = new Dictionary<char, double>()
            {
                {'A', 0.0},
                {'C', 0.0},
                {'G', 0.0},
                {'T', 0.0}
            };

            //==============================================================

            string dna = input.ToUpper();

            if (dna.Length <= 1500)
            {
                for (int index = 0; index < dna.Length; index++)
                {

                    if (char.IsWhiteSpace(dna[index]) || index % 66 == 0)//White space or new line
                    {
                        y += 10; //move to the next line
                        x = 15;  //begin а new line 
                        countOfLines++;
                    }

                    rect = new Rectangle(x, y, 10, 10);

                    if (dna[index] == 'A' || dna[index] == 'А')
                    {
                        g.DrawRectangle(blue, rect);
                        g.FillRectangle(fillBlue, rect);
                        allNucleotides++;
                        dict['A'] += 1;
                    }
                    else if (dna[index] == 'G' || dna[index] == 'Г')
                    {
                        g.DrawRectangle(green, rect);
                        g.FillRectangle(fillGreen, rect);
                        allNucleotides++;
                        dict['G'] += 1;
                    }
                    else if (dna[index] == 'C' || dna[index] == 'Ц')
                    {
                        g.DrawRectangle(red, rect);
                        g.FillRectangle(fillRed, rect);
                        allNucleotides++;
                        dict['C'] += 1;
                    }
                    else if (dna[index] == 'T' || dna[index] == 'Т')
                    {
                        g.DrawRectangle(yellow, rect);
                        g.FillRectangle(fillYellow, rect);
                        allNucleotides++;
                        dict['T'] += 1;
                    }
                    else if (!char.IsWhiteSpace(dna[index]))
                    {
                        label1.Text = "Use letters on EN (A, G, C, T) or on Cyrillic (А, Г, Ц, Т)";
                    }
                    if (index % 66 == 0)//Draw number of lines
                    {
                        //xGetValue = x;
                        //xGetValue += 10 * 66;
                        g.DrawString($"{countOfLines}", Font, fillBlack, 0, y);
                    }

                    x += 10; // Move to the next square on the same line
                }

                //========================================================================================

                foreach (var letter in dict)
                {
                    if (letter.Key == 'A')
                    {
                        labelAFreq.Text = $"{letter.Value}";
                        labelAPercent.Text = $"{(letter.Value / allNucleotides) * 100:F2} %";
                    }
                    else if (letter.Key == 'C')
                    {
                        labelCFreq.Text = $"{letter.Value}";
                        labelCPercent.Text = $"{(letter.Value / allNucleotides) * 100:F2} %";
                    }
                    else if (letter.Key == 'G')
                    {
                        labelGFreq.Text = $"{letter.Value}";
                        labelGPercent.Text = $"{(letter.Value / allNucleotides) * 100:F2} %";
                    }
                    else if (letter.Key == 'T')
                    {
                        labelTFreq.Text = $"{letter.Value}";
                        labelTPercent.Text = $"{(letter.Value / allNucleotides) * 100:F2} %";
                    }
                }
                labelNumberOfLinesAndSymbols.Text = $"{countOfLines} lines {allNucleotides} nucleotides";
                labelPages.Text = $"Page {countPages} - {allPages}";
                labelAllNucleotids.Text = $"All Nucleotids: {DNASequanceTextBox.Text.Length}";
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            //labelPages.Text = $"Page 1 - {allPages}";
            countNumbersNucleotids = 0;
            countPages = 1;
            checkLastPage = false;
            checkFirstPage = false;
            if (DNASequanceTextBox.Text.Length >= 1500)
            {
                input = DNASequanceTextBox.Text.Substring(0, 1500);
            }
            else
            {
                input = DNASequanceTextBox.Text.Substring(0, DNASequanceTextBox.Text.Length);
            }
            this.Invalidate();
        }

        private void DNASequanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNumberOfLinesAndSymbols_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandomGenerator_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            StringBuilder sbRndSequence = new StringBuilder();
            int randomGeneratorLength = int.Parse(comboBoxRandomGenerator.Text);
            int timesToFillStringBuilderWithRandomNucleotids = randomGeneratorLength / arrayNucleo.Length;
            allPages = 0;
            countPages = 1;
            checkLastPage = false;
            countNumbersNucleotids = 0;

            for (int i = 0; i < timesToFillStringBuilderWithRandomNucleotids; i++)
            {
                for (int j = 0; j < arrayNucleo.Length; j++)//4
                {
                    sbRndSequence.Append(arrayNucleo[rnd.Next(arrayNucleo.Length)]);
                }
            }
            DNASequanceTextBox.Text = sbRndSequence.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int allDNASeqLength = DNASequanceTextBox.Text.Length;
            allPages = allDNASeqLength / 1500 + 1;
            checkFirstPage = false;
            //if (checkLastPage == false)
            //{

            //}
            if (allDNASeqLength >= 1500)
            {
                if (allDNASeqLength > countNumbersNucleotids)
                {
                    if (checkLastPage == false)
                    {
                        countPages++;
                        countNumbersNucleotids += 1500;

                    }
                    subSequenceLength = 1500;
                }
                if (countNumbersNucleotids + 1500 > allDNASeqLength)//Check for last page
                {
                    subSequenceLength = allDNASeqLength - countNumbersNucleotids;
                    //countNumbersNucleotids -= 1500;
                    checkLastPage = true;

                }

                if (countNumbersNucleotids >= 1500 && countNumbersNucleotids < 3000)
                {
                    input = DNASequanceTextBox.Text.Substring(1500, subSequenceLength);
                }
                else if (countNumbersNucleotids >= 3000 && countNumbersNucleotids < 4500)
                {
                    input = DNASequanceTextBox.Text.Substring(3000, subSequenceLength);
                }
                else if (countNumbersNucleotids >= 4500 && countNumbersNucleotids < 6000)
                {
                    input = DNASequanceTextBox.Text.Substring(4500, subSequenceLength);
                }
                else if (countNumbersNucleotids >= 6000 && countNumbersNucleotids < 7500)
                {
                    input = DNASequanceTextBox.Text.Substring(6000, subSequenceLength);
                }
                else if (countNumbersNucleotids >= 7500 && countNumbersNucleotids < 9000)
                {
                    input = DNASequanceTextBox.Text.Substring(7500, subSequenceLength);
                }
                else if (countNumbersNucleotids >= 9000 && countNumbersNucleotids < 10000)
                {
                    input = DNASequanceTextBox.Text.Substring(9000, subSequenceLength);
                }

                labelPages.Text = $"Page {countPages} - {allPages}";
                //}
            }
            this.Invalidate();

        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int allDNASeqLength = DNASequanceTextBox.Text.Length;
            allPages = allDNASeqLength / 1500 + 1;
            checkLastPage = false;
            subSequenceLength = 1500;

            if (countNumbersNucleotids >= 1500)
            {
                if (allDNASeqLength > countNumbersNucleotids)
                {
                    if (checkFirstPage == false && countPages > 1)
                    {
                        countPages--;
                        countNumbersNucleotids -= 1500;

                    }
                    //subSequenceLength = 1500;
                }
                if (countNumbersNucleotids == 0)//Check for first page
                {
                    //subSequenceLength = 1500;
                    checkFirstPage = true;
                }
                if (countNumbersNucleotids < 1500)
                {
                    input = DNASequanceTextBox.Text.Substring(0, subSequenceLength);
                    labelPages.Text = $"Page 1 - {allPages}";
                }
                else if (countNumbersNucleotids >= 1500 && countNumbersNucleotids < 3000)
                {
                    input = DNASequanceTextBox.Text.Substring(1500, subSequenceLength);
                    labelPages.Text = $"Page 1 - {allPages}";
                }
                else if (countNumbersNucleotids >= 3000 && countNumbersNucleotids < 4500)
                {
                    input = DNASequanceTextBox.Text.Substring(3000, subSequenceLength);
                    labelPages.Text = $"Page 2 - {allPages}";
                }
                else if (countNumbersNucleotids >= 4500 && countNumbersNucleotids < 6000)
                {
                    input = DNASequanceTextBox.Text.Substring(4500, subSequenceLength);
                    labelPages.Text = $"Page 3 - {allPages}";
                }
                else if (countNumbersNucleotids >= 6000 && countNumbersNucleotids < 7500)
                {
                    input = DNASequanceTextBox.Text.Substring(6000, subSequenceLength);
                    labelPages.Text = $"Page 4 - {allPages}";
                }
                else if (countNumbersNucleotids >= 7500 && countNumbersNucleotids < 9000)
                {
                    input = DNASequanceTextBox.Text.Substring(7500, subSequenceLength);
                    labelPages.Text = $"Page 5 - {allPages}";
                }
                else if (countNumbersNucleotids >= 9000 && countNumbersNucleotids < 10000)
                {
                    input = DNASequanceTextBox.Text.Substring(9000, subSequenceLength);
                    labelPages.Text = $"Page 6 - {allPages}";
                }

                //labelPages.Text = $"Page {countPages} - {allPages}";
                //}
            }
            this.Invalidate();
        }
    }
}

