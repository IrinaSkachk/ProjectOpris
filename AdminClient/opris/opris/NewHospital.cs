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
    public partial class NewHospital : Form
    {
        private DBConnect connect;
        private MySqlCommand com;
        private string name;
        private string address;
        public ToolStripStatusLabel status;

        public bool iIdRecord { get; set; }

        public NewHospital(ToolStripStatusLabel label)
        {
            InitializeComponent();
            status = label;
            
        }

        public NewHospital(string newname, string newaddress, ToolStripStatusLabel label)
        {
            InitializeComponent();
            NameClinic_tb.Text = newname;
            AddressClinic_tb.Text = newaddress;
            SaveHospital_btn.Visible = false;
            name = newname;
            address = newaddress;
            status = label;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeClinic(string newname, string newaddress)
        {
            connect = new DBConnect();

            if (connect.OpenConnection())
            {
                try
                {
                    com = new MySqlCommand("CLINIC", connect.con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@NewName", newname);
                    com.Parameters.AddWithValue("@NewAddress", newaddress);
                    com.Parameters.AddWithValue("@Name", name);
                    com.Parameters.AddWithValue("@Address", address);
                    com.Parameters.AddWithValue("@Id", iIdRecord);

                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private bool save ()
        {
            if (NameClinic_tb.Text != "" & AddressClinic_tb.Text != "")
            {
                ChangeClinic(NameClinic_tb.Text, AddressClinic_tb.Text);
                if (iIdRecord)
                    status.Text = "Добавлено: "+ NameClinic_tb.Text;
                else status.Text = "Отредактировано: " + NameClinic_tb.Text;
                return true;
            }
            else 
            { 
                MessageBox.Show("Введите значения", "Ошибка");
                return false;
            }
        }

        private void SaveHospital_btn_Click(object sender, EventArgs e)
        {
            if (save())
            {
                NameClinic_tb.Text = "";
                AddressClinic_tb.Text = "";
            }
        }

        private void SaveCloseHospital_btn_Click(object sender, EventArgs e)
        {
            if (save())
                this.Close();
        }

    }
}
