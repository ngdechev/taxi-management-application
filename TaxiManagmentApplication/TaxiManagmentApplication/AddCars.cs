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
    public partial class AddCars : Form
    {

        Connection connection = new Connection();

        public AddCars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();

            /*
             if (textBox1.Text == "")
                System.Windows.Forms.MessageBox.Show("Това поле не може да бъде празно!");
            else 
                cars.KodTaxi = textBox1.Text;

            if (textBox2.Text == "")
                System.Windows.Forms.MessageBox.Show("Това поле не може да бъде празно!");
            else
                cars.RegNomer = textBox2.Text;

            if (textBox3.Text == "")
                System.Windows.Forms.MessageBox.Show("Това поле не може да бъде празно!");
            else
                cars.Mark = textBox3.Text;

            if (int.Parse(textBox4.Text) >= 3 && int.Parse(textBox4.Text) <= 10)
                cars.Seats = textBox4.Text;
            else
                MessageBox.Show("Местата могат да бъдат от 3 до 7.");

            if (textBox5.Text.ToLower() == "да")
                cars.Luggage = true;
            else
                cars.Luggage = false;

            if (textBox6.Text == "")
                System.Windows.Forms.MessageBox.Show("Това поле не може да бъде празно!");
            else
                cars.Driver = textBox6.Text;
             */

            cars.KodTaxi = textBox1.Text;
            cars.RegNomer = textBox2.Text;
            cars.Mark = textBox3.Text;
            cars.Seats = textBox4.Text;

            if (textBox5.Text.ToLower() == "да")
                cars.Luggage = true;
            else
                cars.Luggage = false;

            cars.Driver = textBox6.Text;

            connection.InsertCars(cars);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
