using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ProjeNYP
{
    public class Marketlerim
    {
        public void getData(DataGridView dataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM subeler;";

            try
            {

                connection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA:" + ex.Message);

            }
            finally
            {

                connection.Close();
            }

        }

        public void search(DataGridView dataGridView, TextBox txtSearch)
        {


            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1"))
            {
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("subeler",connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

            }
        }
    }
}
