using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo_Game 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e) 
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e) 
        {
            StartGame(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e) 
        {
            StartGame(1);
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void StartGame(int opcao) 
        {
            lblResultado.Visible = false;
            lblVoce.Visible = false;
            lblPC.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao)) 
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("images/youwin.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("images/youlose.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("images/empatou.png");
                    goto default;
                default:
                    pic1.Image = jogo.ImgJogador;
                    pic2.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}
