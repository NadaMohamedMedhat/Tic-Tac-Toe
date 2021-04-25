using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plus_one;
        void enable_false(){
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void score()
        {
              //******************************((horizontal))*******************************************
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.BackColor = Color.PowderBlue;
                    button2.BackColor = Color.PowderBlue;
                    button3.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button4.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button6.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button7.BackColor = Color.PowderBlue;
                    button8.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                //*******************************((vertical ))********************************************
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.BackColor = Color.PowderBlue;
                    button4.BackColor = Color.PowderBlue;
                    button7.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button2.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button8.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button3.BackColor = Color.PowderBlue;
                    button6.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                //**************************************((diagonal))*************************************
                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }
                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button3.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button7.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player X");
                    plus_one = int.Parse(score_X.Text);
                    score_X.Text = Convert.ToString(plus_one + 1);
                    enable_false();
                }

                //#################### ((For Player O))###############################

                //******************************((horizontal))*******************************************
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.BackColor = Color.PowderBlue;
                    button2.BackColor = Color.PowderBlue;
                    button3.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button4.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button6.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button7.BackColor = Color.PowderBlue;
                    button8.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                //********************************((vertical ))********************************************
                if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.BackColor = Color.PowderBlue;
                    button4.BackColor = Color.PowderBlue;
                    button7.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button2.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button8.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button3.BackColor = Color.PowderBlue;
                    button6.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                //*******************************((diagonal))********************************************
                if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button9.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
                if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button3.BackColor = Color.PowderBlue;
                    button5.BackColor = Color.PowderBlue;
                    button7.BackColor = Color.PowderBlue;
                    MessageBox.Show(" The Winner Is Player O");
                    plus_one = int.Parse(score_X.Text);
                    score_O.Text = Convert.ToString(plus_one + 1);
                enable_false();
            }
            //*******************************((No_Win))********************************************
            if (button1.Text != "" && button2.Text != "" && button3.Text != ""
                && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "") MessageBox.Show(" No Player Win!");
            }
            
        public Form1()
        {
            InitializeComponent();
        }
        private void panel3_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //*************************((Labels))**********************************
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //*************************((Buttons))**********************************
               private void TempButton_Click(Button TempButton)
        {
            if (checker == false)
            {
                TempButton.Text = "X";
                checker = true;
            }
            else
            {
                TempButton.Text = "O";
                checker = false;
            }
            score();
            TempButton.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e) => TempButton_Click(button1);
        private void button2_Click(object sender, EventArgs e) => TempButton_Click(button2);
        private void button3_Click(object sender, EventArgs e) => TempButton_Click(button3);
        private void button4_Click(object sender, EventArgs e) => TempButton_Click(button4);
        private void button5_Click(object sender, EventArgs e) => TempButton_Click(button5);
        private void button6_Click(object sender, EventArgs e) => TempButton_Click(button6);
        private void button7_Click(object sender, EventArgs e) => TempButton_Click(button7);
        private void button8_Click(object sender, EventArgs e) => TempButton_Click(button8);
        private void button9_Click(object sender, EventArgs e) => TempButton_Click(button9);

        //*******************((New Game & Reset))***************************
        private void btn_newgame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            score_O .Text= "0";
            score_X.Text = "0";

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            btn_newgame.Enabled = true;

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
        }
    }
    }
    

