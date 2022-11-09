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
        static Korongok[,] matrix = new Korongok[meret, meret];
        static List<NevekAlattiKorongok> nevAlattiKorongok = new List<NevekAlattiKorongok>();
        static Player player1;
        static Player player2;
        static int kiJon = 0;
        static bool elsolefutas = true;
        public Jatekter(string Player1, string Player2)
        {
            InitializeComponent();
            FutasEllenorzes(Player1, Player2);
        }
        private void FutasEllenorzes(string Player1, string Player2)
        {
            if (elsolefutas)
            {
                MatrixGeneralas();
                Randomkezdes(Player1, Player2);
                elsolefutas = false;
            }
            else
            {
                FeherLBL.Text = player1.Nev;
                FeketeLBL.Text = player2.Nev;
                PontSzamKiiras();
                NevekLblSzepites();
            }
            NevekAlattiKorongokLetrehozasa();
        }
        private void NevekAlattiKorongokLetrehozasa()
        {
            int j = 0;
            for (int i = 0; i < 9; i++)
            {
                nevAlattiKorongok.Add(new NevekAlattiKorongok(new PictureBox(), new PictureBox()));
                nevAlattiKorongok[i].Feher.Parent = this;
                nevAlattiKorongok[i].Feher.Name = "feketekorong" + i;
                nevAlattiKorongok[i].Feher.Size = new Size(41, 41);
                if (i < 5) nevAlattiKorongok[i].Feher.Location = new Point(12 + i * 47, 482);
                else
                {
                    nevAlattiKorongok[i].Feher.Location = new Point(12 + j * 47, 482 + 47);
                }
                nevAlattiKorongok[i].Feher.BackColor = Color.FromArgb(0, 0, 0, 50);
                nevAlattiKorongok[i].Feher.Image = Image.FromFile(@"feherkorong.png");
                nevAlattiKorongok[i].Feher.BringToFront();
                nevAlattiKorongok[i].Feher.SizeMode = PictureBoxSizeMode.StretchImage;

                //fekete
                nevAlattiKorongok[i].Fekete.Parent = this;
                nevAlattiKorongok[i].Fekete.Name = "feketekorong" + i;
                nevAlattiKorongok[i].Fekete.Size = new Size(41, 41);
                if (i < 5) nevAlattiKorongok[i].Fekete.Location = new Point(778 + i * 47, 482);
                else
                {
                    nevAlattiKorongok[i].Fekete.Location = new Point(778 + j * 47, 482 + 47);
                    j++;
                }
                nevAlattiKorongok[i].Fekete.BackColor = Color.FromArgb(0, 0, 0, 50);
                nevAlattiKorongok[i].Fekete.Image = Image.FromFile(@"feketekorong.png");
                nevAlattiKorongok[i].Fekete.BringToFront();
                nevAlattiKorongok[i].Fekete.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Randomkezdes(string Player1, string Player2)
        {
            int kikezd = 0;
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
                player1 = new Player(Player2, "fehér", 0, 0, 9);
                player2 = new Player(Player1, "fekete", 0, 0, 9);

                FeherLBL.Text = player1.Nev;
                FeketeLBL.Text = player2.Nev;

                NevekLblSzepites();
            }

        }
        private void PontSzamKiiras()
        {
            if (player1.MelyikSzin == "fehér")
            {
                FeherPontSzam.Text = "A pontszám: " + player2.Pontszam.ToString();
                FeketePontszam.Text = "A pontszám: " + player1.Pontszam.ToString();
            }
            else
            {
                FeherPontSzam.Text = "A pontszám: " + player1.Pontszam.ToString();
                FeketePontszam.Text = "A pontszám: " + player2.Pontszam.ToString();
            }

        }
        private void NevekLblSzepites()
        {
            FeherLBL.TextAlign = ContentAlignment.MiddleCenter;
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
            matrix[i, j]=new Korongok(new PictureBox(),false,"üres");
            matrix[i, j].Kep.Parent = this;
            matrix[i, j].Kep.Name = i + "_" + j;
            matrix[i, j].Kep.Size = new Size(41, 41);
            matrix[i, j].Kep.Location = new Point(256 + 60 * j, 31 + 60 * i);
            matrix[i, j].Kep.BackColor = Color.FromArgb(0, 0, 0, 50);
            matrix[i, j].Kep.BringToFront();
            matrix[i, j].Kep.SizeMode = PictureBoxSizeMode.StretchImage;
            matrix[i, j].Kep.Click += new EventHandler(Klikkeles);
        }
        private void Klikkeles(object sender, EventArgs e)
        {
            PictureBox klikkelt=sender as PictureBox;
            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[0]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            //MessageBox.Show(sor.ToString() + " "+ oszlop.ToString());

            FeketevFeher(sor,oszlop);
        }
        private void FeketevFeher(int sor, int oszlop)
        {
            //fekete
            if (kiJon == 0)
            {
                if (!matrix[sor, oszlop].VaneRajta)
                {
                    if (player1.MelyikSzin == "fekete")
                    {
                        nevAlattiKorongok[player1.NemTablanLevoKorongokSzama - 1].Fekete.Visible = false;
                        player1.NemTablanLevoKorongokSzama--;
                        player1.TablanLevoKorongokSzama++;
                    }
                    else
                    {
                        nevAlattiKorongok[player2.NemTablanLevoKorongokSzama - 1].Fekete.Visible = false;
                        player2.NemTablanLevoKorongokSzama--;
                        player2.TablanLevoKorongokSzama++;
                    }
                    matrix[sor, oszlop].Kep.Image = Image.FromFile(@"feketekorong.png");
                    matrix[sor, oszlop].VaneRajta = true;
                    matrix[sor, oszlop].MelyikSzin = "fekete";
                    Ellenorzes(sor, oszlop);
                    kiJon = 1;
                }
            }
            //fehér
            else
            {
                if (!matrix[sor, oszlop].VaneRajta)
                {
                    if (player1.MelyikSzin == "fehér")
                    {
                        nevAlattiKorongok[player1.NemTablanLevoKorongokSzama - 1].Feher.Visible = false;
                        player1.NemTablanLevoKorongokSzama--;
                        player1.TablanLevoKorongokSzama++;
                    }
                    else
                    {
                        nevAlattiKorongok[player2.NemTablanLevoKorongokSzama - 1].Feher.Visible = false;
                        player2.NemTablanLevoKorongokSzama--;
                        player2.TablanLevoKorongokSzama++;
                    }
                    matrix[sor, oszlop].Kep.Image = Image.FromFile(@"feherkorong.png");
                    matrix[sor, oszlop].VaneRajta = true;
                    matrix[sor, oszlop].MelyikSzin = "fehér";
                    Ellenorzes(sor, oszlop);
                    kiJon = 0;
                }
            }
            
        }
        private void Ellenorzes(int sor, int oszlop)
        {
            ElfogytakAKorongok();
            // ITT IS MÉG SOK ELLENŐRZÉS
        }
        private void Csere()
        {
            Player segedplayer = player1;
            player1 = player2;
            player2 = segedplayer;
        }
        private void ElfogytakAKorongok()
        {
            if (player1.TablanLevoKorongokSzama + player1.NemTablanLevoKorongokSzama < 3)
            {
                player2.Pontszam ++;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            if (player2.TablanLevoKorongokSzama + player2.NemTablanLevoKorongokSzama < 3)
            {
                player1.Pontszam ++;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
        }
        private void FeherFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MelyikSzin == "fehér")
            {
                player2.Pontszam++;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player2.Pontszam++;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);

            }
        }
        private void FeketeFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MelyikSzin == "fekete")
            {
                player1.Pontszam ++;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player1.Pontszam ++;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
        }
        private void TovabbJatszik(DialogResult valasz)
        {
            if (valasz == DialogResult.Yes)
            {
                //értékek, játékosok csere megadása még !!!
                Csere();
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
