using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace CW_1
{
    public class DBworker
    {
        private SQLiteConnection conn;

        public DBworker(string path)
        {
            conn = new SQLiteConnection("Data Source = " + path);
            conn.Open();

        }

        public bool DisconnectDB()
        {
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Dispose();
                }
            }
            return true;
        }

        public bool AddNewUser(string login, string password)
        {
            //  INSTERT INTO users VALUES ('users' , 'password')
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO users VALUES ('" + login + "' , '" + getHash(password) + "' ) ";
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                        return false;
                    }
                }
            }

            return false;
        }

        public bool AuthUser(string login, string password)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login = '" + login + "' and password= '" + getHash(password) + "' ";
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return false;
                    else
                        return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }
            return false;
        }

        private static string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] raw_text = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_text);
            string hash = Encoding.Unicode.GetString(raw_hash);

            sha256.Clear();

            return hash;
        }
    }
}