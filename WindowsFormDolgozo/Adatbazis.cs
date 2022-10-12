using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace WindowsFormDolgozo
{
    
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;

        public Adatbazis(string host="localhost", string user="root", string password="", string database="dolgozok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server=host;
            builder.Database=database;
            builder.UserID=user;
            builder.Password=password;
            connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            command = connection.CreateCommand();
            connection.Close();
        }
        public List<Dolgozo> osszesDolgozo()
        {
            List<Dolgozo> osszes = new List<Dolgozo>();
            command.CommandText = "SELECT `id`,`nev`,`szuletett`,`fizetes` FROM `dolgozo` WHERE 1";
            try
            {
                connection.Open();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        osszes.Add(new Dolgozo(dr.GetUInt64("id"), dr.GetString("nev"), dr.GetDateTime("szuletett"), dr.GetDecimal("fizetes")));
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return osszes;
        }
        public void ujDolgozo(Dolgozo dolgozo)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO `dolgozo`(`id`, `nev`, `szuletett`, `fizetes`) VALUES (null,'{dolgozo.Nev}','{dolgozo.Szuletett.ToString("u")}','{dolgozo.Fizetes}')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }        
        public void updateDolgozo(Dolgozo dolgozo)
        {
            try
            {
                connection.Open();
                command.CommandText = $" UPDATE `dolgozo` SET `nev`= '{dolgozo.Nev}',`szuletett`= '{dolgozo.Szuletett.ToString("u")}',`fizetes`= '{dolgozo.Fizetes}' WHERE `id`= '{dolgozo.Id}';";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
    }
}
