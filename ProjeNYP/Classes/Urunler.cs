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
    public class Urunler
    {
        public void getData(DataGridView dataGridView,string type)
        {   
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery1 = "SELECT *FROM urunler WHERE kategori='"+type+"';";
            string selectQuery2 = "SELECT *FROM urunler;";

            try {

                connection.Open();

                if (type == "Tüm Ürünler"){

                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery2, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                else {
                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery1, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                
            }
            catch(Exception ex){
                MessageBox.Show("HATA:" + ex.Message);

            }finally {

                connection.Close();
            }
            
        }

        public void readPrice(TextBox txtId, TextBox txtSale, DataGridView dataGridView, string type)
        {
            double fiyat;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM urunler";

            try
            {
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if(reader["id"].ToString().TrimEnd() == txtId.Text) {
                        fiyat = (double)reader["fiyat"] - ((double)reader["fiyat"] * (double.Parse(txtSale.Text) / 100));
                        MessageBox.Show("İndirim gerçekleşti güncel fiyat: "+Math.Round(fiyat,2),"Bigi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateProduct(Math.Round(fiyat, 2), txtId,txtSale);
                        getData(dataGridView,type);
                        break;
                    }

                }

            }
            catch (Exception ex){
                MessageBox.Show("HATA:" + ex.Message);

            }finally {

                connection.Close();
            }
        }
        
        public void updateProduct(double price, TextBox txtId, TextBox txtSale) {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string updateQuery = "UPDATE urunler SET indirimYuzdesi=@indirim, fiyat=@fiyat ,indirimTarihi=@tarih WHERE id=@id;";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);

                cmd.CommandText = updateQuery;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@indirim","%"+txtSale.Text);
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd.Parameters.AddWithValue("@fiyat", price);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA:" + ex.Message);

            }finally {

                connection.Close();
            }
        }

        public void search(DataGridView dataGridView, TextBox txtSearch) {

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1"))
            {
                connection.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("urunler", connection);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView.DataSource = dtbl;
                //dataGridView.Columns[0].Visible = true;
            }
        }
        public void readStock(TextBox txtId, TextBox txtStock, DataGridView dataGridView, string type)
        {
            int result;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM urunler";

            try
            {
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == txtId.Text)
                    {
                        result = (int)reader["stokDurumu"];
                        updateStock(txtId, txtStock, result);
                        getData(dataGridView, type);
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA1:" + ex.Message);
            }finally
            {
                connection.Close();
            }
        }
        public void updateStock(TextBox txtId, TextBox txtStock, int result)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string updateQuery = "UPDATE urunler SET stokDurumu=@stok WHERE id=@id;";
            try
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);

                cmd.CommandText = updateQuery;

                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@stok", (int.Parse(txtStock.Text) + result));
             
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stok arttırma gerçekleşti güncel stok: " + (int.Parse(txtStock.Text) + result), "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA3:" + ex.Message);
            }finally
            {
                connection.Close();
            }
        }

    }
}
