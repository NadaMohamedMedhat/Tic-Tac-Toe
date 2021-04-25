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
        private void enable_false(bool TF){
            button1.Enabled = TF;
            button2.Enabled = TF;
            button3.Enabled = TF;
            button4.Enabled = TF;
            button5.Enabled = TF;
            button6.Enabled = TF;
            button7.Enabled = TF;
            button8.Enabled = TF;
            button9.Enabled = TF;
        }
        private void score_btn(Button TempButton1, Button TempButton2, Button TempButton3,String Btn_Text)
        {
            TempButton1.BackColor = Color.PowderBlue;
            TempButton2.BackColor = Color.PowderBlue;
            TempButton3.BackColor = Color.PowderBlue;
            if (Btn_Text == "X")
            {
                MessageBox.Show(" The Winner Is Player X");
                plus_one = int.Parse(score_X.Text);
                score_X.Text = Convert.ToString(plus_one + 1);
            }
            else
            {
                MessageBox.Show(" The Winner Is Player O");
                plus_one = int.Parse(score_O.Text);
                score_O.Text = Convert.ToString(plus_one + 1);
            }
            enable_false(false);
        }
        private void score()
        {
            //******************************((horizontal))*******************************************
            if (button1.Text ==  button2.Text && button2.Text == button3.Text &&button1.Text!="" ) score_btn(button1, button2, button3, button1.Text);
            else if (button4.Text == button5.Text && button5.Text== button6.Text &&button4.Text!="") score_btn(button4, button5, button6, button4.Text);
            else if (button7.Text == button8.Text && button8.Text== button9.Text&&button7.Text != "") score_btn(button7, button8, button9, button7.Text);
            //*******************************((vertical ))********************************************
            else if (button1.Text == button4.Text && button4.Text== button7.Text && button1.Text != "") score_btn(button1, button2, button7, button1.Text);
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") score_btn(button2, button5, button8, button2.Text);
            else if (button3.Text ==   button6.Text &&button6.Text== button9.Text && button3.Text != "") score_btn(button3, button6, button9, button3.Text);
            //**************************************((diagonal))*************************************
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") score_btn(button1, button5, button9, button1.Text);
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") score_btn(button3, button5, button7, button3.Text);
            //*******************************((No_Win))********************************************
            else if (button1.Text != "" && button2.Text != "" && button3.Text != ""
                && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "") MessageBox.Show(" No Player Win!");
            }
        public Form1() => InitializeComponent();
        private void panel3_Paint(object sender, PaintEventArgs e) {}
        private void Form1_Load(object sender, EventArgs e){}
        //*************************((Labels))**********************************
        private void label1_Click(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
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
        private void rest()
        {
            enable_false(true);
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
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
        private void btn_newgame_Click(object sender, EventArgs e)
        {
            rest();
            score_O .Text= "0";
            score_X.Text = "0";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            rest();
            enable_false(true);
            btn_newgame.Enabled = true;
        }
    }
    }
