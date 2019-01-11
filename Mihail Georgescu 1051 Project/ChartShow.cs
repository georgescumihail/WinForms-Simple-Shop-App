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
    public partial class ChartShow : Form
    {
        List<Comenzi> comChart;
        Facturi facChart;


        public ChartShow(List<Comenzi> com)
        {
            comChart = com;

            InitializeComponent();
        }

        private void ChartShow_Load(object sender, EventArgs e)
        {
            foreach (Comenzi com in comChart)

                facChart = com.Factura;
                

        }
    }
}
