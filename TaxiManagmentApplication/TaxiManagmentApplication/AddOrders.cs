using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiCompany;

namespace TaxiManagmentApplication
{
    public partial class AddOrders : Form
    {
        Connection connection = new Connection();
        DateTime orderTime;

        public AddOrders()
        {
            InitializeComponent();
            //orderTime = DateTime.UtcNow("dd/mm/yyyy hh:mm:ss");
            //textBox5.Text = orderTime.ToString();
        }

        // Insert
        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();

            orders.NumOrd = textBox1.Text;
            orders.KodTaxi = textBox2.Text;
            orders.Address = textBox3.Text;
            orders.OrdTime = dateTimePicker1.Text;
            orders.Distance = textBox6.Text;
            orders.Fare = textBox7.Text;

            connection.InsertOrders(orders);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}