using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        bool acabou = false;
        int jogada = 0;


        static void statusDOjogo(ref bool acabou, Button l11, Button l21, Button l31, Button l12, Button l22, Button l32, Button l13, Button l23, Button l33)
        {
            if (l11.Text != "" || l12.Text != "" || l13.Text != "" || l21.Text != "" || l22.Text != "" || l23.Text != "" || l31.Text != "" || l32.Text != "" || l31.Text != "")
            {

                #region Coluna 1
                if (((l11.Text == "X") && (l21.Text == "X") && (l21.Text == "X") && (l31.Text == "X") ||
                    (l11.Text == "O") && (l21.Text == "O") && (l21.Text == "O") && (l31.Text == "O")))
                {
                    acabou = true;
                }
                #endregion

                #region Coluna 2


                if ((l12.Text == "X" && l22.Text == "X" && l32.Text == "X") || (l12.Text == "O" && l22.Text == "O" && l32.Text == "O"))
                {
                    acabou = true;
                }
                #endregion

                #region Coluna 3


                if ((l13.Text == "O" && l23.Text == "O" && l33.Text == "O") || (l13.Text == "X" &&  l23.Text == "X" && l33.Text == "X"))
                {
                    acabou = true;
                }
                #endregion

                #region Diagonal ED


                if ((l11.Text == "O"  && l22.Text == "O" && l33.Text == "O") || (l11.Text == "X" && l22.Text == "X" && l33.Text == "X"))
                {
                    acabou = true;
                }
                #endregion

                #region Diagonal DE


                if ((l13.Text == "X" && l22.Text == "X" && l31.Text == "X") || (l13.Text == "O" && l22.Text == "O" && l31.Text == "O"))
                {
                    acabou = true;
                }
                #endregion

                #region Linha 1
                if ((l11.Text == "X" && l12.Text == "X" && l13.Text == "X") || (l11.Text == "O" && l12.Text == "O" && l13.Text == "O"))
                {
                    acabou = true;
                }
                #endregion

                #region Linha 2
                if ((l21.Text == "X" && l22.Text == "X" && l23.Text == "X") || (l21.Text == "O" && l22.Text == "O" && l23.Text == "O"))
                {
                    acabou = true;
                }
                #endregion

                #region Linha 3
                if ((l31.Text == "X" && l32.Text == "X" && l33.Text == "X") || (l31.Text == "O" && l32.Text == "O" && l33.Text == "O"))
                {
                    acabou = true;
                }
                #endregion
            }
            else
            {
                acabou = false;
            }
        }

        static void XouO(ref int jogada, Button btn)
        {
            if (jogada % 2 == 0)
            {
                btn.Text = "O";
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "X";
                btn.Enabled = false;
            }

            jogada++;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn11_Click(object sender, EventArgs e)
        {

            XouO(ref jogada, btn11);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn21);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)       
                MessageBox.Show("Fim de jogo!");
        }
        
        private void btn31_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn31);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }
        

        private void btn12_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn12);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn22);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn32);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn13);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn23);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            XouO(ref jogada, btn33);
            statusDOjogo(ref acabou, btn11, btn21, btn31, btn12, btn22, btn32, btn13, btn23, btn33);
            if (acabou == true)
                MessageBox.Show("Fim de jogo!");
        }

        private void txtjogada_Click(object sender, EventArgs e)
        {

            string xd = Convert.ToString(jogada);

            txtjogada.Text = xd;

            if (jogada%2 == 0)
            {
                txtjogada.Text = "É a vez do 'O' jogar!";
            }
            else
            {
                txtjogada.Text = "É a vez do 'X' jogar!";
            }

            if (acabou == true)
            {
                txtjogada.Text = "Fim de Jogo!";
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            string xd = Convert.ToString(jogada);

            txtjogada.Text = xd;

            if (jogada % 2 == 0)
            {
                txtjogada.Text = "É a vez do 'O' jogar!";
            }
            else
            {
                txtjogada.Text = "É a vez do 'X' jogar!";
            }

            if (acabou == true)
            {
                txtjogada.Text = "Fim de Jogo!";
            }
        }
    }
}
