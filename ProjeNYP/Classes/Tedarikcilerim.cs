using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProjeNYP
{
    public class Tedarikcilerim
    {


        public void addProduct(string id,int stock,int placeId)
        {

            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string insertQuery = "INSERT INTO urunler(urunAdi,fiyat,stokDurumu,subeID,kategori) VALUES(@productName,@price,@stock,@placeID,@category)";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                if(readCategory(id) == "Temizlik Ürünleri") {

                    cmd.CommandText = insertQuery;

                    cmd.Parameters.AddWithValue("@productName",readProductName(id));
                    cmd.Parameters.AddWithValue("@price", Math.Round(readPrice(id) + readPrice(id) * 0.4,2));
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@placeID", placeId);
                    cmd.Parameters.AddWithValue("@category", readCategory(id));

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                }
                else if(readCategory(id) == "Gıda Ürünleri") {

                    cmd.CommandText = insertQuery;

                    cmd.Parameters.AddWithValue("@productName", readProductName(id));
                    cmd.Parameters.AddWithValue("@price", Math.Round(readPrice(id) + readPrice(id) * 0.5, 2));
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@placeID", placeId);
                    cmd.Parameters.AddWithValue("@category", readCategory(id));

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                }
                else if(readCategory(id) == "Haftalık Kampanya Ürünleri")
                {

                    cmd.CommandText = insertQuery;

                    cmd.Parameters.AddWithValue("@productName", readProductName(id));
                    cmd.Parameters.AddWithValue("@price", Math.Round(readPrice(id) + readPrice(id) * 0.3, 2));
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@placeID", placeId);
                    cmd.Parameters.AddWithValue("@category", readCategory(id));

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }
        }

        public static double readPrice(string id)
        {

            double _price = 0;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM tedarikciler";

            try
            {
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        _price = (double)reader["fiyat"];
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
            return _price;
        }


        public void getData(DataGridView dataGridView, string type)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery1 = "SELECT *FROM tedarikciler WHERE kategori='" + type + "';";
            string selectQuery2 = "SELECT *FROM tedarikciler;";

            try
            {
                connection.Open();

                if (type == "Tüm Ürünler")
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery2, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery1, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
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
        public int readStock(string id)
        {
            int result = 0;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM tedarikciler";

            try
            {
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        result = (int)reader["stok"];
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
            return result;
        }
        public void updateStock(int getStock1,int getStock2,string id)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string insertQuery = "UPDATE tedarikciler SET stok=@stock WHERE id=@id";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

    
                    cmd.CommandText = insertQuery;

                    cmd.Parameters.AddWithValue("@id",int.Parse(id));
                    cmd.Parameters.AddWithValue("@stock", getStock1-getStock2);
   

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
            finally
            {

                connection.Close();
            }

        }
        public static string readProductName(string id) {

            string name = "";
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM tedarikciler";
            try
            {
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        name = reader["urunAdi"].ToString().TrimEnd();
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
            return name;
        }
        public static string readCategory(string id)
        {
            string category = "";
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM tedarikciler";
            try
            {
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        category = reader["kategori"].ToString().TrimEnd();
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
            return category;

        }
        public void search(DataGridView dataGridView, TextBox txtSearch)
        {

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

    }
}
