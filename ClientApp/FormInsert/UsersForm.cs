using ClientApp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.FormInsert
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();

            del_btn.Visible = false;
            red_btn.Visible = false;
        }
        int id;

        public UsersForm(int _id)
        {
            id = _id;
            InitializeComponent();
            LoadString();
        }

        void LoadString()
        {
            DB db = new DB();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter q2 = new MySqlDataAdapter($@"SELECT * FROM users WHERE id_user = '{id}'", db.GetConnection());
            q2.Fill(dt2);
            db.closeConnection();
            login_txt.Text = dt2.Rows[0][1].ToString(); 
            password_txt.Text = dt2.Rows[0][2].ToString();
            name_txt.Text = dt2.Rows[0][3].ToString();
            lastname_txt.Text = dt2.Rows[0][4].ToString();
            mail_txt.Text = dt2.Rows[0][5].ToString();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void type_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }

        private void red_btn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}