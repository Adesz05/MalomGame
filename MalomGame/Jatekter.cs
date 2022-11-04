using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalomGame
{
    public partial class Jatekter : Form
    {
        static int meret = 9;
        static PictureBox[,] matrix = new PictureBox[meret, meret];
        static Player player1;
        static Player player2;
        static int kiJon = 0;
        static int kikezd = 0;
        static bool elsolefutas = true;
        public Jatekter(string Player1, string Player2)
        {
            InitializeComponent();
            if (elsolefutas)
            {
                MatrixGeneralas();
                Randomkezdes();
                elsolefutas = false;
            }
            Nevek(Player1, Player2);
        }

        private void Randomkezdes()
        {
            Random r = new Random();
            int r1 = r.Next(1, 3);
            if (r1 == 1)
            {
                kikezd = 1;
            }
            else
            {
                kikezd = 2;
            }
        }

        private void Nevek(string Player1, string Player2)
        {
            if (kikezd == 1)
            {
                player1 = new Player(Player1, "fehér", 0, 0, 9);
                player2 = new Player(Player2, "fekete", 0, 0, 9);

                FeherLBL.Text = player1.Nev;
                FeketeLBL.Text = player2.Nev;

                NevekLblSzepites();
            }
            else
            {
                player2 = new Player(Player2, "fehér", 0, 0, 9);
                player1 = new Player(Player1, "fekete", 0, 0, 9);

                FeherLBL.Text = player2.Nev;
                FeketeLBL.Text = player1.Nev;

                NevekLblSzepites();
            }
        }

        private void NevekLblSzepites()
        {
            FeherLBL.TextAlign = ContentAlignment.MiddleCenter;
            FeherLBL.TextAlign = ContentAlignment.MiddleCenter;
            FeketeLBL.TextAlign = ContentAlignment.MiddleCenter;
            FeketeLBL.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void MatrixGeneralas()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    if (i==j && i!=3 && i != 4 && i != 5)
                    {
                        //IgaziMatrixGeneralas(i, j);
                    }
                    //elsooszlop
                    if (j == 0 && (i == 0 || i == 4 || i == 8))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //masodikoszlop
                    else if (j == 1 && (i == 1 || i == 4 || i == 7))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //harmadikoszlop
                    else if (j == 2 && (i == 2 || i == 4 || i == 6))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //utolsooszlop
                    else if (j == 8 && (i == 0 || i == 4 || i == 8))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //utolsoelottioszlop
                    else if (j == 7 && (i == 1 || i == 4 || i == 7))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //utolsoelottielottioszlop
                    else if (j == 6 && (i == 2 || i == 4 || i == 6))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    //kozepsooszlop
                    else if (j == 4 && (i==0|| i==1||i == 2 || i == 6 || i==7 || i==8))
                    {
                        IgaziMatrixGeneralas(i, j);
                    }
                    

                }
            }
            //Tabla.SendToBack();
        }

        private void IgaziMatrixGeneralas(int i, int j)
        {
            matrix[i, j] = new PictureBox();
            matrix[i, j].Parent = Tabla;
            matrix[i, j].Name = i + "_" + j;
            matrix[i, j].Size = new Size(40, 40);
            matrix[i, j].Location = new Point(0 + 50 * j + j*10, 0 + 50 * i + i*10);
            matrix[i, j].BackColor = Color.FromArgb(0, 0, 0, 50);
            matrix[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
            matrix[i, j].Click += new EventHandler(Klikkeles);
        }

        
        private void Klikkeles(object sender, EventArgs e)
        {
            PictureBox klikkelt=sender as PictureBox;
            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[0]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            MessageBox.Show(sor.ToString() + " "+ oszlop.ToString());

            FeketevFeher(sor,oszlop);
        }

        private void FeketevFeher(int sor, int oszlop)
        {
                if (kiJon == 0)
                {
                    matrix[sor, oszlop].BackColor = Color.Black;
                    Ellenorzes(sor, oszlop);
                    kiJon = 1;
                }
                else
                {
                    matrix[sor, oszlop].BackColor = Color.Blue;
                    Ellenorzes(sor, oszlop);
                    kiJon = 0;
                }
            
                // NAGYON SOK ELLENŐRZÉS MÉG
        }

        private void Ellenorzes(int sor, int oszlop)
        {
            if (player1.TablanLevoKorongokSzama + player1.NemTablanLevoKorongokSzama < 3)
            {
                player2.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            if (player2.TablanLevoKorongokSzama + player2.NemTablanLevoKorongokSzama < 3)
            {
                player1.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }

            // ITT IS MÉG SOK ELLENŐRZÉS
        }
        private void FeherFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MelyikSzin == "fehér")
            {
                player2.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player1.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
        }

        private void FeketeFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MelyikSzin == "fekete")
            {
                player2.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player1.Pontszam += 1;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
        }

        private void TovabbJatszik(DialogResult valasz)
        {
            if (valasz == DialogResult.Yes)
            {
                //értékek, játékosok csere megadása még !!!
               
                Jatekter jatekter = new Jatekter(player1.Nev, player2.Nev);
                this.Visible = false;
                jatekter.ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }
        }
}
