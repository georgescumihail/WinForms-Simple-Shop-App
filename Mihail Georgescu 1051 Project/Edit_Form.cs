using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mihail_Georgescu_1051_Project
{
    public partial class Edit_Form : Form
    {
        private readonly form1 _f;

        public Clienti _client;
        int idClient;

        public Edit_Form(form1 f)
        {

            this._f = f;
            InitializeComponent();

        }


        public void tbEditSalveaza_Click(object sender, EventArgs e)
        {
            
            string numeEdit = tbEditNume.Text;
            string prenumeEdit = tbEditPrenume.Text;
            string adresaEdit = tbEditAdresa.Text;

            Random rnd = new Random();
            idClient = rnd.Next(1, 100000);
        

            bool isValid = true;

            if(string.IsNullOrWhiteSpace(tbEditNume.Text))
            {
                epNumeEdit.SetError(tbEditNume, "Name field empty");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbEditPrenume.Text))
            {
                epPrenumeEdit.SetError(tbEditPrenume, "Name field empty");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbEditAdresa.Text))
            {
                epAdresaEdit.SetError(tbEditAdresa, "Address field empty");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("At least one field is empty");
            }

            else
            {
                _client = new Clienti(numeEdit, prenumeEdit, idClient, adresaEdit);
                _f.setButtons(_client);
                this.Close();
              
              
            } 


        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
