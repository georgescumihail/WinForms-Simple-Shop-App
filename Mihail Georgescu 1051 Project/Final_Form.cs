using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mihail_Georgescu_1051_Project
{
    public partial class Final_Form : Form
    {
        
        public BindingList<Facturi> produse;
        public Clienti clientNou;
        string ArticoleBuilder;
        Facturi facturaNoua;
        Comenzi altacomanda;
        private const string ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =\"Database.mdb\";Persist Security Info=True";

        public Final_Form(Clienti client)
        {
            clientNou = new Clienti(client.nume, client.prenume, client.codClient, client.adresa, client.comenzi);
            
            InitializeComponent();
        }


        private void Final_Form_Load(object sender, EventArgs e)
        {
            tbClientFinal.Text = "Client " + clientNou.nume + " " + clientNou.prenume + " with ID " + clientNou.codClient.ToString() + " and address " + clientNou.adresa + " has the following orders:";
            foreach (Comenzi comanda in clientNou.comenzi)
            {
                
                foreach (string s in comanda.Articole)
                {
                    ArticoleBuilder = ArticoleBuilder + s + ", ";
                }
                var listviewitem = new ListViewItem(comanda.NrComanda.ToString());
                listviewitem.SubItems.Add(comanda.DataComanda.ToShortDateString());
                listviewitem.SubItems.Add(comanda.DataLivrare.ToShortDateString());
                listviewitem.SubItems.Add(ArticoleBuilder.ToString());
                facturaNoua = comanda.Factura;
                listviewitem.SubItems.Add(facturaNoua.nrFactura.ToString());
                listviewitem.SubItems.Add(facturaNoua.nrArticole.ToString());
                listviewitem.SubItems.Add(facturaNoua.termenFactura.ToString());
                listviewitem.SubItems.Add(facturaNoua.sumaPlata.ToString());

                lvComenzi.Items.Add(listviewitem);

                ArticoleBuilder = null;

            }
            altacomanda = clientNou.comenzi[clientNou.comenzi.Count-1];
            AdaugaFactura(altacomanda.Factura);
            
            MessageBox.Show("The order was sent! The invoice was saved to the database.", "Success");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("order list.txt"))
            {
                sw.WriteLine( "Client " + clientNou.nume + " " + clientNou.prenume + " with ID " + clientNou.codClient.ToString() + " and address " + clientNou.adresa + " has the following orders:");

                foreach (Comenzi comanda in clientNou.comenzi)
                {
                    foreach (string s in comanda.Articole)
                    {
                        ArticoleBuilder = ArticoleBuilder + s + ", ";
                    }
                    facturaNoua = comanda.Factura;
                    sw.WriteLine(comanda.NrComanda + "   " + comanda.DataComanda + "   " + comanda.DataLivrare + "   " + ArticoleBuilder + "   " +
                        facturaNoua.nrFactura + "   " + facturaNoua.nrArticole + "   " + facturaNoua.termenFactura + "   " + facturaNoua.sumaPlata);

                }
            }

            MessageBox.Show("The order list was saved into orderlist.txt file", "Lists saved");
        }

        public void AdaugaFactura(Facturi factura)
        {
            var queryString = "insert into Facturi(NrFactura, TermenPlata, NrArticole, Suma)" +
                                  " values(@nrfactura, @termenplata, @nrarticole, @suma);";

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var insertCommand = new OleDbCommand(queryString, connection);
                var nrfacturaParameter = new OleDbParameter("@nrfactura", factura.nrFactura);
                var termenplataParameter = new OleDbParameter("@termenplata", factura.termenFactura.ToString());
                var nrarticoleParameter = new OleDbParameter("@nrarticole", factura.nrArticole);
                var sumaParameter = new OleDbParameter("@suma", factura.sumaPlata);
                insertCommand.Parameters.Add(nrfacturaParameter);
                insertCommand.Parameters.Add(termenplataParameter);
                insertCommand.Parameters.Add(nrarticoleParameter);
                insertCommand.Parameters.Add(sumaParameter);
                insertCommand.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("SELECT @@Identity;", connection);
                factura.nrFactura = (int)getIdCommand.ExecuteScalar();


            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartShow chartShow = new ChartShow(clientNou.comenzi);
            chartShow.Show();
        }
    }
}
