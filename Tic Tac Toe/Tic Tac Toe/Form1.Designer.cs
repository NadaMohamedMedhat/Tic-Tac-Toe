
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.game_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_newgame = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.score_O = new System.Windows.Forms.Label();
            this.score_X = new System.Windows.Forms.Label();
            this.label_O = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.game_name);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 119);
            this.panel1.TabIndex = 0;
            // 
            // game_name
            // 
            this.game_name.AutoSize = true;
            this.game_name.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.game_name.Location = new System.Drawing.Point(396, 10);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(430, 90);
            this.game_name.TabIndex = 0;
            this.game_name.Text = "Tic Tac Toe";
            this.game_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 538);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(662, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 511);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_reset);
            this.panel6.Controls.Add(this.btn_newgame);
            this.panel6.Location = new System.Drawing.Point(13, 266);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(517, 191);
            this.panel6.TabIndex = 2;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(11, 108);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(502, 70);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_newgame
            // 
            this.btn_newgame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_newgame.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newgame.Location = new System.Drawing.Point(11, 20);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(502, 70);
            this.btn_newgame.TabIndex = 11;
            this.btn_newgame.Text = "New Game";
            this.btn_newgame.UseVisualStyleBackColor = false;
            this.btn_newgame.Click += new System.EventHandler(this.btn_newgame_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.score_O);
            this.panel5.Controls.Add(this.score_X);
            this.panel5.Controls.Add(this.label_O);
            this.panel5.Controls.Add(this.label_X);
            this.panel5.Location = new System.Drawing.Point(13, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 234);
            this.panel5.TabIndex = 1;
            // 
            // score_O
            // 
            this.score_O.AutoSize = true;
            this.score_O.BackColor = System.Drawing.Color.White;
            this.score_O.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score_O.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score_O.Location = new System.Drawing.Point(337, 83);
            this.score_O.Name = "score_O";
            this.score_O.Size = new System.Drawing.Size(117, 135);
            this.score_O.TabIndex = 4;
            this.score_O.Text = "0";
            this.score_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_X
            // 
            this.score_X.AutoSize = true;
            this.score_X.BackColor = System.Drawing.Color.White;
            this.score_X.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score_X.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score_X.Location = new System.Drawing.Point(60, 83);
            this.score_X.Name = "score_X";
            this.score_X.Size = new System.Drawing.Size(117, 135);
            this.score_X.TabIndex = 3;
            this.score_X.Text = "0";
            this.score_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score_X.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_O
            // 
            this.label_O.AutoSize = true;
            this.label_O.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_O.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_O.Location = new System.Drawing.Point(287, 11);
            this.label_O.Name = "label_O";
            this.label_O.Size = new System.Drawing.Size(201, 53);
            this.label_O.TabIndex = 2;
            this.label_O.Text = "Player O";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_X.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_X.Location = new System.Drawing.Point(22, 11);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(198, 53);
            this.label_X.TabIndex = 1;
            this.label_X.Text = "Player X";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(13, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 511);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(423, 341);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 158);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(217, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 158);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(11, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 158);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Location = new System.Drawing.Point(423, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 158);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(217, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 158);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(11, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 158);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(423, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 158);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(217, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 158);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(11, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 158);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1271, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label game_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_newgame;
        private System.Windows.Forms.Label score_O;
        private System.Windows.Forms.Label score_X;
        private System.Windows.Forms.Label label_O;
        private System.Windows.Forms.Label label_X;
    }
}

