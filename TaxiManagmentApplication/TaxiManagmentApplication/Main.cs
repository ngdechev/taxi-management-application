using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiManagmentApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void изходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавянеНаТакситаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        }

        private void добавянеНаПоръчкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrders addOrders = new AddOrders();
            addOrders.Show();
        }

        private void регистрационнияНомерИМаркатаНаТакситоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeNRegNumcs makeNRegNumcs = new MakeNRegNumcs();
            makeNRegNumcs.Show();
        }

        private void поОбщатаСумаНаПоръчкитеЗаВсякоТаксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumByTaxiOrders sumByTaxiOrders = new SumByTaxiOrders();
            sumByTaxiOrders.Show();
        }
    }
}
