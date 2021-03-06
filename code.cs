using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly2
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> players = new Dictionary<int, string>() { {1,"playerSteve"},{2,"playerAlex" },{3,"playerWither" },{4,"playerED" } };
        int currentPlayer = 1;
        int stevePos = 0;
        int alexPos = 0;
        int witherPos = 0;
        int edPos = 0;
        string[] boxes = { "pictureBox1", "pictureBox2", "pictureBox3", "pictureBox4", "pictureBox5", "pictureBox6", "pictureBox7", "pictureBox8", "pictureBox9", "pictureBox10", "pictureBox11", "pictureBox12", "pictureBox13", "pictureBox14", "pictureBox15", "pictureBox16", "pictureBox17", "pictureBox18", "pictureBox19", "pictureBox20", "pictureBox21", "pictureBox22", "pictureBox23", "pictureBox24", "pictureBox25", "pictureBox26", "pictureBox27", "pictureBox28", "pictureBox29", "pictureBox30", "pictureBox31", "pictureBox32", "pictureBox33", "pictureBox34", "pictureBox35", "pictureBox36", "pictureBox37", "pictureBox38", "pictureBox39", "pictureBox40" };
        Dictionary<string, string> boxNames = new Dictionary<string, string> { };

        public Form1()
        {
            InitializeComponent();
            label9.Text = "Go";
            label10.Text = "Go";
            label11.Text = "Go";
            label12.Text = "Go";
        }

        private int throwDice()
        {
            Random rnd = new Random();
            int one = rnd.Next(1, 7);
            int two = rnd.Next(1, 7);

            switch (one)
            {
                case 1:
                    diceOne.Image = Image.FromFile("dice/one.png");
                    break;
                case 2:
                    diceOne.Image = Image.FromFile("dice/two.png");
                    break;
                case 3:
                    diceOne.Image = Image.FromFile("dice/three.png");
                    break;
                case 4:
                    diceOne.Image = Image.FromFile("dice/four.png");
                    break;
                case 5:
                    diceOne.Image = Image.FromFile("dice/five.png");
                    break;
                case 6:
                    diceOne.Image = Image.FromFile("dice/six.png");
                    break;
            }
            switch (two)
            {
                case 1:
                    diceTwo.Image = Image.FromFile("dice/one.png");
                    break;
                case 2:
                    diceTwo.Image = Image.FromFile("dice/two.png");
                    break;
                case 3:
                    diceTwo.Image = Image.FromFile("dice/three.png");
                    break;
                case 4:
                    diceTwo.Image = Image.FromFile("dice/four.png");
                    break;
                case 5:
                    diceTwo.Image = Image.FromFile("dice/five.png");
                    break;
                case 6:
                    diceTwo.Image = Image.FromFile("dice/six.png");
                    break;
            }


            return one+two;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            int move = throwDice();
            numberBox.Text = move.ToString();

            if (currentPlayer == 1)
            {
                
                stevePos += move;
                label9.Text = boxes[stevePos];
                if (stevePos >= 40)
                {
                    stevePos -= 40;
                }
                if (stevePos == 0)
                {
                    playerSteve.Top = pictureBox1.Top + 5;
                    playerSteve.Left = pictureBox1.Left + 5;
                }
                if (stevePos == 1)
                {
                    playerSteve.Top = pictureBox2.Top + 5;
                    playerSteve.Left = pictureBox2.Left + 5;
                }
                if (stevePos == 2)
                {
                    playerSteve.Top = pictureBox3.Top + 5;
                    playerSteve.Left = pictureBox3.Left + 5;
                }
                if (stevePos == 3)
                {
                    playerSteve.Top = pictureBox4.Top + 5;
                    playerSteve.Left = pictureBox4.Left + 5;
                }
                if (stevePos == 4)
                {
                    playerSteve.Top = pictureBox5.Top + 5;
                    playerSteve.Left = pictureBox5.Left + 5;
                }
                if (stevePos == 5)
                {
                    playerSteve.Top = pictureBox6.Top + 5;
                    playerSteve.Left = pictureBox6.Left + 5;
                }
                if (stevePos == 6)
                {
                    playerSteve.Top = pictureBox7.Top + 5;
                    playerSteve.Left = pictureBox7.Left + 5;
                }
                if (stevePos == 7)
                {
                    playerSteve.Top = pictureBox8.Top + 5;
                    playerSteve.Left = pictureBox8.Left + 5;
                }
                if (stevePos == 8)
                {
                    playerSteve.Top = pictureBox9.Top + 5;
                    playerSteve.Left = pictureBox9.Left + 5;
                }
                if (stevePos == 9)
                {
                    playerSteve.Top = pictureBox10.Top + 5;
                    playerSteve.Left = pictureBox10.Left + 5;
                }
                if (stevePos == 10)
                {
                    playerSteve.Top = pictureBox11.Top + 5;
                    playerSteve.Left = pictureBox11.Left + 5;
                }
                if (stevePos == 11)
                {
                    playerSteve.Top = pictureBox12.Top + 5;
                    playerSteve.Left = pictureBox12.Left + 5;
                }
                if (stevePos == 12)
                {
                    playerSteve.Top = pictureBox13.Top + 5;
                    playerSteve.Left = pictureBox13.Left + 5;
                }
                if (stevePos == 13)
                {
                    playerSteve.Top = pictureBox14.Top + 5;
                    playerSteve.Left = pictureBox14.Left + 5;
                }
                if (stevePos == 14)
                {
                    playerSteve.Top = pictureBox15.Top + 5;
                    playerSteve.Left = pictureBox15.Left + 5;
                }
                if (stevePos == 15)
                {
                    playerSteve.Top = pictureBox16.Top + 5;
                    playerSteve.Left = pictureBox16.Left + 5;
                }
                if (stevePos == 16)
                {
                    playerSteve.Top = pictureBox17.Top + 5;
                    playerSteve.Left = pictureBox17.Left + 5;
                }
                if (stevePos == 17)
                {
                    playerSteve.Top = pictureBox18.Top + 5;
                    playerSteve.Left = pictureBox18.Left + 5;
                }
                if (stevePos == 18)
                {
                    playerSteve.Top = pictureBox19.Top + 5;
                    playerSteve.Left = pictureBox19.Left + 5;
                }
                if (stevePos == 19)
                {
                    playerSteve.Top = pictureBox20.Top + 5;
                    playerSteve.Left = pictureBox20.Left + 5;
                }
                if (stevePos == 20)
                {
                    playerSteve.Top = pictureBox21.Top + 5;
                    playerSteve.Left = pictureBox21.Left + 5;
                }
                if (stevePos == 21)
                {
                    playerSteve.Top = pictureBox22.Top + 5;
                    playerSteve.Left = pictureBox22.Left + 5;
                }
                if (stevePos == 22)
                {
                    playerSteve.Top = pictureBox23.Top + 5;
                    playerSteve.Left = pictureBox23.Left + 5;
                }
                if (stevePos == 23)
                {
                    playerSteve.Top = pictureBox24.Top + 5;
                    playerSteve.Left = pictureBox24.Left + 5;
                }
                if (stevePos == 24)
                {
                    playerSteve.Top = pictureBox25.Top + 5;
                    playerSteve.Left = pictureBox25.Left + 5;
                }
                if (stevePos == 25)
                {
                    playerSteve.Top = pictureBox26.Top + 5;
                    playerSteve.Left = pictureBox26.Left + 5;
                }
                if (stevePos == 26)
                {
                    playerSteve.Top = pictureBox27.Top + 5;
                    playerSteve.Left = pictureBox27.Left + 5;
                }
                if (stevePos ==27)
                {
                    playerSteve.Top = pictureBox28.Top + 5;
                    playerSteve.Left = pictureBox28.Left + 5;
                }
                if (stevePos == 28)
                {
                    playerSteve.Top = pictureBox29.Top + 5;
                    playerSteve.Left = pictureBox29.Left + 5;
                }
                if (stevePos == 29)
                {
                    playerSteve.Top = pictureBox30.Top + 5;
                    playerSteve.Left = pictureBox30.Left + 5;
                }
                if (stevePos == 30)
                {
                    playerSteve.Top = pictureBox31.Top + 5;
                    playerSteve.Left = pictureBox31.Left + 5;
                }
                if (stevePos == 31)
                {
                    playerSteve.Top = pictureBox32.Top + 5;
                    playerSteve.Left = pictureBox32.Left + 5;
                }
                if (stevePos == 32)
                {
                    playerSteve.Top = pictureBox33.Top + 5;
                    playerSteve.Left = pictureBox33.Left + 5;
                }
                if (stevePos == 33)
                {
                    playerSteve.Top = pictureBox34.Top + 5;
                    playerSteve.Left = pictureBox34.Left + 5;
                }
                if (stevePos == 34)
                {
                    playerSteve.Top = pictureBox35.Top + 5;
                    playerSteve.Left = pictureBox35.Left + 5;
                }
                if (stevePos ==35)
                {
                    playerSteve.Top = pictureBox36.Top + 5;
                    playerSteve.Left = pictureBox36.Left + 5;
                }
                if (stevePos == 36)
                {
                    playerSteve.Top = pictureBox37.Top + 5;
                    playerSteve.Left = pictureBox37.Left + 5;
                }
                if (stevePos == 37)
                {
                    playerSteve.Top = pictureBox38.Top + 5;
                    playerSteve.Left = pictureBox38.Left + 5;
                }
                if (stevePos == 38)
                {
                    playerSteve.Top = pictureBox39.Top + 5;
                    playerSteve.Left = pictureBox39.Left + 5;
                }
                if (stevePos == 39)
                {
                    playerSteve.Top = pictureBox40.Top + 5;
                    playerSteve.Left = pictureBox40.Left + 5;
                }
                
            }
            if (currentPlayer == 2)
            {
                
                alexPos += move;
                label10.Text = boxes[alexPos];
                if (alexPos >= 40)
                {
                    alexPos -= 40;
                }
                if (alexPos == 0)
                {
                    playerAlex.Top = pictureBox1.Top + 5;
                    playerAlex.Left = pictureBox1.Right - 35;
                }
                if (alexPos == 1)
                {
                    playerAlex.Top = pictureBox2.Top + 5;
                    playerAlex.Left = pictureBox2.Right - 35;
                }
                if (alexPos == 2)
                {
                    playerAlex.Top = pictureBox3.Top + 5;
                    playerAlex.Left = pictureBox3.Right - 35;
                }
                if (alexPos == 3)
                {
                    playerAlex.Top = pictureBox4.Top + 5;
                    playerAlex.Left = pictureBox4.Right - 35;
                }
                if (alexPos == 4)
                {
                    playerAlex.Top = pictureBox5.Top + 5;
                    playerAlex.Left = pictureBox5.Right - 35;
                }
                if (alexPos == 5)
                {
                    playerAlex.Top = pictureBox6.Top + 5;
                    playerAlex.Left = pictureBox6.Right - 35;
                }
                if (alexPos == 6)
                {
                    playerAlex.Top = pictureBox7.Top + 5;
                    playerAlex.Left = pictureBox7.Right - 35;
                }
                if (alexPos == 7)
                {
                    playerAlex.Top = pictureBox8.Top + 5;
                    playerAlex.Left = pictureBox8.Right - 35;
                }
                if (alexPos == 8)
                {
                    playerAlex.Top = pictureBox9.Top + 5;
                    playerAlex.Left = pictureBox9.Right - 35;
                }
                if (alexPos == 9)
                {
                    playerAlex.Top = pictureBox10.Top + 5;
                    playerAlex.Left = pictureBox10.Right - 35;
                }
                if (alexPos == 10)
                {
                    playerAlex.Top = pictureBox11.Top + 5;
                    playerAlex.Left = pictureBox11.Right - 35;
                }
                if (alexPos == 11)
                {
                    playerAlex.Top = pictureBox12.Top + 5;
                    playerAlex.Left = pictureBox12.Right - 35;
                }
                if (alexPos == 12)
                {
                    playerAlex.Top = pictureBox13.Top + 5;
                    playerAlex.Left = pictureBox13.Right - 35;
                }
                if (alexPos == 13)
                {
                    playerAlex.Top = pictureBox14.Top + 5;
                    playerAlex.Left = pictureBox14.Right - 35;
                }
                if (alexPos == 14)
                {
                    playerAlex.Top = pictureBox15.Top + 5;
                    playerAlex.Left = pictureBox15.Right - 35;
                }
                if (alexPos == 15)
                {
                    playerAlex.Top = pictureBox16.Top + 5;
                    playerAlex.Left = pictureBox16.Right - 35;
                }
                if (alexPos == 16)
                {
                    playerAlex.Top = pictureBox17.Top + 5;
                    playerAlex.Left = pictureBox17.Right - 35;
                }
                if (alexPos == 17)
                {
                    playerAlex.Top = pictureBox18.Top + 5;
                    playerAlex.Left = pictureBox18.Right - 35;
                }
                if (alexPos == 18)
                {
                    playerAlex.Top = pictureBox19.Top + 5;
                    playerAlex.Left = pictureBox19.Right - 35;
                }
                if (alexPos == 19)
                {
                    playerAlex.Top = pictureBox20.Top + 5;
                    playerAlex.Left = pictureBox20.Right - 35;
                }
                if (alexPos == 20)
                {
                    playerAlex.Top = pictureBox21.Top + 5;
                    playerAlex.Left = pictureBox21.Right - 35;
                }
                if (alexPos == 21)
                {
                    playerAlex.Top = pictureBox22.Top + 5;
                    playerAlex.Left = pictureBox22.Right - 35;
                }
                if (alexPos == 22)
                {
                    playerAlex.Top = pictureBox23.Top + 5;
                    playerAlex.Left = pictureBox23.Right - 35;
                }
                if (alexPos == 23)
                {
                    playerAlex.Top = pictureBox24.Top + 5;
                    playerAlex.Left = pictureBox24.Right - 35;
                }
                if (alexPos == 24)
                {
                    playerAlex.Top = pictureBox25.Top + 5;
                    playerAlex.Left = pictureBox25.Right - 35;
                }
                if (alexPos == 25)
                {
                    playerAlex.Top = pictureBox26.Top + 5;
                    playerAlex.Left = pictureBox26.Right - 35;
                }
                if (alexPos == 26)
                {
                    playerAlex.Top = pictureBox27.Top + 5;
                    playerAlex.Left = pictureBox27.Right - 35;
                }
                if (alexPos == 27)
                {
                    playerAlex.Top = pictureBox28.Top + 5;
                    playerAlex.Left = pictureBox28.Right - 35;
                }
                if (alexPos == 28)
                {
                    playerAlex.Top = pictureBox29.Top + 5;
                    playerAlex.Left = pictureBox29.Right - 35;
                }
                if (alexPos == 29)
                {
                    playerAlex.Top = pictureBox30.Top + 5;
                    playerAlex.Left = pictureBox30.Right - 35;
                }
                if (alexPos == 30)
                {
                    playerAlex.Top = pictureBox31.Top + 5;
                    playerAlex.Left = pictureBox31.Right - 35;
                }
                if (alexPos == 31)
                {
                    playerAlex.Top = pictureBox32.Top + 5;
                    playerAlex.Left = pictureBox32.Right - 35;
                }
                if (alexPos == 32)
                {
                    playerAlex.Top = pictureBox33.Top + 5;
                    playerAlex.Left = pictureBox33.Right - 35;
                }
                if (alexPos == 33)
                {
                    playerAlex.Top = pictureBox34.Top + 5;
                    playerAlex.Left = pictureBox34.Right - 35;
                }
                if (alexPos == 34)
                {
                    playerAlex.Top = pictureBox35.Top + 5;
                    playerAlex.Left = pictureBox35.Right - 35;
                }
                if (alexPos == 35)
                {
                    playerAlex.Top = pictureBox36.Top + 5;
                    playerAlex.Left = pictureBox36.Right - 35;
                }
                if (alexPos == 36)
                {
                    playerAlex.Top = pictureBox37.Top + 5;
                    playerAlex.Left = pictureBox37.Right - 35;
                }
                if (alexPos == 37)
                {
                    playerAlex.Top = pictureBox38.Top + 5;
                    playerAlex.Left = pictureBox38.Right - 35;
                }
                if (alexPos == 38)
                {
                    playerAlex.Top = pictureBox39.Top + 5;
                    playerAlex.Left = pictureBox39.Right - 35;
                }
                if (alexPos == 39)
                {
                    playerAlex.Top = pictureBox40.Top + 5;
                    playerAlex.Left = pictureBox40.Right - 35;
                }

            }
            if (currentPlayer == 3)
            {
                
                witherPos += move;
                label11.Text = boxes[witherPos];
                if (witherPos >= 40)
                {
                    witherPos -= 40;
                }
                if (witherPos == 0)
                {
                    playerWither.Top = pictureBox1.Top + 45;
                    playerWither.Left = pictureBox1.Left + 5;
                }
                if (witherPos == 1)
                {
                    playerWither.Top = pictureBox2.Top + 45;
                    playerWither.Left = pictureBox2.Left + 5;
                }
                if (witherPos == 2)
                {
                    playerWither.Top = pictureBox3.Top + 45;
                    playerWither.Left = pictureBox3.Left + 5;
                }
                if (witherPos == 3)
                {
                    playerWither.Top = pictureBox4.Top + 45;
                    playerWither.Left = pictureBox4.Left + 5;
                }
                if (witherPos == 4)
                {
                    playerWither.Top = pictureBox5.Top + 45;
                    playerWither.Left = pictureBox5.Left + 5;
                }
                if (witherPos == 5)
                {
                    playerWither.Top = pictureBox6.Top + 45;
                    playerWither.Left = pictureBox6.Left + 5;
                }
                if (witherPos == 6)
                {
                    playerWither.Top = pictureBox7.Top + 45;
                    playerWither.Left = pictureBox7.Left + 5;
                }
                if (witherPos == 7)
                {
                    playerWither.Top = pictureBox8.Top + 45;
                    playerWither.Left = pictureBox8.Left + 5;
                }
                if (witherPos == 8)
                {
                    playerWither.Top = pictureBox9.Top + 45;
                    playerWither.Left = pictureBox9.Left + 5;
                }
                if (witherPos == 9)
                {
                    playerWither.Top = pictureBox10.Top + 45;
                    playerWither.Left = pictureBox10.Left + 5;
                }
                if (witherPos == 10)
                {
                    playerWither.Top = pictureBox11.Top + 45;
                    playerWither.Left = pictureBox11.Left + 5;
                }
                if (witherPos == 11)
                {
                    playerWither.Top = pictureBox12.Top + 45;
                    playerWither.Left = pictureBox12.Left + 5;
                }
                if (witherPos == 12)
                {
                    playerWither.Top = pictureBox13.Top + 45;
                    playerWither.Left = pictureBox13.Left + 5;
                }
                if (witherPos == 13)
                {
                    playerWither.Top = pictureBox14.Top + 45;
                    playerWither.Left = pictureBox14.Left + 5;
                }
                if (witherPos == 14)
                {
                    playerWither.Top = pictureBox15.Top + 45;
                    playerWither.Left = pictureBox15.Left + 5;
                }
                if (witherPos == 15)
                {
                    playerWither.Top = pictureBox16.Top + 45;
                    playerWither.Left = pictureBox16.Left + 5;
                }
                if (witherPos == 16)
                {
                    playerWither.Top = pictureBox17.Top + 45;
                    playerWither.Left = pictureBox17.Left + 5;
                }
                if (witherPos == 17)
                {
                    playerWither.Top = pictureBox18.Top + 45;
                    playerWither.Left = pictureBox18.Left + 5;
                }
                if (witherPos == 18)
                {
                    playerWither.Top = pictureBox19.Top + 45;
                    playerWither.Left = pictureBox19.Left + 5;
                }
                if (witherPos == 19)
                {
                    playerWither.Top = pictureBox20.Top + 45;
                    playerWither.Left = pictureBox20.Left + 5;
                }
                if (witherPos == 20)
                {
                    playerWither.Top = pictureBox21.Top + 45;
                    playerWither.Left = pictureBox21.Left + 5;
                }
                if (witherPos == 21)
                {
                    playerWither.Top = pictureBox22.Top + 45;
                    playerWither.Left = pictureBox22.Left + 5;
                }
                if (witherPos == 22)
                {
                    playerWither.Top = pictureBox23.Top + 45;
                    playerWither.Left = pictureBox23.Left + 5;
                }
                if (witherPos == 23)
                {
                    playerWither.Top = pictureBox24.Top + 45;
                    playerWither.Left = pictureBox24.Left + 5;
                }
                if (witherPos == 24)
                {
                    playerWither.Top = pictureBox25.Top + 45;
                    playerWither.Left = pictureBox25.Left + 5;
                }
                if (witherPos == 25)
                {
                    playerWither.Top = pictureBox26.Top + 45;
                    playerWither.Left = pictureBox26.Left + 5;
                }
                if (witherPos == 26)
                {
                    playerWither.Top = pictureBox27.Top + 45;
                    playerWither.Left = pictureBox27.Left + 5;
                }
                if (witherPos == 27)
                {
                    playerWither.Top = pictureBox28.Top + 45;
                    playerWither.Left = pictureBox28.Left + 5;
                }
                if (witherPos == 28)
                {
                    playerWither.Top = pictureBox29.Top + 45;
                    playerWither.Left = pictureBox29.Left + 5;
                }
                if (witherPos == 29)
                {
                    playerWither.Top = pictureBox30.Top + 45;
                    playerWither.Left = pictureBox30.Left + 5;
                }
                if (witherPos == 30)
                {
                    playerWither.Top = pictureBox31.Top + 45;
                    playerWither.Left = pictureBox31.Left + 5;
                }
                if (witherPos == 31)
                {
                    playerWither.Top = pictureBox32.Top + 45;
                    playerWither.Left = pictureBox32.Left + 5;
                }
                if (witherPos == 32)
                {
                    playerWither.Top = pictureBox33.Top + 45;
                    playerWither.Left = pictureBox33.Left + 5;
                }
                if (witherPos == 33)
                {
                    playerWither.Top = pictureBox34.Top + 45;
                    playerWither.Left = pictureBox34.Left + 5;
                }
                if (witherPos == 34)
                {
                    playerWither.Top = pictureBox35.Top + 45;
                    playerWither.Left = pictureBox35.Left + 5;
                }
                if (witherPos == 35)
                {
                    playerWither.Top = pictureBox36.Top + 45;
                    playerWither.Left = pictureBox36.Left + 5;
                }
                if (witherPos == 36)
                {
                    playerWither.Top = pictureBox37.Top + 45;
                    playerWither.Left = pictureBox37.Left + 5;
                }
                if (witherPos == 37)
                {
                    playerWither.Top = pictureBox38.Top + 45;
                    playerWither.Left = pictureBox38.Left + 5;
                }
                if (witherPos == 38)
                {
                    playerWither.Top = pictureBox39.Top + 45;
                    playerWither.Left = pictureBox39.Left + 5;
                }
                if (witherPos == 39)
                {
                    playerWither.Top = pictureBox40.Top + 45;
                    playerWither.Left = pictureBox40.Left + 5;
                }

            }
            if (currentPlayer == 4)
            {
                edPos += move;
                label12.Text = boxes[edPos];
                if (edPos >= 40)
                {
                    edPos -= 40;
                }
                if (edPos == 0)
                {
                    playerED.Top = pictureBox1.Top + 45;
                    playerED.Left = pictureBox1.Right - 35;
                }
                if (edPos == 1)
                {
                    playerED.Top = pictureBox2.Top + 45;
                    playerED.Left = pictureBox2.Right - 35;
                }
                if (edPos == 2)
                {
                    playerED.Top = pictureBox3.Top + 45;
                    playerED.Left = pictureBox3.Right - 35;
                }
                if (edPos == 3)
                {
                    playerED.Top = pictureBox4.Top + 45;
                    playerED.Left = pictureBox4.Right - 35;
                }
                if (edPos == 4)
                {
                    playerED.Top = pictureBox5.Top + 45;
                    playerED.Left = pictureBox5.Right - 35;
                }
                if (edPos == 5)
                {
                    playerED.Top = pictureBox6.Top + 45;
                    playerED.Left = pictureBox6.Right - 35;
                }
                if (edPos == 6)
                {
                    playerED.Top = pictureBox7.Top + 45;
                    playerED.Left = pictureBox7.Right - 35;
                }
                if (edPos == 7)
                {
                    playerED.Top = pictureBox8.Top + 45;
                    playerED.Left = pictureBox8.Right - 35;
                }
                if (edPos == 8)
                {
                    playerED.Top = pictureBox9.Top + 45;
                    playerED.Left = pictureBox9.Right - 35;
                }
                if (edPos == 9)
                {
                    playerED.Top = pictureBox10.Top + 45;
                    playerED.Left = pictureBox10.Right - 35;
                }
                if (edPos == 10)
                {
                    playerED.Top = pictureBox11.Top + 45;
                    playerED.Left = pictureBox11.Right - 35;
                }
                if (edPos == 11)
                {
                    playerED.Top = pictureBox12.Top + 45;
                    playerED.Left = pictureBox12.Right - 35;
                }
                if (edPos == 12)
                {
                    playerED.Top = pictureBox13.Top + 45;
                    playerED.Left = pictureBox13.Right - 35;
                }
                if (edPos == 13)
                {
                    playerED.Top = pictureBox14.Top + 45;
                    playerED.Left = pictureBox14.Right - 35;
                }
                if (edPos == 14)
                {
                    playerED.Top = pictureBox15.Top + 45;
                    playerED.Left = pictureBox15.Right - 35;
                }
                if (edPos == 15)
                {
                    playerED.Top = pictureBox16.Top + 45;
                    playerED.Left = pictureBox16.Right - 35;
                }
                if (edPos == 16)
                {
                    playerED.Top = pictureBox17.Top + 45;
                    playerED.Left = pictureBox17.Right - 35;
                }
                if (edPos == 17)
                {
                    playerED.Top = pictureBox18.Top + 45;
                    playerED.Left = pictureBox18.Right - 35;
                }
                if (edPos == 18)
                {
                    playerED.Top = pictureBox19.Top + 45;
                    playerED.Left = pictureBox19.Right - 35;
                }
                if (edPos == 19)
                {
                    playerED.Top = pictureBox20.Top + 45;
                    playerED.Left = pictureBox20.Right - 35;
                }
                if (edPos == 20)
                {
                    playerED.Top = pictureBox21.Top + 45;
                    playerED.Left = pictureBox21.Right - 35;
                }
                if (edPos == 21)
                {
                    playerED.Top = pictureBox22.Top + 45;
                    playerED.Left = pictureBox22.Right - 35;
                }
                if (edPos == 22)
                {
                    playerED.Top = pictureBox23.Top + 45;
                    playerED.Left = pictureBox23.Right - 35;
                }
                if (edPos == 23)
                {
                    playerED.Top = pictureBox24.Top + 45;
                    playerED.Left = pictureBox24.Right - 35;
                }
                if (edPos == 24)
                {
                    playerED.Top = pictureBox25.Top + 45;
                    playerED.Left = pictureBox25.Right - 35;
                }
                if (edPos == 25)
                {
                    playerED.Top = pictureBox26.Top + 45;
                    playerED.Left = pictureBox26.Right - 35;
                }
                if (edPos == 26)
                {
                    playerED.Top = pictureBox27.Top + 45;
                    playerED.Left = pictureBox27.Right - 35;
                }
                if (edPos == 27)
                {
                    playerED.Top = pictureBox28.Top + 45;
                    playerED.Left = pictureBox28.Right - 35;
                }
                if (edPos == 28)
                {
                    playerED.Top = pictureBox29.Top + 45;
                    playerED.Left = pictureBox29.Right - 35;
                }
                if (edPos == 29)
                {
                    playerED.Top = pictureBox30.Top + 45;
                    playerED.Left = pictureBox30.Right - 35;
                }
                if (edPos == 30)
                {
                    playerED.Top = pictureBox31.Top + 45;
                    playerED.Left = pictureBox31.Right - 35;
                }
                if (edPos == 31)
                {
                    playerED.Top = pictureBox32.Top + 45;
                    playerED.Left = pictureBox32.Right - 35;
                }
                if (edPos == 32)
                {
                    playerED.Top = pictureBox33.Top + 45;
                    playerED.Left = pictureBox33.Right - 35;
                }
                if (edPos == 33)
                {
                    playerED.Top = pictureBox34.Top + 45;
                    playerED.Left = pictureBox34.Right - 35;
                }
                if (edPos == 34)
                {
                    playerED.Top = pictureBox35.Top + 45;
                    playerED.Left = pictureBox35.Right - 35;
                }
                if (edPos == 35)
                {
                    playerED.Top = pictureBox36.Top + 45;
                    playerED.Left = pictureBox36.Right - 35;
                }
                if (edPos == 36)
                {
                    playerED.Top = pictureBox37.Top + 45;
                    playerED.Left = pictureBox37.Right - 35;
                }
                if (edPos == 37)
                {
                    playerED.Top = pictureBox38.Top + 45;
                    playerED.Left = pictureBox38.Right - 35;
                }
                if (edPos == 38)
                {
                    playerED.Top = pictureBox39.Top + 45;
                    playerED.Left = pictureBox39.Right - 35;
                }
                if (edPos == 39)
                {
                    playerED.Top = pictureBox40.Top + 45;
                    playerED.Left = pictureBox40.Right - 35;
                }

            }
            currentPlayer++;
            if (currentPlayer == 5)
            {
                currentPlayer = 1;
            }
            currentPlayerBox.Text = players[currentPlayer] + "'s turn";

        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}

