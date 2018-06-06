using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JualBeliBurung
{
    public partial class FormAdmin : Form
    {
        FormLogin login = new FormLogin();
        public FormAdmin()
        {
            InitializeComponent();
            if (login.user == "owner")
            {
                btn_pegawai.Enabled = false;
            }
            else
            {
                btn_pegawai.Enabled = true;

            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            FormAdmin formadmin = new FormAdmin();

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.Show();
            this.Hide();
        }


        private void btn_tambahpegawai_Click(object sender, EventArgs e)
        {

        }

        private void panel_datapegawai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_editpegawai_Click(object sender, EventArgs e)
        {

        }

        private void btn_hapuspegawai_Click(object sender, EventArgs e)
        {

        }

        private void btn_databurung_Click(object sender, EventArgs e)
        {

        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {

        }

        private void btn_pegawai_Click(object sender, EventArgs e)
        {
            FormTambahDataPegawai formpegawai = new FormTambahDataPegawai();
            formpegawai.Show();
            this.Hide();
        }

        private void btn_penjualan_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambahsupplier_Click(object sender, EventArgs e)
        {
            form_Suplai formatformsuplai = new form_Suplai();
            formatformsuplai.Show();
            this.Hide();
        }

        private void btn_tambahburung_Click(object sender, EventArgs e)
        {
            FormTambahDataBurung formtambahdataburung = new FormTambahDataBurung();
            formtambahdataburung.Show();
            this.Hide();
        }

        private void btn_hapussupplier_Click(object sender, EventArgs e)
        {
            Delete_suplai hapus_suplai = new Delete_suplai();
            hapus_suplai.Show();
            this.Hide();
        }
        
        private void btn_editsupplier_Click(object sender, EventArgs e)
        {
            update_suplai edit_suplai = new update_suplai();
            edit_suplai.Show();
            this.Hide();
        }

        private void btn_tambahpegawai_Click_1(object sender, EventArgs e)
        {
            FormTambahDataPegawai tambahPegawai = new FormTambahDataPegawai();
            tambahPegawai.Show();
            this.Hide();
        }

        private void btn_hapusdataburung_Click(object sender, EventArgs e)
        {
            DeleteBurung hapusburung = new DeleteBurung();
            hapusburung.Show();
            this.Hide();
        }

        private void btn_editburung_Click(object sender, EventArgs e)
        {
            FormEditDataBurung ubahBurung = new FormEditDataBurung();
            ubahBurung.Show();
            this.Hide();
        }

        private void btn_hapuspegawai_Click_1(object sender, EventArgs e)
        {
            DeletePegawai hapusPegawai = new DeletePegawai();
            hapusPegawai.Show();
            this.Hide();
        }

        private void btn_editpegawai_Click_1(object sender, EventArgs e)
        {
            formUpdatePegawai editPegawai = new formUpdatePegawai();
            editPegawai.Show();
            this.Hide();
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            FormLogin newLogin = new FormLogin();
            newLogin.Show();
            this.Hide();
        }
    }
}
