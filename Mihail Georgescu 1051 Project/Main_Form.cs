using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mihail_Georgescu_1051_Project
{
    public partial class form1 : Form
    {
        #region Attributes

        public Comenzi comanda2;
        private List<string> ProduseAlese;
        private List<string> Produse;
        public Clienti client;
        public Comenzi comanda;
        public Facturi factura;
        public int nrCom = 0;
        public List<Comenzi> listaComenzi;
      //  private const string ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =\"Database.mdb\";Persist Security Info=True";
        #endregion

        public form1()
        {
            ProduseAlese = new List<string>();
            Produse = new List<string>();
            listaComenzi = new List<Comenzi>();
            Produse.Add("Telefon Nokia 3310");
            Produse.Add("Telefon Nokia 8 Sirocco");
            Produse.Add("Telefon Samsung Galaxy S8");
            Produse.Add("Telefon iPhone X");
            Produse.Add("Tableta iPad mini");
            Produse.Add("Acme paleta ping-pong");
            Produse.Add("Acme prajitor de paine");
            Produse.Add("Detergent capsule Ariel tide pods");
            Produse.Add("Ochelari de soare UltraRay");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string _produs in Produse)
            {
                cbProdus.Items.Add(_produs);
            }

        }

        private void AfisareProdus(string produs)
        {

            var listViewItem = new ListViewItem(produs);
            lvProduse.Items.Add(listViewItem);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProdus.Text))
            {
                MessageBox.Show("Selectati un produs", "Eroare");
            }
            else
            {
                ProduseAlese.Add(cbProdus.Text);
                string produsNou = cbProdus.Text;
                AfisareProdus(produsNou);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Form editform = new Edit_Form(this);

            editform.Show();

        }


        public void setButtons(Clienti clientNou)
        {

            tbNumeClient.Text = clientNou.nume;
            tbPrenumeClient.Text = clientNou.prenume;
            string cod = clientNou.codClient.ToString();
            tbIdClient.Text = cod;
            tbAdresaClient.Text = clientNou.adresa;
            epClient.SetError(btnEdit, null);
        }


        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Little demo shop app. Enjoy buying virtual products! :D", "About (Ver. 0.0.0.1)");
        }

        private void clientNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Form editform = new Edit_Form(this);
            editform.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnFinal_Click(object sender, EventArgs e)
        {
            if (lvProduse.Items.Count == 0)
            {
                MessageBox.Show("Select at least one product", "Empty Basket");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbNumeClient.Text))
                {
                    epClient.SetError(btnEdit, "Create a client");
                    MessageBox.Show("Insert client data first", "");
                }
                else
                {
                    nrCom = nrCom + 1;
                    DateTime dataCom = DateTime.Now;
                    DateTime dataLiv = DateTime.Now.AddDays(3);
                    DateTime termFact = DateTime.Now.AddDays(28);
                    int nritems = ProduseAlese.Count;
                    int pret = nritems * 200;
                    Facturi factura = new Facturi(nrCom, nritems, termFact, pret);
                    Comenzi comanda = new Comenzi(nrCom, dataCom, dataLiv, factura, ProduseAlese);
                    Comenzi comanda2 = (Comenzi)comanda.Clone();
                    listaComenzi.Add(comanda2);
                    int cod = Int32.Parse(tbIdClient.Text);
                    Clienti client = new Clienti(tbNumeClient.Text, tbPrenumeClient.Text, cod, tbAdresaClient.Text, listaComenzi);
                    Clienti client2 = (Clienti)client.Clone();
                    Final_Form finalform = new Final_Form(client2);
                    finalform.Show();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                btnEdit_Click(sender, new EventArgs());
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaComenzi.Count() == 0)
            {
                MessageBox.Show("Place an order first", "Action unavailable");
            }
            else
            {
                BinaryFormatter f = new BinaryFormatter();
                using (FileStream s = File.Create("serialize.bin"))
                    f.Serialize(s, listaComenzi);
                MessageBox.Show("Data has been succesfully serialized", "Serialized");
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("serialize.bin"))
            {
                BinaryFormatter f = new BinaryFormatter();
                using (FileStream s = File.OpenRead("serialize.bin"))
                {
                    listaComenzi = (List<Comenzi>)f.Deserialize(s);
                }
                MessageBox.Show("Data has been succesfully deserialized", "Deserialized");
            }
            else
            {
                MessageBox.Show("There is no serialized data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvProduse.Items.Clear();
            ProduseAlese.Clear();
        }
    }
}

