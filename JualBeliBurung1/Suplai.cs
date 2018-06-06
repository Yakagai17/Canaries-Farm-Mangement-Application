using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class Suplai
    {
        private string kd_suplai, tgl_suplai, kd_burung, kd_peternak, harga_beli;

        public Suplai()
        {
            this.kd_suplai = string.Empty;
            this.tgl_suplai = string.Empty;
            this.kd_burung = string.Empty;
            this.kd_peternak = string.Empty;
            this.harga_beli = string.Empty;
        }

        public string Kd_suplai
        {
            set { this.Kd_suplai = value; }
            get { return this.Kd_suplai; }
        }

        public string Tgl_suplai
        {
            set { this.tgl_suplai = value; }
            get { return this.tgl_suplai; }
        }

        public string Kd_burung
        {
            set { this.kd_burung = value; }
            get { return this.kd_burung; }
        }

        public string Kd_peternak
        {
            set { this.kd_peternak = value; }
            get { return this.kd_peternak; }
        }

        public string Harga_beli
        {
            set { this.harga_beli = value; }
            get { return this.harga_beli; }
        }
    }
}
