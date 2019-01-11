using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihail_Georgescu_1051_Project
{
    [Serializable]
    public class Comenzi : ICloneable
    {
        public int NrComanda { get; set; }
        public DateTime DataComanda { get; set; }
        public DateTime DataLivrare { get; set; }
        public List<string> Articole { get; set; }
        public Facturi Factura { get; set; }

        public Comenzi(int nrcomanda, DateTime datacomanda, DateTime datalivrare, Facturi _factura, List<string> _articole)
        {
            NrComanda = nrcomanda;
            DataComanda = datacomanda;
            DataLivrare = datalivrare;
            Factura = _factura;
            Articole = _articole;

        }

        public object Clone()
        {
            var newComanda = (Comenzi)MemberwiseClone();
            newComanda.Articole = new List<string>(Articole);
            for (var i = 0; i < Articole.Count(); i++)
            {
                newComanda.Articole[i] = Articole[i];
            }
            return newComanda;
        }
    }
}

