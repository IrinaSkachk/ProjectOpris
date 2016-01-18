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
    public partial class Autorization : Form
    {

        private Hospital hospital;

        public Autorization()
        {
            InitializeComponent();
        }

        
        private void enter_btn_Click(object sender, EventArgs e)
        {
            
            Data.log = login_tb.Text;
            Data.pass = Password_tb.Text;

            DBConnect con = new DBConnect();
            if (con.OpenConnection())
            {
                this.Hide();
                hospital = new Hospital();
                  hospital.Show();
                con.CloseConnection();
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
       }
}
