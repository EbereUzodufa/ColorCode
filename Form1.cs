using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
//using System.


namespace Color_Coder
{
    public partial class Form1 : Form
    {
        string redColor, blueColor, greenColor;
        string valueR, valueG, valueB;
        Int32 lstInd;
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorHex(object sender, EventArgs e)
        {
            try
            {

                if (txtHexa.TextLength>5)
                {
                    string hexText = txtHexa.Text.ToLower();
                    redColor = hexText.Substring(0, 2);
                    greenColor= hexText.Substring(2, 2);
                    blueColor = hexText.Substring(4, 2);
                }
                else
                {
                    return;
                    //I dey look you (-__-)
                }
                
            }
            catch (Exception ex)
            {
               
            }
           

        }

        private void txtHexa_TextChanged(object sender, EventArgs e)
        {
            if (txtHexa.TextLength==6)
            {
                Regex word = new Regex("^[a-fA-F0-9]*$"); //Strictly no NoN-AlphaNumeric Character
                if (word.IsMatch(txtHexa.Text))
                {
                    ColorHex(sender, e);
                    calColr(sender, e);
                }
                else
                {
                    MessageBox.Show("Check for NoN-AlphaNumeric Character and Alphabets after 'F'." +"\r\n"+ "Remove any Found");
                }
                
            }
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDownR.Value>1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownR.Text);
                if (maxVal > 255)
                {
                    numericUpDownR.BackColor = Color.IndianRed;
                    labelRG.Show();
                   // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownR.BackColor = Color.WhiteSmoke;
                    labelRG.Hide();
                }
            }
            
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDownG.Value > 1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownG.Text);
                if (maxVal > 255)
                {
                    numericUpDownG.BackColor = Color.IndianRed;
                    labelGG.Show();
                    // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownG.BackColor = Color.WhiteSmoke;
                    labelGG.Hide();
                }
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDownB.Value > 1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownB.Text);
                if (maxVal > 255)
                {
                    numericUpDownB.BackColor = Color.IndianRed;
                    labelBG.Show();
                    // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownB.BackColor = Color.WhiteSmoke;
                    labelBG.Hide();
                }
            }
        }

        private void calColr(object sender, EventArgs e)
        {
            string redColor1, redColor2, blueColor1, blueColor2, greenColor1, greenColor2;
            Int32 redcolorVal1 = 0, redcolorVal2 = 0, bluecolorVal1 = 0, bluecolorVal2 = 0, greencolorVal1 = 0, greencolorVal2=0;
            redColor1 = redColor.Substring(0, 1);
            redColor2 = redColor.Substring(1, 1);
            blueColor1 = blueColor.Substring(0, 1);
            blueColor2 = blueColor.Substring(1, 1);
            greenColor1 = greenColor.Substring(0, 1);
            greenColor2 = greenColor.Substring(1, 1);

            //Red Code 1
            if (redColor1=="a")
            {
                redcolorVal1 = 10;
            }
            else if (redColor1 == "b")
            {
                redcolorVal1 = 11;
            }
            else if (redColor1 == "c")
            {
                redcolorVal1 = 12;
            }
            else if (redColor1 == "d")
            {
                redcolorVal1 = 13;
            }
            else if (redColor1 == "e")
            {
                redcolorVal1 = 14;
            }
            else if (redColor1 == "f")
            {
                redcolorVal1 = 15;
            }
            else
            {
                redcolorVal1 = Convert.ToInt32(redColor1);
            }

            //Red 2
            if (redColor2 == "a")
            {
                redcolorVal2 = 10;
            }
            else if (redColor2 == "b")
            {
                redcolorVal2 = 11;
            }
            else if (redColor2 == "c")
            {
                redcolorVal2 = 12;
            }
            else if (redColor2 == "d")
            {
                redcolorVal2 = 13;
            }
            else if (redColor2 == "e")
            {
                redcolorVal2 = 14;
            }
            else if (redColor2 == "f")
            {
                redcolorVal2 = 15;
            }
            else
            {
                redcolorVal2 = Convert.ToInt32(redColor2);
            }

            //green Code 1
            if (greenColor1 == "a")
            {
                greencolorVal1 = 10;
            }
            else if (greenColor1 == "b")
            {
                greencolorVal1 = 11;
            }
            else if (greenColor1 == "c")
            {
                greencolorVal1 = 12;
            }
            else if (greenColor1 == "d")
            {
                greencolorVal1 = 13;
            }
            else if (greenColor1 == "e")
            {
                greencolorVal1 = 14;
            }
            else if (greenColor1 == "f")
            {
                greencolorVal1 = 15;
            }
            else
            {
                greencolorVal1 = Convert.ToInt32(greenColor1);
            }

            //green 2
            if (greenColor2 == "a")
            {
                greencolorVal2 = 10;
            }
            else if (greenColor2 == "b")
            {
                greencolorVal2 = 11;
            }
            else if (greenColor2 == "c")
            {
                greencolorVal2 = 12;
            }
            else if (greenColor2 == "d")
            {
                greencolorVal2 = 13;
            }
            else if (greenColor2 == "e")
            {
                greencolorVal2 = 14;
            }
            else if (greenColor2 == "f")
            {
                greencolorVal2 = 15;
            }
            else
            {
                greencolorVal2 = Convert.ToInt32(greenColor2);
            }
            //blue Code 1
            if (blueColor1 == "a")
            {
                bluecolorVal1 = 10;
            }
            else if (blueColor1 == "b")
            {
                bluecolorVal1 = 11;
            }
            else if (blueColor1 == "c")
            {
                bluecolorVal1 = 12;
            }
            else if (blueColor1 == "d")
            {
                bluecolorVal1 = 13;
            }
            else if (blueColor1 == "e")
            {
                bluecolorVal1 = 14;
            }
            else if (blueColor1 == "f")
            {
                bluecolorVal1 = 15;
            }
            else
            {
                bluecolorVal1 = Convert.ToInt32(blueColor1);
            }

            //blue 2
            if (blueColor2 == "a")
            {
                bluecolorVal2 = 10;
            }
            else if (blueColor2 == "b")
            {
                bluecolorVal2 = 11;
            }
            else if (blueColor2 == "c")
            {
                bluecolorVal2 = 12;
            }
            else if (blueColor2 == "d")
            {
                bluecolorVal2 = 13;
            }
            else if (blueColor2 == "e")
            {
                bluecolorVal2 = 14;
            }
            else if (blueColor2 == "f")
            {
                bluecolorVal2 = 15;
            }
            else
            {
                bluecolorVal2 = Convert.ToInt32(blueColor2);
            }

            Int32 R, B, G;
            R = (16 * redcolorVal1) + redcolorVal2;
            B = (16 * bluecolorVal1) + bluecolorVal2;
            G = (16 * greencolorVal1) + greencolorVal2;

            panel1.BackColor = Color.FromArgb(R,G,B);

            numericUpDownR.Text =   R.ToString();
            numericUpDownB.Text = B.ToString();
            numericUpDownG.Text = G.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ColorHex(sender, e);
            //MessageBox.Show("Red=" + redColor + ";" + "\r\n" + "Blue=" + blueColor + ";" + "\r\n" + "Green=" + greenColor + ";");
            Random rand = new Random();
            int numR = rand.Next(0, 255);
            int numG = rand.Next(0, 255);
            int numB = rand.Next(0, 255);
            numericUpDownR.Value = numR;
            numericUpDownG.Value = numG;
            numericUpDownB.Value = numB;
            string colorz = txtHexa.Text; //the hexa value of color
            lstCol.Items.Add(colorz);
            lblShow.Show();

            if (lstCol.Items.Count>0)
            {
                btnPrev.Show();
            }

            if (lstCol.Items.Count>1)
            {
                btnNext.Show();
            }

            lstInd = lstCol.Items.Count;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lstInd = lstInd - 1;
            lstCol.SelectedIndex = lstInd;
            txtHexa.Text = lstCol.SelectedItem.ToString();
            btnNext.Enabled = true;

            PrevNext(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            lstInd = lstInd + 1;
            lstCol.SelectedIndex = lstInd;
            txtHexa.Text = lstCol.SelectedItem.ToString();
            btnPrev.Enabled = true;

            PrevNext(sender, e);
        }

        private void numericUpDownR_ValueChange(object sender, EventArgs e)
        {
            if (numericUpDownR.Value > 1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownR.Text);
                if (maxVal > 255)
                {
                    numericUpDownR.BackColor = Color.IndianRed;
                    labelRG.Show();
                    // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownR.BackColor = Color.WhiteSmoke;
                    labelRG.Hide();
                    rgba(sender, e);
                }
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text== "Show History")
            {
                lstCol.Show();
                lblShow.Text = "Hide History";
            }
            else if (lblShow.Text == "Hide History")
            {
                lstCol.Hide();
                lblShow.Text = "Show History";
            }
        }

        private void lstCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHexa.Text = lstCol.SelectedItem.ToString();
            PrevNext(sender, e);
        }

        private void numericUpDownG_ValueChange(object sender, EventArgs e)
        {
            if (numericUpDownG.Value > 1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownG.Text);
                if (maxVal > 255)
                {
                    numericUpDownG.BackColor = Color.IndianRed;
                    labelGG.Show();
                    // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownG.BackColor = Color.WhiteSmoke;
                    labelGG.Hide();
                    rgba(sender, e);
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form hu = new Form2();
            hu.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            //lblClose.ForeColor = Color.Black;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            //lblClose.ForeColor = Color.WhiteSmoke;
        }

        private void numericUpDownB_ValueChange(object sender, EventArgs e)
        {
            if (numericUpDownB.Value > 1)
            {
                Int32 maxVal = Convert.ToInt32(numericUpDownB.Text);
                if (maxVal > 255)
                {
                    numericUpDownB.BackColor = Color.IndianRed;
                    labelBG.Show();
                    // MessageBox.Show(maxVal.ToString());
                }
                else
                {
                    //Smiles
                    numericUpDownB.BackColor = Color.WhiteSmoke;
                    labelBG.Hide();
                    rgba(sender, e);
                }
            }         
        }

        private void rgba(object sender, EventArgs e)
        {
            Int32  theR = Convert.ToInt32(numericUpDownR.Text);
            Int32 theG = Convert.ToInt32(numericUpDownG.Text);
            Int32 theB = Convert.ToInt32(numericUpDownB.Text);

            Int32 val1R, val2R, val1G, val2G, val1B, val2B;
            string valCod1R, valCod2R, valCod1G, valCod2G, valCod1B, valCod2B;

            //The R-Values
            if (theR<16)
            {
                val2R = theR % 16; //Moduluds function in C#
                val1R = 0;
            }
            else
            {
                val2R = theR % 16;
                val1R = (theR - val2R) / 16;
            }

            //Converting value val1R
            if (val1R==10)
            {
                valCod1R = "a";
            }
            else if (val1R == 11)
            {
                valCod1R = "b";
            }
            else if (val1R == 12)
            {
                valCod1R = "c";
            }
            else if (val1R == 13)
            {
                valCod1R = "d";
            }
            else if (val1R == 14)
            {
                valCod1R = "e";
            }
            else if (val1R == 15)
            {
                valCod1R = "f";
            }
            else
            {
                valCod1R = val1R.ToString();
            }

            //Converting value val2R
            if (val2R == 10)
            {
                valCod2R = "a";
            }
            else if (val2R == 11)
            {
                valCod2R = "b";
            }
            else if (val2R == 12)
            {
                valCod2R = "c";
            }
            else if (val2R == 13)
            {
                valCod2R = "d";
            }
            else if (val2R == 14)
            {
                valCod2R = "e";
            }
            else if (val2R == 15)
            {
                valCod2R = "f";
            }
            else
            {
                valCod2R = val2R.ToString();
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////

            //The G-Values
            if (theG < 16)
            {
                val2G = theG % 16; //Moduluds function in C#
                val1G = 0;
            }
            else
            {
                val2G = theG % 16;
                val1G = (theG - val2G) / 16;
            }

            //Converting value val1G
            if (val1G == 10)
            {
                valCod1G = "a";
            }
            else if (val1G == 11)
            {
                valCod1G = "b";
            }
            else if (val1G == 12)
            {
                valCod1G = "c";
            }
            else if (val1G == 13)
            {
                valCod1G = "d";
            }
            else if (val1G == 14)
            {
                valCod1G = "e";
            }
            else if (val1G == 15)
            {
                valCod1G = "f";
            }
            else
            {
                valCod1G = val1G.ToString();
            }

            //Converting value val2G
            if (val2G == 10)
            {
                valCod2G = "a";
            }
            else if (val2G == 11)
            {
                valCod2G = "b";
            }
            else if (val2G == 12)
            {
                valCod2G = "c";
            }
            else if (val2G == 13)
            {
                valCod2G = "d";
            }
            else if (val2G == 14)
            {
                valCod2G = "e";
            }
            else if (val2G == 15)
            {
                valCod2G = "f";
            }
            else
            {
                valCod2G = val2G.ToString();
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////

            //The B-Values
            if (theB < 16)
            {
                val2B = theB % 16; //Moduluds function in C#
                val1B = 0;
            }
            else
            {
                val2B = theB % 16;
                val1B = (theB - val2B) / 16;
            }

            //Converting value val1B
            if (val1B == 10)
            {
                valCod1B = "a";
            }
            else if (val1B == 11)
            {
                valCod1B = "b";
            }
            else if (val1B == 12)
            {
                valCod1B = "c";
            }
            else if (val1B == 13)
            {
                valCod1B = "d";
            }
            else if (val1B == 14)
            {
                valCod1B = "e";
            }
            else if (val1B == 15)
            {
                valCod1B = "f";
            }
            else
            {
                valCod1B = val1B.ToString();
            }

            //Converting value val2B
            if (val2B == 10)
            {
                valCod2B = "a";
            }
            else if (val2B == 11)
            {
                valCod2B = "b";
            }
            else if (val2B == 12)
            {
                valCod2B = "c";
            }
            else if (val2B == 13)
            {
                valCod2B = "d";
            }
            else if (val2B == 14)
            {
                valCod2B = "e";
            }
            else if (val2B == 15)
            {
                valCod2B = "f";
            }
            else
            {
                valCod2B = val2B.ToString();
            }

            valueR = valCod1R + valCod2R;
            valueG = valCod1G + valCod2G;
            valueB = valCod1B + valCod2B;

            //label2.Text = valueR + valueG + valueB;
            txtHexa.Text = valueR + valueG + valueB;
            txtHexa_TextChanged(sender, e);
        }

        private void PrevNext(object sender, EventArgs e)
        {
            //To know when to make the previous and next button disable or appear
            Int32 check = lstCol.SelectedIndex;
            if (check+1==lstCol.Items.Count)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
            }
            else if (check==0)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }

            if (lstCol.Items.Count==0)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        private void aboutMe(object sender, EventArgs e)
        {
            Form abt = new Form2();
            abt.ShowDialog();
        }
    }
}
