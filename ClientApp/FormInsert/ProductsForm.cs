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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            LoadComboBox();
            
            del_btn.Visible = false;
            red_btn.Visible = false;
        }
        int id;

        public ProductsForm(int _id)
        {
            id = _id;
            InitializeComponent();
            add_btn.Visible = false;
            LoadComboBox();
            LoadString();
        }

        void LoadString()
        {
            DB db1 = new DB();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter q1 = new MySqlDataAdapter($@"SELECT * FROM products WHERE id_product = '{id}'", db1.GetConnection());
            q1.Fill(dt1);
            db1.closeConnection();
            name_txt.Text = dt1.Rows[0][1].ToString();
            type_combo.SelectedValue = dt1.Rows[0][2].ToString();
            price_txt.Text = dt1.Rows[0][3].ToString();
        }

        public void LoadComboBox()
        {
            DB db2 = new DB();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter q2 = new MySqlDataAdapter($@"SELECT * FROM types_products", db2.GetConnection());
            q2.Fill(dt2);
            type_combo.DataSource = dt2;
            type_combo.DisplayMember = "name_type_product"; 
            type_combo.ValueMember = "id_type_product";
            db2.closeConnection();
            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }

}