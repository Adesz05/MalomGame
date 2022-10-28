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
        public Jatekter(string player1, string player2)
        {
            MatrixGeneralas();
            InitializeComponent();

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
            matrix[i, j].Size = new Size(33, 33);
            matrix[i, j].Location = new Point(256 + 60 * j, 45 + 60 * i);
            //matrix[i, j].BorderStyle = BorderStyle.FixedSingle;
            //matrix[i, j].Image = Image.FromFile(@"feketekorong.png");
            //matrix[i, j].Visible = false;
            //matrix[i, j].BorderStyle = BorderStyle.Fixed3D;
            matrix[i,j].BackColor = Color.Transparent;
            matrix[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
            matrix[i, j].Click += new EventHandler(Klikkeles);
        }

        private void Klikkeles(object sender, EventArgs e)
        {
            PictureBox klikkelt=sender as PictureBox;
            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[0]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            MessageBox.Show(sor.ToString() + " "+ oszlop.ToString());
        }
    }
}
