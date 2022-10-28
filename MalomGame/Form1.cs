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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1 = textBox1.Text;
            string player2 = textBox2.Text;
            if (player1.Length == 0) player1 = "Tojás1";
            if (player2.Length == 0) player2 = "Tojás2";

            Jatekter jatekter = new Jatekter(player1, player2);

            this.Visible = false;
            jatekter.ShowDialog();
            Close();
        }
    }
}
