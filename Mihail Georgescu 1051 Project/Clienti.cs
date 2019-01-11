using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihail_Georgescu_1051_Project
{
    public class Clienti: ICloneable
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public int codClient { get; set; }
        public string adresa { get; set; }
        public List<Comenzi> comenzi { get; set; }

        public Clienti(string _nume, string _prenume, int codclient, string _adresa, List<Comenzi> _comenzi)
        {
            nume = _nume;
            prenume = _prenume;
            codClient = codclient;
            adresa = _adresa;
            comenzi = new List<Comenzi>(_comenzi);
        }

        public Clienti(string _nume, string _prenume, int codclient, string _adresa)
        {
            nume = _nume;
            prenume = _prenume;
            codClient = codclient;
            adresa = _adresa;
        }

        public object Clone()
        {
            var newClient = (Clienti)MemberwiseClone();

            newClient.comenzi = new List<Comenzi>(comenzi);

            for (var i = 0; i < comenzi.Count(); i++)
            {
                newClient.comenzi[i] = comenzi[i]; 
            }
            return newClient;
        }
    }
}
