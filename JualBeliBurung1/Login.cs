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
    public partial class FormLogin : Form
    {
        public string user;
        public FormLogin()
        {
            InitializeComponent();
            panel_admin.Hide();
            panel_owner.Hide();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_owner_Click(object sender, EventArgs e)
        {
            panel_owner.Show();
            panel_admin.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            panel_owner.Hide();
            panel_admin.Show();
        }

        private void btn_login_owner_Click(object sender, EventArgs e)
        {
            if (box_kode.Text == "901299")
            {
                FormAdmin form_admin = new FormAdmin();
                form_admin.Show();
                this.Hide();
                user = "owner";
               

            }
            else
            {
                MessageBox.Show("Kode salah..", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_login_admin_Click(object sender, EventArgs e)
        {
 
            
            if (box_id.Text == "admin1" && box_pass.Text == "jualanburung")
            {
                FormAdmin form_admin = new FormAdmin();
                form_admin.Show();
                this.Visible=false;
                user = "admin";

            }
            else
            {
                MessageBox.Show("Username atau password..", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
