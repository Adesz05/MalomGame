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
            if (textBox1.Text.Length == 0) player1 = "Tojás1";
            if (textBox2.Text.Length == 0) player2 = "Tojás2";

            Jatekter jatekter = new Jatekter(player1, player2);

            this.Visible = false;
            jatekter.ShowDialog();
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string message = "A játék célja az, hogy az ellenfél korongjait levegyük, vagy olyan helyzetbe kerüljünk, hogy az ellenfél képtelen legyen lépni. Ennek elsődleges módja a malmok kialakítása (függőleges vagy vízszintes sorokban három korong egymás mellett), ugyanis egy malom létrejöttével levehetünk egy korongot az ellenfél készletéből (abból, ami a táblán van). Ha valakinek csak két korongja marad, elvesztette a játékot, mert már nem tud malmot kialakítani. Viszont ha túl sok malmot alakítunk ki, nagy az esély rá, hogy beszorulunk.";
            MessageBox.Show(message, "Játékszabály", MessageBoxButtons.OK);
        }
    }
}
