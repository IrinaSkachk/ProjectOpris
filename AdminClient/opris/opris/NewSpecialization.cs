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
    public partial class NewSpecialization : Form
    {
        private DBConnect connect;
        private MySqlCommand com;
        public string nameString;
        public Boolean iIdRecord { get; set; }
        public int dubl { get; set; }
        public ToolStripStatusLabel status;

        public NewSpecialization(string name, ToolStripStatusLabel lbl)
        {
            InitializeComponent();
            NameSpecialization_tb.Text = name;
            nameString = name;
            SaveSpecialization_btn.Visible = false;
            status = lbl;
        }

        public NewSpecialization(ToolStripStatusLabel lbl)
        {
            InitializeComponent();
            status = lbl;
        }


        private void Dubl()
        {
            connect = new DBConnect();
            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("CountDubl", connect.con);
                    com.CommandType = CommandType.StoredProcedure;
                    
                    dubl = Convert.ToInt32(com.ExecuteScalar());

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DelDubl()
        {
            connect = new DBConnect();
            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("DUBLICATE", connect.con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddSpecialization(string name)
        {
            connect = new DBConnect();
            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("SPECIALIZATION", connect.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@NewName", name);
                    com.Parameters.AddWithValue("@Name", nameString);
                    com.Parameters.AddWithValue("@id", iIdRecord);
                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool save()
        {
            if (NameSpecialization_tb.Text != "")
            {
                AddSpecialization(NameSpecialization_tb.Text);
                Dubl();
                if (dubl == 0)
                {
                    if (iIdRecord)
                    {
                    status.Text = "Добавлено: " + NameSpecialization_tb.Text;
                    }
                    else status.Text = "Отредактировано: " + NameSpecialization_tb.Text;
                    return true;
                }
                else 
                { 
                    MessageBox.Show("Уже существует специализация с таким именем!", "Ошибка");
                    DelDubl();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите значение", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
 
        }

        private void SaveSpecialization_btn_Click(object sender, EventArgs e)
        {
            if (save())
                NameSpecialization_tb.Text = "";

        }

        private void SaveCloceSpec_btn_Click(object sender, EventArgs e)
        {
            if (save())
                this.Close();
        }

    }
}
