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
    public partial class SumByTaxiOrders : Form
    {
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University\3-ти курс\5-ти семестър\Технология на Софтуерното Производство\Проект\vs2022 проект\TaxiManagmentApplication.accdb";
        OleDbConnection dbConnect = new OleDbConnection();

        public SumByTaxiOrders()
        {
            InitializeComponent();
        }

        void view(string mySelect)
        {
            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, dbConnect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dbConnect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string query = 
                "SELECT DISTINCTROW Cars.RegNomer, Sum(Orders.Fare) AS [Total] " +
                "FROM Cars INNER JOIN Orders ON Cars.[KodTaxi] = Orders.[KodTaxi] " +
                "GROUP BY Cars.RegNomer";


            OleDbCommand cmd = new OleDbCommand(query, dbConnect);

            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            cmd.ExecuteNonQuery();
            dbConnect.Close();
            view(query);
        }
    }
}
