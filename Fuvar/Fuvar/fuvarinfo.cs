using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class fuvarinfo
    {
        public int Azonosito { get; set; }
        public string Idobelyegzo { get; set; }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double Viteldij { get; set; }
        public double Borravalo { get; set; }
        public string Fizetesmodja { get; set; }
        public fuvarinfo(string az, string ib, int it, double mt, double vd, double bv, string fm);
        {
            this.Azonosito = az;
            this.Idobelyegzo = ib;
            this.Idotartam = it;
            this.Tavolsag = mt;
            this.Viteldij = vd;
            this.Borravalo = bv;
            this.Fizetesmodja = fm;
            
        }

    public fuvarinfo()
    {

    }

    public fuvarinfo(string ib)
    {
        this.Idobelyegzo = ib;
    }
}
}

