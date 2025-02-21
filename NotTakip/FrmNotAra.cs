using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotTakip
{
    public partial class FrmNotAra : Form
    {
        public FrmNotAra()
        {
            InitializeComponent();
        }
        string baglanti = @"Server=LAPTOP-QD8VUNPD\SQLEXPRESS;Database=OgrenciKayit;Integrated Security=True;";


        private void FrmNotAra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(baglanti))
                {
                    connection.Open();

                    string sql = "SELECT Ad, Soyad, OgrenciNo, MidtermNot, FinalNot FROM Ogrenciler WHERE OgrenciNo = @OgrenciNo";
                    using (SqlCommand komut = new SqlCommand(sql, connection))
                    {
                        komut.Parameters.AddWithValue("@OgrenciNo", txtOgrenciNo.Text);

                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            listView1.Items.Clear(); 

                            if (reader.Read()) 
                            {
                                ListViewItem item = new ListViewItem(reader["Ad"].ToString());
                                item.SubItems.Add(reader["Soyad"].ToString());
                                item.SubItems.Add(reader["OgrenciNo"].ToString());
                                item.SubItems.Add(reader["MidtermNot"].ToString());
                                item.SubItems.Add(reader["FinalNot"].ToString());

                                listView1.Items.Add(item);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci bulunamadı!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
