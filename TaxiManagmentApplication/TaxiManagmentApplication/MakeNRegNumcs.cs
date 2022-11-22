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
using TaxiCompany;

namespace TaxiManagmentApplication
{
    public partial class MakeNRegNumcs : Form
    {
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University\3-ти курс\5-ти семестър\Технология на Софтуерното Производство\Проект\vs2022 проект\TaxiManagmentApplication.accdb";
        OleDbConnection dbConnect = new OleDbConnection();
        public MakeNRegNumcs()
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
           "SELECT Cars.KodTaxi, Cars.RegNomer, Cars.Mark, Orders.OrdTime" +
           " FROM Cars " +
           "RIGHT JOIN Orders " +
           "ON Cars.KodTaxi = Orders.KodTaxi " +
           "WHERE(((Orders.OrdTime) <#" + dateTimePicker1.Text + "#))";

            OleDbCommand cmd = new OleDbCommand(query, dbConnect);
            
            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            cmd.ExecuteNonQuery();
            dbConnect.Close();
            view(query);
        }
    }
}
