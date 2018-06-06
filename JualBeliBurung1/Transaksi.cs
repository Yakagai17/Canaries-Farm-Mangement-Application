using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class Transaksi
    {
        private string kd_transaksi, tgl_transaksi, kd_pegawai, kd_pembeli, kd_burung, harga_jual;

        public Transaksi()
        {
            this.kd_transaksi = String.Empty;
            this.tgl_transaksi = String.Empty;
            this.kd_pegawai = String.Empty;
            this.kd_pembeli = String.Empty;
            this.kd_burung = String.Empty;
            this.harga_jual = String.Empty;
        }

        public string Kd_transaksi
        {
            set { this.kd_transaksi = value; }
            get { return this.kd_transaksi; }
        }

        public string Tgl_transaksi
        {
            set { this.tgl_transaksi = value; }
            get { return this.tgl_transaksi; }
        }

        public string Kd_Pegawai
        {
            set { this.kd_pegawai = value; }
            get { return this.kd_pegawai; }
        }

        public string Kd_pembeli
        {
            set { this.kd_pembeli = value; }
            get { return this.kd_pembeli; }
        }

        public string Kd_burung
        {
            set { this.Kd_burung = value; }
            get { return this.kd_burung; }
        }

        public string Harga_jual
        {
            set { this.harga_jual = value; }
            get { return this.harga_jual; }
        }
    }
}
