using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihail_Georgescu_1051_Project
{
    [Serializable]
    public class Facturi
    {
        public int nrFactura { get; set; }
        public float sumaPlata { get; set; }
        public int nrArticole { get; set; }
        public DateTime termenFactura { get; set; }

        public Facturi (int nrfactura, int nrarticole, DateTime termenfactura, float sumaplata)
            {
                nrFactura = nrfactura;
                sumaPlata = sumaplata;
                nrArticole = nrarticole;
                termenFactura = termenfactura;
            }
    }
}
