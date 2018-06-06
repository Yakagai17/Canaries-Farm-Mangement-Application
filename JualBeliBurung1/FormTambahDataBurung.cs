using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JualBeliBurung
{
    public partial class FormTambahDataBurung : Form
    {
        BurungKenari burungKenari = new BurungKenari();

        public FormTambahDataBurung()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            FormAdmin formadmin = new FormAdmin();
            formadmin.Show();
            this.Hide();
        }

        private void FormTambahDataBurung_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            burungKenari.Kd_burung = box_kodeburung.Text.ToString();
            burungKenari.Nama_burung = box_namaburung.Text.ToString();
            burungKenari.Jk = cBox_jk.Text.ToString();
            burungKenari.Warna_burung = box_warnaburung.Text.ToString();
            burungKenari.Silangan = box_silangan.Text.ToString();
            burungKenari.Tanggal_lahir = box_tgllahir.Text.ToString();

            try
            {
                string MyConnection2 = "server=localhost;user id=root;password=;persistsecurityinfo=True;port=3306;database=db_ternak_kenari;SslMode=none";
                string Query = "INSERT INTO burung (kd_burung,nama_burung ,jns_kl ,warna_burung ,silangan ,tgl_lhr) VALUES ('" + burungKenari.Kd_burung + "','" + burungKenari.Nama_burung + "','" + burungKenari.Jk + "','" + burungKenari.Warna_burung + "','" + burungKenari.Silangan + "','" + burungKenari.Tanggal_lahir + ");";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            burungKenari.Kd_burung = String.Empty;
            burungKenari.Nama_burung = String.Empty;
            burungKenari.Jk = String.Empty;
            burungKenari.Warna_burung = String.Empty;
            burungKenari.Silangan = String.Empty;
            burungKenari.Tanggal_lahir = String.Empty;
        }
    }
}
