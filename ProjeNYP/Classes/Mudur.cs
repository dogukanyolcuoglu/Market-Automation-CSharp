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
    public class Mudur
    {
        public void getData(DataGridView dataGridView)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM urunler WHERE kategori='Haftalık Kampanya Ürünleri';";
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

        public void readPrice(TextBox txtId, TextBox txtSale, DataGridView dataGridView)
        {
            double fiyat;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM urunler WHERE kategori='Haftalık Kampanya Ürünleri'";

            try
            {
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == txtId.Text)
                    {
                        fiyat = (double)reader["fiyat"] - ((double)reader["fiyat"] * (double.Parse(txtSale.Text) / 100));
                        MessageBox.Show("İndirim gerçekleşti güncel fiyat: " + Math.Round(fiyat, 2), "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateProduct(Math.Round(fiyat, 2), txtId, txtSale);
                        getData(dataGridView);
                        break;
                    }

                }

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

        public void updateProduct(double price, TextBox txtId, TextBox txtSale)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string updateQuery = "UPDATE urunler SET indirimYuzdesi=@indirim, fiyat=@fiyat ,indirimTarihi=@tarih WHERE id=@id;";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);

                cmd.CommandText = updateQuery;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@indirim", "%" + txtSale.Text);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@fiyat", price);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

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
    } 
}
