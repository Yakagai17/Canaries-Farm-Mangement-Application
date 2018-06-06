using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class Pegawai
    {
        private string kd_pegawai, nama_pegawai, no_hp, no_ktp, alamat, tgl_lahir, pendidikan_terakhir, pass;

        public Pegawai()
        {
            this.kd_pegawai = String.Empty;
            this.nama_pegawai = String.Empty;
            this.no_hp = String.Empty;
            this.no_ktp = String.Empty;
            this.alamat = tgl_lahir = String.Empty;
            this.pendidikan_terakhir = String.Empty;
            this.pass = string.Empty;
        }

        public string Kd_pegawai
        {
            set { this.kd_pegawai = value; }
            get { return this.kd_pegawai; }
        }

        public string Nama_pegawai
        {
            set { this.nama_pegawai = value; }
            get { return this.nama_pegawai; }
        }

        public string No_hp
        {
            set { this.no_hp = value; }
            get { return this.no_hp; }
        }

        public string No_ktp
        {
            set { this.no_ktp = value; }
            get { return this.no_ktp; }
        }

        public string Alamat
        {
            set { this.alamat = value; }
            get { return this.alamat; }
        }

        public string Pendidikan_terakhir
        {
            set { this.pendidikan_terakhir = value; }
            get { return this.pendidikan_terakhir; }
        }

        public string Pass
        {
            set { this.pass = value; }
            get { return this.pass; }
        }
    }
}
