using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotTakip
{
    public partial class OgretmenNotGiriscs : Form
    {
        public OgretmenNotGiriscs()
        {
            InitializeComponent();
        }

        string baglanti = @"Server=LAPTOP-QD8VUNPD\SQLEXPRESS;Database=OgrenciKayit;Integrated Security=True;";

        private void OgretmenNotGiriscs_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("OgrenciNo", 100);
            listView1.Columns.Add("MidtermNot", 100);
            listView1.Columns.Add("FinalNot", 100);

            VerileriGoster();
        }

        private void VerileriGoster()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(baglanti))
                {
                    connection.Open();
                    string sql = "SELECT Ad, Soyad, OgrenciNo, MidtermNot, FinalNot FROM Ogrenciler";
                    SqlCommand komut = new SqlCommand(sql, connection);
                    SqlDataReader reader = komut.ExecuteReader();

                    listView1.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Ad"].ToString());
                        item.SubItems.Add(reader["Soyad"].ToString());
                        item.SubItems.Add(reader["OgrenciNo"].ToString());
                        item.SubItems.Add(reader["MidtermNot"].ToString());
                        item.SubItems.Add(reader["FinalNot"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(baglanti))
                {
                    connection.Open();
                    string sql = "INSERT INTO Ogrenciler (Ad, Soyad, OgrenciNo, MidtermNot, FinalNot) " +
                                 "VALUES (@Ad, @Soyad, @OgrenciNo, @MidtermNot, @FinalNot)";

                    SqlCommand komut = new SqlCommand(sql, connection);
                    komut.Parameters.AddWithValue("@Ad", txtOgrenciAd.Text);
                    komut.Parameters.AddWithValue("@Soyad", txtOgrenciSoyad.Text);
                    komut.Parameters.AddWithValue("@OgrenciNo", txtOgrenciNo.Text);
                    komut.Parameters.AddWithValue("@MidtermNot", int.Parse(txtMidtermNot.Text));
                    komut.Parameters.AddWithValue("@FinalNot", int.Parse(txtFinalNot.Text));

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Öğrenci başarıyla eklendi!");

                    ListViewItem item = new ListViewItem(txtOgrenciAd.Text);
                    item.SubItems.Add(txtOgrenciSoyad.Text);
                    item.SubItems.Add(txtOgrenciNo.Text);
                    item.SubItems.Add(txtMidtermNot.Text);
                    item.SubItems.Add(txtFinalNot.Text);

                    listView1.Items.Add(item);

                    txtOgrenciAd.Clear();
                    txtOgrenciSoyad.Clear();
                    txtOgrenciNo.Clear();
                    txtMidtermNot.Clear();
                    txtFinalNot.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string ogrenciNo = selectedItem.SubItems[2].Text;  

                using (SqlConnection connection = new SqlConnection(baglanti))
                {
                    connection.Open();
                    string sql = "DELETE FROM Ogrenciler WHERE OgrenciNo = @OgrenciNo";
                    SqlCommand komut = new SqlCommand(sql, connection);
                    komut.Parameters.AddWithValue("@OgrenciNo", ogrenciNo);
                    komut.ExecuteNonQuery();
                }

                listView1.Items.Remove(selectedItem);

                MessageBox.Show("Öğrenci başarıyla silindi!");
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir öğe seçin.");
            }
        }
    }
}
