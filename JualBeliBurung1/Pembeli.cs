using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class Pembeli
    {
        private string kd_pembeli, nama_pembeli, no_hp, no_ktp, alamat;

        public Pembeli()
        {
            this.kd_pembeli = String.Empty;
            this.nama_pembeli = String.Empty;
            this.no_hp = String.Empty;
            this.no_ktp = String.Empty;
            this.alamat = String.Empty;

        }

        public string Kd_pembeli
        {
            set { this.kd_pembeli = value; }
            get { return this.kd_pembeli; }
        }

        public string Nama_pembeli
        {
            set { this.nama_pembeli = value; }
            get { return this.nama_pembeli; }
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
    }
}
