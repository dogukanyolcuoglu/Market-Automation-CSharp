using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjeNYP
{
    public class Kullanici
    {
        public bool userSignInQuery(string username, string password, string type)
        {
            bool isSingIn = false;
            MySqlConnection connection = new MySqlConnection("server=localhost;database=market;port=3306;uid=root;pwd=password1");
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT *FROM kullanicilar", connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader["kullaniciAdi"].ToString().TrimEnd() == username && dataReader["parola"].ToString().TrimEnd() == password && dataReader["kullaniciTipi"].ToString().TrimEnd() == type)
                    {
                        isSingIn = true;
                        break;

                    }
                }
            }catch (Exception exception){

            }
            connection.Close();
            return isSingIn;
        }
    }
}
