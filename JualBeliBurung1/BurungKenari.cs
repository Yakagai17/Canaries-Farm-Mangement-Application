using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class BurungKenari
    {
        private string kd_burung, nama_burung, jk, warna_burung, silangan,tanggal_lahir;

        public BurungKenari()
        {
            this.kd_burung = string.Empty;
            this.nama_burung = string.Empty;
            this.jk = string.Empty;
            this.warna_burung = string.Empty;
            this.tanggal_lahir = string.Empty;
        }

        public string Kd_burung
        {
            set { this.kd_burung = value; }
            get { return this.kd_burung; }
        }

        public string Nama_burung
        {
            set { this.nama_burung = value; }
            get { return this.nama_burung; }
        }

        public string Jk
        {
            set { this.jk = value; }
            get { return this.jk; }
        }

        public string Warna_burung
        {
            set { this.warna_burung = value; }
            get { return this.warna_burung; }
        }

        public string Silangan
        {
            set { this.silangan = value; }
            get { return this.silangan; }
        }
        public string Tanggal_lahir
        {
            set { this.tanggal_lahir = value; }
            get { return this.tanggal_lahir; }
        }
    }
}
