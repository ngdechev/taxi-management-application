using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using TaxiManagmentApplication;

namespace TaxiCompany
{
    internal class Connection
    {
        OleDbConnection connect;
        OleDbCommand command;

        private void ConnectionTo()
        {
            connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\University\3-ти курс\5-ти семестър\Технология на Софтуерното Производство\Проект\vs2022 проект\TaxiManagmentApplication.accdb");
            command = connect.CreateCommand();
        }

        public Connection()
        {
            ConnectionTo();
        }

        public void InsertCars(Cars cars)
        {
            try
            {
                command.CommandText =
                    "Insert into Cars(KodTaxi, RegNomer, Mark, Seats, Luggage, Driver) values (" + cars.KodTaxi + ",'"
                        + cars.RegNomer + "','" + cars.Mark + "',"
                        + cars.Seats + "," + cars.Luggage + ",'"
                        + cars.Driver + "')";

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Успешно добавихте такси.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        public void InsertOrders(Orders orders)
        {
            try
            {
                command.CommandText =
                    "Insert into Orders(NumOrd, KodTaxi, Address, OrdTime, Distance, Fare) values (" + orders.NumOrd + ","
                        + orders.KodTaxi + ",'" + orders.Address + "','"
                        + orders.OrdTime + "'," + orders.Distance + ","
                        + orders.Fare + ")";

                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Успешно добавихте поръчка.");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

    }
}
