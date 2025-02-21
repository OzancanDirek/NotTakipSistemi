using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNotGiris fr = new FrmNotGiris();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenNotGiriscs fr = new OgretmenNotGiriscs();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNotAra fr = new FrmNotAra();
            fr.Show();
        }
    }
}
