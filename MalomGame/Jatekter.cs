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
        static int meret = 7;
        static PictureBox[,] matrix = new PictureBox[meret, meret];
        public Jatekter(string player1, string player2)
        {
            MatrixGeneralas();
            InitializeComponent();

        }
        private void MatrixGeneralas()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = new PictureBox();
                    matrix[i, j].Parent = this;
                    matrix[i, j].Name = i + "_" + j;
                    matrix[i, j].Size = new Size(33, 33);
                    matrix[i, j].Location = new Point(205+200 * j , 13+264 * i);
                    //matrix[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix[i, j].Image = Image.FromFile(@"feketekorong.png");
                    //matrix[i, j].BorderStyle = BorderStyle.Fixed3D;
                    matrix[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    matrix[i, j].Click += new EventHandler(Klikkeles);
                }
            }
        }

        private void Klikkeles(object sender, EventArgs e)
        {
        }
    }
}
