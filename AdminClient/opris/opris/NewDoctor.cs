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
    public partial class NewDoctor : Form
    {

        private DBConnect connect;
        private MySqlConnection con;
        private MySqlCommand com,com1,com2;
        private DBProcedure proc;
        public Boolean iIdRecord { get; set; }
        public long id_start { get; set; }
        public long id_end { get; set; }
        public long id_doctor { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patro { get; set; }
        public string spec { get; set; }
        public string hospital { get; set; }
        public ToolStripStatusLabel status;

        public NewDoctor(ToolStripStatusLabel lbl)
        {
            InitializeComponent();
            status = lbl;
        }

        

        public NewDoctor(DataGridViewRow clinic,ToolStripStatusLabel lbl )
        {
            InitializeComponent();
            Hospital_cb.Text = Convert.ToString(clinic.Cells[3].Value);
            Name_tb.Text = Convert.ToString(clinic.Cells[1].Value);
            Surname_tb.Text = Convert.ToString(clinic.Cells[0].Value);
            Patro_tb.Text = Convert.ToString(clinic.Cells[2].Value);
            Specialization_cb.Text = Convert.ToString(clinic.Cells[4].Value);

            hospital = Convert.ToString(clinic.Cells[3].Value);
            name = Convert.ToString(clinic.Cells[1].Value);
            surname = Convert.ToString(clinic.Cells[0].Value);
            patro = Convert.ToString(clinic.Cells[2].Value);
            spec = Convert.ToString(clinic.Cells[4].Value);

            DBProcedure proc = new DBProcedure();
            proc.search_id_doctor(name, surname, patro, hospital, spec);
            id_doctor = proc.id_doctor;
            status = lbl;

            if (!iIdRecord)
            {
                SaveDoctor_btn.Visible = false;
            }
        }

        private void inic()
        {
            Name_tb.Text = "";
            Surname_tb.Text = "";
            Patro_tb.Text = "";
            Specialization_cb.Text = "";
            Hospital_cb.Text = "";
            eMon_tb.Text = "";
            eTue_tb.Text = "";
            eWed_tb.Text = "";
            eThu_tb.Text = "";
            eFri_tb.Text = "";
            eSat_tb.Text = "";
            eSun_tb.Text = "";
            sMon_tb.Text = "";
            sTue_tb.Text = "";
            sWed_tb.Text = "";
            sThu_tb.Text = "";
            sFri_tb.Text = "";
            sSat_tb.Text = "";
            sSun_tb.Text = "";
        }

        private void TimeTable()
        {
            connect = new DBConnect();
            com1 = new MySqlCommand(@"SELECT * FROM doctor, startrecept
                                    where doctor.id_startrecept = startrecept.id_startrecept 
                                    and id_doctor = " + id_doctor, connect.con);
            com2 = new MySqlCommand(@"SELECT * FROM doctor, endrecept 
                                    where doctor.id_endrecept=endrecept.id_endrecept
                                    and id_doctor = " + id_doctor, connect.con);

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
        private bool SaveDoc ()
        {
            proc = new DBProcedure();
            proc.iIdRecord = iIdRecord;
            if (Name_tb.Text != "" && Surname_tb.Text != "" && Patro_tb.Text != "" && Hospital_cb.Text != "" && Specialization_cb.Text != "")
            {
                if (!iIdRecord)
                    proc.search_id_doctor(name, surname, patro, hospital, spec);
                proc.StartTime(sMon_tb.Text, sTue_tb.Text, sWed_tb.Text, sThu_tb.Text, sFri_tb.Text, sSat_tb.Text, sSun_tb.Text);
                proc.endTime(eMon_tb.Text, eTue_tb.Text, eWed_tb.Text, eThu_tb.Text, eFri_tb.Text, sSat_tb.Text, sSun_tb.Text);
                proc.AddToDoctor(Name_tb.Text, Surname_tb.Text, Patro_tb.Text, Hospital_cb.Text, Specialization_cb.Text);
                if (iIdRecord)
                {
                    status.Text = "Добавлено: " + Surname_tb.Text + " " + Name_tb.Text + " " + Patro_tb.Text;
                }
                else status.Text = "Отредактировано: " + Surname_tb.Text + " " + Name_tb.Text + " " + Patro_tb.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Пустые поля", MessageBoxButtons.OK);
                return false;
            }
        }

        

        private void NewDoctor_Load(object sender, EventArgs e)
        {
            TimeTable();
            connect = new DBConnect();
            con = new MySqlConnection();
            con = connect.con;

            com = new MySqlCommand(@"select name_clinic from clinic", con);

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
                
            com = new MySqlCommand(@"select name_specialization from specialization", con);

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

        private void SaveDoctor_btn_Click(object sender, EventArgs e)
        {
            if (SaveDoc())
                inic();
        }

        private void SaveCloseDoctor_btn_Click(object sender, EventArgs e)
        {
           if (SaveDoc())           
               this.Close();
        }

        private void CancelDoctor_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
