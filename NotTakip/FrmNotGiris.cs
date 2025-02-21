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
    public partial class FrmNotGiris : Form
    {
        public FrmNotGiris()
        {
            InitializeComponent();
        }

        private void txtGecmeNotu_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int midterm = int.Parse(txtMidtermNotu.Text);
                int final = int.Parse(txtFinalNotu.Text);
                int gecmeNotu = int.Parse(txtGecmeNotu.Text);

                int ort = (midterm + final) / 2;

                if (ort < gecmeNotu)
                {
                    MessageBox.Show("Dersten Kaldınız! ");
                }
                else if (ort >= 90)
                {
                    MessageBox.Show("Tebrikler Ders Notunuz AA ! ");
                }
                else if (ort >= 80)
                {
                    MessageBox.Show("Tebrikler Ders Notunuz BB ! ");
                }
                else if (ort >= 70)
                {
                    MessageBox.Show("Tebrikler Ders Notunuz CC ! ");
                }
                else if (ort >= 60)
                {
                    MessageBox.Show("Tebrikler Ders Notunuz DD ! ");
                }
                else
                {
                    MessageBox.Show("Dersten Kaldınız! ");
                }
            }

        }
    }

