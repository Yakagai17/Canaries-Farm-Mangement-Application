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
    public partial class form_Suplai : Form
    {
        public form_Suplai()
        {
            InitializeComponent();
        }

        private void form_Suplai_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            FormAdmin formadmin = new FormAdmin();
            formadmin.Show();
            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void box_hargabeli_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void box_kodepeternak_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void box_kodeburung_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void box_tanggalsuplai_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void box_kodesuplai_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
