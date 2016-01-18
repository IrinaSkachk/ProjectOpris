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
    public partial class Hospital : Form
    {
        private string querySpecialization = @"Select  name_specialization as 'Специализация' 
                                              From Specialization";

        private NewDoctor doctor;
        private NewSpecialization spec;
        private NewHospital hospital;
        private DBConnect connect;
        private MySqlCommand com, com1,com2;
        private string hsql;
        private string dsql;
        public int id { get; set; }

        public Hospital()
        {
            InitializeComponent();

            hsql = GetSQLString();
            dsql = GetSQLStringDoctor();
            Hospital_dataGrid.DataSource = ToDataTable(hsql);
            Specialization_dataGrid.DataSource = ToDataTable(querySpecialization);
            Doctor_dataGrid.DataSource = ToDataTable(dsql);
            loadSpecHos();
        }

        public void statusStrip(string text)
        {
            StatusLbl.Text = text;
        }

        private void loadSpecHos()
        {
            Hospital_cb.Items.Clear();
            Specialization_cb.Items.Clear();
            connect = new DBConnect();

            com = new MySqlCommand(@"select name_clinic from clinic", connect.con);

            if (connect.OpenConnection())
            {
                using (MySqlDataReader dr = com.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        Hospital_cb.Items.Add(dr["name_clinic"].ToString());
                    }

                    dr.Close();
                }

                connect.CloseConnection();
            }

            com = new MySqlCommand(@"select name_specialization from specialization", connect.con);

             if (connect.OpenConnection())
             {
                 using (MySqlDataReader dr = com.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            Specialization_cb.Items.Add(dr["name_specialization"].ToString());
                        }

                        dr.Close();
                    }
                 connect.CloseConnection();
              }
    }

        private void TimeTable(object sender, DataGridViewCellEventArgs e)
        {
            DBProcedure proc = new DBProcedure();
            string surname = Convert.ToString(Doctor_dataGrid.CurrentRow.Cells[0].Value);
            string name = Convert.ToString(Doctor_dataGrid.CurrentRow.Cells[1].Value);
            string patro = Convert.ToString(Doctor_dataGrid.CurrentRow.Cells[2].Value);
            string clinic = Convert.ToString(Doctor_dataGrid.CurrentRow.Cells[3].Value);
            string spec = Convert.ToString(Doctor_dataGrid.CurrentRow.Cells[4].Value);

            proc.search_id_doctor(name, surname, patro, clinic, spec);

            id = proc.id_doctor;

            connect = new DBConnect();
            com1 = new MySqlCommand(@"SELECT * FROM doctor, startrecept
                                    where doctor.id_startrecept = startrecept.id_startrecept 
                                    and id_doctor = "+@id, connect.con);
            com2 = new MySqlCommand(@"SELECT * FROM doctor, endrecept 
                                    where doctor.id_endrecept=endrecept.id_endrecept
                                    and id_doctor = " + @id, connect.con);

            if (connect.OpenConnection())
            {
                using (MySqlDataReader dr = com1.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        sMon_tb.Text = dr["Monday"].ToString();
                        sTue_tb.Text = dr["Tuesday"].ToString();
                        sWed_tb.Text = dr["Wednesday"].ToString();
                        sThu_tb.Text = dr["thursday"].ToString();
                        sFri_tb.Text = dr["Friday"].ToString();
                        sSat_tb.Text = dr["saturday"].ToString();
                        sSun_tb.Text = dr["sunday"].ToString();

                    }

                    dr.Close();
                }
                connect.CloseConnection();
            }
            if (connect.OpenConnection())
            {
               using (MySqlDataReader dr = com2.ExecuteReader())
               {
                    while (dr.Read())
                    {
                        eMon_tb.Text = dr["Monday"].ToString();
                        eTue_tb.Text = dr["Tuesday"].ToString();
                        eWed_tb.Text = dr["Wednesday"].ToString();
                        eThu_tb.Text = dr["thursday"].ToString();
                        eFri_tb.Text = dr["Friday"].ToString();
                        eSat_tb.Text = dr["saturday"].ToString();
                        eSun_tb.Text = dr["sunday"].ToString();
                    }
                    dr.Close();
                }
                connect.CloseConnection();
            }
        }

        private void Hospital_load(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        string sql = GetSQLString();
                        Hospital_dataGrid.DataSource = ToDataTable(sql); 
                        break;
                    }
                case 2: Specialization_dataGrid.DataSource = ToDataTable(querySpecialization); break;
                case 1:
                    {
                        string sql = GetSQLStringDoctor();
                        Doctor_dataGrid.DataSource = ToDataTable(sql);
                        break;
                    }
            }
        }

        public void searchTo(string name, string surname, string patro, string spec, string clinic)
        {
            for (int i = 0; i < Doctor_dataGrid.RowCount; i++)
            {
                if (Doctor_dataGrid.Rows[i].Cells[0].Value.ToString().Contains(surname) & Doctor_dataGrid.Rows[i].Cells[1].Value.ToString().Contains(name)
                    & Doctor_dataGrid.Rows[i].Cells[2].Value.ToString().Contains(patro) & Doctor_dataGrid.Rows[i].Cells[3].Value.ToString().Contains(clinic)
                    & Doctor_dataGrid.Rows[i].Cells[4].Value.ToString().Contains(spec))
                        {
                            Doctor_dataGrid.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public DataTable ToDataTable(string QueryString)
        {
            
            DataTable dt = new DataTable();

            connect = new DBConnect();
            MySqlConnection con = new MySqlConnection();

            con = connect.con;

            string str = QueryString;

            MySqlCommand com = new MySqlCommand(str, con);
                
             if (connect.OpenConnection())
             {
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                            dt.Load(dr);
                    }
                   
                  connect.CloseConnection();
             }

               
            return dt;
        }

        public string GetSQLString()
        {

            string sSQL = @"Select name_clinic as 'Наименование', address as 'Адрес' from clinic WHERE Name_clinic<>''";
            if (NameSearch_tb.Text != "") sSQL += " AND Name_clinic LIKE '" + NameSearch_tb.Text + "%'";

            if (AddressSearch_tb.Text != "") sSQL += "  AND  address RLIKE  '" + AddressSearch_tb.Text + "'";
                    
            return sSQL;
        }

        public string GetSQLStringDoctor()
        {

            string sSQL = @"select surname as'Фамилия', name as 'Имя', patro as 'Отчество', 
                                              name_clinic as 'Поликлиника', name_specialization as 'Специализация' 
                                              from doctor, clinic, specialization 
                                              where doctor.id_specialization = specialization.id_specialization 
                                              and doctor.id_clinic = clinic.id_clinic";
            if (Hospital_cb.Text != "") sSQL += " AND clinic.Name_clinic LIKE '" + Hospital_cb.Text + "%'";

            if (Specialization_cb.Text != "") sSQL += " AND specialization.Name_specialization LIKE '" + Specialization_cb.Text + "%'";

            if (SearchSurname_tb.Text != "") sSQL += " AND doctor.surname LIKE '" + SearchSurname_tb.Text + "%'";
            return sSQL;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            NewHospital hospital = new NewHospital(StatusLbl);
            hospital.iIdRecord = true;
            hospital.ShowDialog();
            hsql = GetSQLString();
            Hospital_dataGrid.DataSource = ToDataTable(hsql);
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
                string hname = Convert.ToString(Hospital_dataGrid.CurrentRow.Cells[0].Value);
                string haddress = Convert.ToString(Hospital_dataGrid.CurrentRow.Cells[1].Value);
                hospital = new NewHospital(hname, haddress, StatusLbl);
                hospital.iIdRecord = false;
                hospital.ShowDialog();
                hsql = GetSQLString();
                Hospital_dataGrid.DataSource = ToDataTable(hsql);
         }

        private void AddDoctor_btn_Click(object sender, EventArgs e)
        {
                doctor = new NewDoctor(StatusLbl);
                doctor.iIdRecord = true;
                doctor.ShowDialog();
                string sql = GetSQLStringDoctor();
                Doctor_dataGrid.DataSource = ToDataTable(sql);
                
        }

        private void AddSpecialization_btn_Click(object sender, EventArgs e)
        {
            spec = new NewSpecialization(StatusLbl);
            spec.iIdRecord = true;
            spec.ShowDialog();
            Specialization_dataGrid.DataSource = ToDataTable(querySpecialization);
        }

        private void ChangeSpecialization_btn_Click(object sender, EventArgs e)
        {
            string hname = Convert.ToString(Specialization_dataGrid.CurrentRow.Cells[0].Value);
            spec = new NewSpecialization(hname, StatusLbl);
            spec.iIdRecord = false;

            spec.ShowDialog();
            Specialization_dataGrid.DataSource = ToDataTable(querySpecialization);
        }
       
        private void ChangeDoctor_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow hclinic = new DataGridViewRow();
            hclinic = Doctor_dataGrid.CurrentRow;
            doctor = new NewDoctor(hclinic, StatusLbl);
            doctor.iIdRecord = false;
            
            doctor.ShowDialog();
            string sql = GetSQLStringDoctor();
            Doctor_dataGrid.DataSource = ToDataTable(sql);
        }


        private void del_clinic()
        {
            connect = new DBConnect();

            if (connect.OpenConnection())
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("DELCLINIC", connect.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@sname", Convert.ToString(Hospital_dataGrid.CurrentRow.Cells[0].Value));
                    com.Parameters.AddWithValue("@saddress", Convert.ToString(Hospital_dataGrid.CurrentRow.Cells[1].Value));
                   
                    com.ExecuteNonQuery();

                    connect.CloseConnection();
                }
                catch 
                {
                    MessageBox.Show("Нельзя удалить, существуют связи", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void del_spec()
        {
            connect = new DBConnect();

            if (connect.OpenConnection())
            {
                try
                {
                    MySqlCommand com = new MySqlCommand("DELSPECIALIZATION", connect.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@sName",Convert.ToString(Specialization_dataGrid.CurrentRow.Cells[0].Value));
                    
                    com.ExecuteNonQuery();
                    connect.CloseConnection();
                }
                catch
                {
                    MessageBox.Show("Нельзя удалить, существуют связи", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }


        private void DelSpecialization_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow hclinic = new DataGridViewRow();
                    hclinic = Specialization_dataGrid.CurrentRow;   
            DialogResult res =  MessageBox.Show("Удалить специализацию: " + hclinic.Cells[0].Value.ToString()+"?","Удаление",MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                del_spec();
                StatusLbl.Text = "Специализация удалена " + hclinic.Cells[0].Value.ToString();
                Specialization_dataGrid.DataSource = ToDataTable(querySpecialization);
            }
        }

        private void DelDoctor_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow hclinic = new DataGridViewRow();
            hclinic = Doctor_dataGrid.CurrentRow;
            DialogResult res = MessageBox.Show("Удалить: " + hclinic.Cells[0].Value.ToString() + hclinic.Cells[1].Value.ToString() +hclinic.Cells[2].Value.ToString()+"?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                DBProcedure proc = new DBProcedure();
                proc.del_doc(hclinic);
                StatusLbl.Text = "Доктор удален: " + hclinic.Cells[0].Value.ToString() + " " + hclinic.Cells[1].Value.ToString() + " " + hclinic.Cells[2].Value.ToString();
                string sql = GetSQLStringDoctor();
                Doctor_dataGrid.DataSource = ToDataTable(sql);
                
            }

        }

        private void DelHospital_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow hclinic = new DataGridViewRow();
                hclinic = Hospital_dataGrid.CurrentRow;
            DialogResult res = MessageBox.Show("Удалить Поликлинику: " + hclinic.Cells[0].Value.ToString() + "?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                del_clinic();
                StatusLbl.Text = "Поликлиника удалена: " + hclinic.Cells[0].Value.ToString();
                string sql = GetSQLString();
                Hospital_dataGrid.DataSource = ToDataTable(sql);
            }
        }


        private void loadSearch(object sender, TabControlEventArgs e)
        {
            loadSpecHos();
        }

    }
}
