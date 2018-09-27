using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharpToMySQLtestApp
{
    public partial class AppForTest : Form
    {
        public AppForTest()
        {
            InitializeComponent();
        }

        string MySQLConnStr;

        private void buttonTestConn_Click(object sender, EventArgs e)
        {
            runtest();
        }

        private void runtest()
        {
            MySQLConnStr = "datasource ="+ textBoxDatasource.Text +"; port = "+ textBoxPort.Text +"; username = "+ textBoxUsername.Text +"; password ="+ textBoxPassword.Text +"; database = "+ textBoxDatabase.Text + "; SslMode=none";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnStr);

            try
            {
                databaseConnection.Open();
                MessageBox.Show("Konekcija uspostavljena");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show("Konekcija nije valjana! \nGreška konekcije u:\n "+ ex.Message);
            }
        }

        private void buttonDodajUBazu_Click(object sender, EventArgs e)
        {
            addEvent();
        }

        private void addEvent()
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "INSERT INTO event(`place`, `date_in`, `tag_ID`) VALUES ('"+ textBoxPlace.Text + "', '" + theDate.ToString("yyyy-MM-dd H:mm:ss") + "', '" + textBoxTag.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnStr);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Event succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
