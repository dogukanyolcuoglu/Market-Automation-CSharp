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
    public class Calisan
    {
        //Burada Çalışanların kayıt işlemi gerçekleşmekte
        public void saveEmployee(string nameSurname,string adress,string salary,int placeId,string position) {

            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string insertQuery = "INSERT INTO calisanlar(adSoyad,adres,maas,subeID,pozisyon,kullaniciID) VALUES(@nameSurname,@adress,@salary,@placeID,@position,@kullaniciID)";
            string insertQuery2 = "INSERT INTO calisanlar(adSoyad,adres,maas,subeID,pozisyon) VALUES(@nameSurname,@adress,@salary,@placeID,@position)";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery,connection);
                MySqlCommand cmd2 = new MySqlCommand(insertQuery2, connection);

                if(position == "Müdür")
                {
                    cmd.CommandText = insertQuery;

                    cmd.Parameters.AddWithValue("@nameSurname", nameSurname);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    cmd.Parameters.AddWithValue("@salary", double.Parse(salary));
                    cmd.Parameters.AddWithValue("@placeID", placeId);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@kullaniciID", readID(addBoss(nameSurname, position)));

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                }else
                {
                    cmd2.CommandText = insertQuery2;

                    cmd2.Parameters.AddWithValue("@nameSurname", nameSurname);
                    cmd2.Parameters.AddWithValue("@adress", adress);
                    cmd2.Parameters.AddWithValue("@salary", double.Parse(salary));
                    cmd2.Parameters.AddWithValue("@placeID", placeId);
                    cmd2.Parameters.AddWithValue("@position", position);

                    cmd2.Connection = connection;
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Başarılı bir şekilde " + nameSurname + " kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex) {

                MessageBox.Show("HATA: " +ex.Message);
            }
            finally {

                connection.Close();
            }
        }

        //Bu kısımda yeni müdür ekleme ve müdür kayıt işlemi gerçekleşmektedir.
        public static string addBoss(string nameSurname,string position) {

            string lowerName = innerTrim(nameSurname.ToLower());
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string insertQuery = "INSERT INTO kullanicilar(kullaniciAdi,parola,kullaniciTipi) VALUES(@username,@password,@type)";

            try
            {
                connection.Open();
                if(position == "Müdür") {

                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    cmd.CommandText = insertQuery;

                    if (lowerName.Contains("ğ") || lowerName.Contains("ı") || lowerName.Contains("ö") || lowerName.Contains("ü") || lowerName.Contains("ç"))
                    {

                        lowerName = lowerName.Replace("ğ", "g");
                        lowerName = lowerName.Replace("ı", "i");
                        lowerName = lowerName.Replace("ö", "o");
                        lowerName = lowerName.Replace("ü", "u");
                        lowerName = lowerName.Replace("ç", "c");

                        if (readUsername(lowerName) == true)
                        {
                            lowerName = newUsername(lowerName);
                            cmd.Parameters.AddWithValue("@username", lowerName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@username", lowerName);
                        }
                        
                    }
                    else {

                        if (readUsername(lowerName) == true)
                        {
                            lowerName = newUsername(lowerName);
                            cmd.Parameters.AddWithValue("@username", lowerName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@username", lowerName);
                        }

                    }
                    cmd.Parameters.AddWithValue("@password", createPass());
                    cmd.Parameters.AddWithValue("@type", position);

                    MessageBox.Show("Lütfen not alınız!\nKullanıcı Adınız: " + lowerName + "\nParolanız: " + createPass(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                }

            } catch (Exception ex) {

                MessageBox.Show("HATA: "+ex.Message);

            }
            finally {

                connection.Close();
            }
            return lowerName;
        }
        //String ifadelerin boşluklarını silmek için fonksyion oluşturduk. Username oluştururken kullanmak amaçlı.
        public static string innerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }

        public static string createPass()
        {
            Random rnd = new Random();

            string password = "";
            char[] pw = new char[8];
            int ascii;

            for (int i = 0; i < 8; i++)
            {
                ascii = rnd.Next(65, 91);
                pw[i] = Convert.ToChar(ascii);

               
            }
            for(int i=0; i<8; i++) {
                password += pw[i];

            }

            return password.ToLower();
        }
        //Dataları veritabanından çekme işlemi gerçekleşiyor.
        public void getData(DataGridView dataGridView, string type)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery2 = "SELECT *FROM calisanlar WHERE pozisyon='" + type + "';";
            string selectQuery1 = "SELECT *FROM calisanlar;";

            try
            {
                connection.Open();

                if (type == "Hepsi")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery1, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;

                } else{

                    MySqlDataAdapter da = new MySqlDataAdapter(selectQuery2, connection);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView.DataSource = dt;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA:" + ex.Message);
            } finally {

                connection.Close();
            }

        }
        //Database de arama yapmak için bu fonksiyonu yazdık.
        public void search(DataGridView dataGridView, string txtSearch)
        {

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1"))
            {
                connection.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("calisanlar", connection);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView.DataSource = dtbl;
                //dataGridView.Columns[0].Visible = true;
            }
        }
        public static bool readSalary(string txtId,string txtSalary)
        {
            bool isMore = false;
            double salary;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM calisanlar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == txtId)
                    {
                        salary = (double)reader["maas"];
                        if(salary > double.Parse(txtSalary))
                        {
                            isMore = true;
                            break;
                        }
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA Maas:" + ex.Message);
            }
            finally {

                connection.Close();
            }

            return isMore;
        }
        public void updateEmployee(string id,string salary, int placeId, string position,DataGridView dataGridView,string type)
        {
            string updateQuery;
            string updateQuery2;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");

            try
            {
                connection.Open();
                if (salary != "" && placeId != -1 && position != "")
                {
                    if(readSalary(id,salary) == false)
                    {
                        //hepsi
                        updateQuery = "UPDATE calisanlar SET maas=@salary ,subeID=@placeId ,pozisyon=@position WHERE id=@id";
                        updateQuery2 = "UPDATE calisanlar SET maas=@salary ,subeID=@placeId ,pozisyon=@position ,kullaniciID=@kid WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        MySqlCommand cmd2 = new MySqlCommand(updateQuery2, connection);

                        if (position == "Müdür Yardımcısı")
                        {

                            if (readPosition(id) == "Müdür")
                            {

                                MessageBox.Show("Bu işlem gerçekleşemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else if (readPosition(id) == "Kasiyer")
                            {
                                cmd.CommandText = updateQuery;

                                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                                cmd.Parameters.AddWithValue("@salary", double.Parse(salary));
                                cmd.Parameters.AddWithValue("@placeId", placeId);
                                cmd.Parameters.AddWithValue("@position", position);

                                cmd.Connection = connection;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        else if (position == "Müdür")
                        {
                            cmd2.CommandText = updateQuery2;

                            cmd2.Parameters.AddWithValue("@id", int.Parse(id));
                            cmd2.Parameters.AddWithValue("@salary", double.Parse(salary));
                            cmd2.Parameters.AddWithValue("@placeId", placeId);
                            cmd2.Parameters.AddWithValue("@position", position);
                            cmd2.Parameters.AddWithValue("@kid", readID(addBoss(readName(id), position)));

                            cmd2.Connection = connection;
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else {

                        MessageBox.Show("Güncel Maaştan düşük bir maaş girilemez!", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                if (salary != "" && placeId == -1 && position == "")
                {
                    if (readSalary(id, salary) == false)
                    {
                        //sadece salary
                        updateQuery = "UPDATE calisanlar SET maas=@salary WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        cmd.CommandText = updateQuery;

                        cmd.Parameters.AddWithValue("@id", int.Parse(id));
                        cmd.Parameters.AddWithValue("@salary", double.Parse(salary));

                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Güncelleme başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {

                        MessageBox.Show("Güncel Maaştan düşük bir maaş girilemez!", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                if (placeId != -1 && salary == "" && position == "")
                {
                    //sadece placeid
                    updateQuery = "UPDATE calisanlar SET subeID=@placeId WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.CommandText = updateQuery;

                    cmd.Parameters.AddWithValue("@id", int.Parse(id));
                    cmd.Parameters.AddWithValue("@placeId", placeId);

                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Güncelleme başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (position != "" && salary == "" && placeId == -1)
                {
                    //sadece position
                    updateQuery = "UPDATE calisanlar SET pozisyon=@position WHERE id=@id";
                    updateQuery2 = "UPDATE calisanlar SET pozisyon=@position,kullaniciID=@kid WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    MySqlCommand cmd2 = new MySqlCommand(updateQuery2, connection);

                    if (position == "Müdür Yardımcısı")
                    {

                        if (readPosition(id) == "Müdür")
                        {

                            MessageBox.Show("Bu işlem gerçekleşemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (readPosition(id) == "Kasiyer")
                        {
                            cmd.CommandText = updateQuery;

                            cmd.Parameters.AddWithValue("@id", int.Parse(id));
                            cmd.Parameters.AddWithValue("@position", position);

                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else if (position == "Müdür")
                    {
                        cmd2.CommandText = updateQuery2;

                        cmd2.Parameters.AddWithValue("@id", int.Parse(id));
                        cmd2.Parameters.AddWithValue("@position", position);
                        cmd2.Parameters.AddWithValue("@kid", readID(addBoss(readName(id), position)));

                        cmd2.Connection = connection;
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                if (salary != "" && placeId != -1 && position == "")
                {
                    if (readSalary(id, salary) == false)
                    {
                        //salary & placeid
                        updateQuery = "UPDATE calisanlar SET maas=@salary, subeID=@placeId WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        cmd.CommandText = updateQuery;

                        cmd.Parameters.AddWithValue("@id", int.Parse(id));
                        cmd.Parameters.AddWithValue("@salary", double.Parse(salary));
                        cmd.Parameters.AddWithValue("@placeId", placeId);

                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Güncelleme başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {

                        MessageBox.Show("Güncel Maaştan düşük bir maaş girilemez!", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                if (salary != "" && position != "" && placeId == -1)
                {
                    if (readSalary(id, salary) == false)
                    {
                        //salary & position
                        updateQuery = "UPDATE calisanlar SET maas=@salary, pozisyon=@position WHERE id=@id";
                        updateQuery2 = "UPDATE calisanlar SET maas=@salary, pozisyon=@position, kullaniciID=@kid WHERE id=@id";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                        MySqlCommand cmd2 = new MySqlCommand(updateQuery2, connection);

                        if (position == "Müdür Yardımcısı")
                        {

                            if (readPosition(id) == "Müdür")
                            {

                                MessageBox.Show("Bu işlem gerçekleşemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else if(readPosition(id) == "Kasiyer")
                            {
                                cmd.CommandText = updateQuery;

                                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                                cmd.Parameters.AddWithValue("@salary", double.Parse(salary));
                                cmd.Parameters.AddWithValue("@position", position);

                                cmd.Connection = connection;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        else if (position == "Müdür")
                        {
                            cmd2.CommandText = updateQuery2;

                            cmd2.Parameters.AddWithValue("@id", int.Parse(id));
                            cmd2.Parameters.AddWithValue("@salary", double.Parse(salary));
                            cmd2.Parameters.AddWithValue("@position", position);
                            cmd2.Parameters.AddWithValue("@kid", readID(addBoss(readName(id), position)));

                            cmd2.Connection = connection;
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else {

                        MessageBox.Show("Güncel Maaştan düşük bir maaş girilemez!", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                if (placeId != -1 && position != "" && salary == "")
                {
                    //placeid & position
                    updateQuery = "UPDATE calisanlar SET subeID=@placeId, pozisyon=@position WHERE id=@id";
                    updateQuery2 = "UPDATE calisanlar SET subeID=@placeId, pozisyon=@position, kullaniciID=@kid WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    MySqlCommand cmd2 = new MySqlCommand(updateQuery2, connection);

                    if(position == "Müdür Yardımcısı") { 

                        if(readPosition(id) == "Müdür")
                        {

                            MessageBox.Show("Bu işlem gerçekleşemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (readPosition(id) == "Kasiyer")
                        {
                            cmd.CommandText = updateQuery;

                            cmd.Parameters.AddWithValue("@id", int.Parse(id));
                            cmd.Parameters.AddWithValue("@placeId", placeId);
                            cmd.Parameters.AddWithValue("@position", position);

                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }else if (position == "Müdür"){
                        cmd2.CommandText = updateQuery2;

                        cmd2.Parameters.AddWithValue("@id", int.Parse(id));
                        cmd2.Parameters.AddWithValue("@placeId", placeId);
                        cmd2.Parameters.AddWithValue("@position", position);
                        cmd2.Parameters.AddWithValue("@kid", readID(addBoss(readName(id), position)));

                        cmd2.Connection = connection;
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Terfi başarılı.", "Bigi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                if(salary == "" && placeId == -1 && position == "")
                {
                    MessageBox.Show("Boş değerler girdiniz işlem gerçekleşemiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                getData(dataGridView,type);
            }
            catch(Exception ex) {
                MessageBox.Show("HATA Güncelleme:" + ex.Message);

            } finally {

                connection.Close();
            }
        }
        public static string readName(string id)
        {
            string _nameSurname = "";
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM calisanlar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        _nameSurname = reader["adSoyad"].ToString().TrimEnd();
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

            return _nameSurname;
        }
        
        public static string readPosition(string id)
        {
            string _position = "";
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM calisanlar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        _position = reader["pozisyon"].ToString().TrimEnd();
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

            return _position;
        }        
        public static bool readUsername(string getUser) {

            bool isEqual = false;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM kullanicilar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["kullaniciAdi"].ToString().TrimEnd() == getUser)
                    {
                        isEqual = true;
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

            return isEqual;

        }
        public static string newUsername(string getUser)
        {
            string old = getUser;
            int i = 1;
            while(true)
            {
                getUser += i.ToString();
                if (readUsername(getUser) == false)
                {
                    break;
                }
                getUser = old;
                i++;
            }
            return getUser;
        }

        public static int readID(string userName)
        {
            int _id = 0;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM kullanicilar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["kullaniciAdi"].ToString().TrimEnd() == userName)
                    {
                        _id = (int)reader["id"];
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

            return _id;
        }

        public static int readUserID(string id)
        {
            int _kid = 0;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM calisanlar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        _kid = (int)reader["kullaniciID"];
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA user:" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return _kid;
        }

        public static int readDayCount(string id)
        {
            int day = 0;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string selectQuery = "SELECT *FROM calisanlar";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["id"].ToString().TrimEnd() == id)
                    {
                        day = (int)reader["izinHakki"];
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA izin:" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return day;
        }

        public void permissionDay(string id,int day,DataGridView dataGridView,string type)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            string updateQuery = "UPDATE calisanlar SET izinHakki=@pday WHERE id=@id";

           
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                if(readDayCount(id) > 0) {
                    if(day == 0)
                    {
                        MessageBox.Show("Lütfen 0'dan büyük bir değer giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (day <= readDayCount(id))
                    {
                        int newPday = readDayCount(id) - day;
                        cmd.CommandText = updateQuery;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@pday", newPday);

                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        getData(dataGridView,type);

                        MessageBox.Show("İşlem gerçekleşti.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Bu işlem gerçekleşemez!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else {
                    MessageBox.Show("Bu işlem gerçekleşemez!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex) {

                MessageBox.Show("HATA gün eksiltme:" + ex.Message);
            }
            finally {

                connection.Close();
            }
        }
    }
}
