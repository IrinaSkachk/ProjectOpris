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

namespace opris
{
    class DBProcedure
    {
        private DBConnect connect;
        private MySqlConnection con;
        private MySqlCommand com;
        public Boolean iIdRecord { get; set; }
        public int id_doctor { get; set; }
        public int id_start { get; set; }
        public int id_end { get; set; }

        private void DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
        }

        public void AddToDoctor(string name, string surname, string patro, string clinic, string spec)
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
            if (connect.OpenConnection())
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("DOCTOR", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Id", iIdRecord);
                    com.Parameters.AddWithValue("@Id_doctor", id_doctor);
                    com.Parameters.AddWithValue("@newName", name);
                    com.Parameters.AddWithValue("@newSurname", surname);
                    com.Parameters.AddWithValue("@newPatro", patro);
                    com.Parameters.AddWithValue("@newclinic", clinic);
                    com.Parameters.AddWithValue("@newSpec", spec);
                    com.Parameters.AddWithValue("@Id_start", Convert.ToInt32(id_start));
                    com.Parameters.AddWithValue("@Id_end", Convert.ToInt32(id_end));

                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void StartTime(string mon, string tue, string wed, string thu, string fri, string sat, string sun)
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("STARTRECEPT", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id", iIdRecord);
                    com.Parameters.AddWithValue("@id_doctor", id_doctor);
                    com.Parameters.AddWithValue("@smon", mon);
                    com.Parameters.AddWithValue("@stue", tue);
                    com.Parameters.AddWithValue("@swed", wed);
                    com.Parameters.AddWithValue("@sthu", thu);
                    com.Parameters.AddWithValue("@sfri", fri);
                    com.Parameters.AddWithValue("@ssat", sat);
                    com.Parameters.AddWithValue("@ssun", sun);

                    if (iIdRecord)
                    {
                        id_start = Convert.ToInt32(com.ExecuteScalar());
                    }
                    else com.ExecuteNonQuery();


                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void endTime(string mon, string tue, string wed, string thu, string fri, string sat, string sun)
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("ENDRECEPT", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id", iIdRecord);
                    com.Parameters.AddWithValue("@id_doctor", id_doctor);
                    com.Parameters.AddWithValue("@emon", mon);
                    com.Parameters.AddWithValue("@etue", tue);
                    com.Parameters.AddWithValue("@ewed", wed);
                    com.Parameters.AddWithValue("@ethu", thu);
                    com.Parameters.AddWithValue("@efri", fri);
                    com.Parameters.AddWithValue("@esat", sat);
                    com.Parameters.AddWithValue("@esun", sun);


                    if (iIdRecord)
                    {
                        id_end = Convert.ToInt32(com.ExecuteScalar());
                    }
                    else com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void search_id_doctor(string name, string surname, string patro, string hospital, string spec)
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
            if (connect.OpenConnection())
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("ID_DOCTOR", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@Name", name);
                    com.Parameters.AddWithValue("@Surname", surname);
                    com.Parameters.AddWithValue("@Patro", patro);
                    com.Parameters.AddWithValue("@clinic", hospital);
                    com.Parameters.AddWithValue("@Spec", spec);

                    id_doctor = Convert.ToInt32(com.ExecuteScalar());

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void del_doc(DataGridViewRow doc)
        {
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;
            if (connect.OpenConnection())
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("DELDOCTOR", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Name", Convert.ToString( doc.Cells[1].Value));
                    com.Parameters.AddWithValue("@Surname", Convert.ToString(doc.Cells[0].Value));
                    com.Parameters.AddWithValue("@Patro", Convert.ToString(doc.Cells[2].Value));
                    com.Parameters.AddWithValue("@Spec", Convert.ToString(doc.Cells[4].Value));
                    com.Parameters.AddWithValue("@Clinic", Convert.ToString(doc.Cells[3].Value));

                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch
                {
                    MessageBox.Show("Нельзя удалить, существуют связи", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }
    }
    
}
