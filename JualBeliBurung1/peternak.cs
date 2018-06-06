using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeliBurung
{
    class Peternak
    {
        private string kd_peternak, nama_peternak, alamat;

        public Peternak()
        {
            this.kd_peternak = String.Empty;
            this.nama_peternak = String.Empty;
            this.alamat = String.Empty;
        }

        public string Kd_peternak
        {
            set { this.kd_peternak = value; }
            get { return this.kd_peternak; }
        }

        public string Nama_peternak
        {
            set { this.nama_peternak = value; }
            get { return this.nama_peternak; }
        }

        public string Alamat
        {
            set { this.alamat = value; }
            get { return this.alamat; }
        }
    }
}
