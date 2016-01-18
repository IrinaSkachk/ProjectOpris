using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace opris
{
    class DBConnect
    {

        public MySqlConnection con;
        private MySqlConnectionStringBuilder mysqlCSB;
        
        
        public DBConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            mysqlCSB = new MySqlConnectionStringBuilder();

            mysqlCSB.Server = "127.0.0.1";
            mysqlCSB.Database = "ToDoctor";
            mysqlCSB.UserID = Data.log;
            mysqlCSB.Password = Data.pass;
            mysqlCSB.CharacterSet = "utf8";

            con = new MySqlConnection();
            con.ConnectionString = mysqlCSB.ConnectionString;
        }

        public bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль пользователя", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch 
            {
                MessageBox.Show("Неверный логин или пароль пользователя", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
