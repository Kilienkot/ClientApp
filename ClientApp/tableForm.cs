using ClientApp.FormInsert;
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
using System.Xml;

namespace ClientApp
{
    public partial class tableForm : Form
    {
        string nameTable;
        string displayName;
        string sql;

        DB db = new DB();


        public tableForm(string _nameTable, string _displayName)
        {
            InitializeComponent();
            nameTable = _nameTable;
            displayName = _displayName;
        }

        private void tableForm_Load(object sender, EventArgs e)
        {
            this.Text = "Работа с таблицей: " + displayName;
            switch (nameTable)
            {
                case "users":
                    sql = $@"SELECT id_user AS 'ID', firstname 'Имя', lastname AS 'Фамилимя', login_user AS 'Лoгин', email AS 'Пoчтa', password_user AS 'Пароль' FROM users";
                    break;
                case "products":
                    sql = $@"SELECT id_product AS 'ID', name_product AS 'Hаименование', types_products.name_type_product AS 'Tиn продукта', price_product AS 'ена' FROM products, types_products WHERE products.id_type_product = types_products.id_type_product";
                    break;
                case "types_products":
                    sql = $@"SELECT id_type_product AS 'ID', name_type_product AS 'Hаименование' FROM types_products";
                    break;
                case "orders":
                    sql = $@"SELECT id_order AS 'ID', date_start_order AS 'Дaта нaчaлa', date_end_order AS 'Дата окончания', products.name_product AS 'Продукт', amount_products AS 'количество', status_order AS 'Cтатус', users.login_user AS 'Пользоватeль' FROM orders JOIN products ON orders.id_product = products.id_product JOIN users ON orders.id_user = users.id_user";
                    break;

                default:
                    MessageBox.Show("Ошибка: такой таблицы не существует");
                    this.Close();
                    break;
            }


            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();

        }

        private void tableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    switch (nameTable)
                    {
                        case "users":
                           FormInsert.UsersForm usersForm = new FormInsert.UsersForm(id);
                           usersForm.ShowDialog();
                            break;
                        case "products":
                            FormInsert.ProductsForm productsForm = new FormInsert.ProductsForm(id);
                            productsForm.ShowDialog();
                            break;
                        case "types_products":
                            FormInsert.TypeProductsForm typeproductsForm = new FormInsert.TypeProductsForm(id); typeproductsForm.ShowDialog();
                            break;
                        case "orders":
                            FormInsert.OrdersForm ordersForm = new FormInsert.OrdersForm(id);
                            ordersForm.ShowDialog();
                            break;
                            Refresh();
                    }

                }
                catch
                {
                    MessageBox.Show("Нажата пустая ячейка");
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (nameTable) { 
                case "users":
                    FormInsert.UsersForm userForm = new FormInsert.UsersForm();
                    userForm.ShowDialog();
                    break;
                case "products":
                    FormInsert.ProductsForm productForm = new FormInsert.ProductsForm();
                    productForm.ShowDialog();
                    break;
                case "types_products":
                    FormInsert.TypeProductsForm typeProductsForm = new FormInsert.TypeProductsForm();
                    productForm = new FormInsert.ProductsForm();
                    break;
                case "orders":
                    FormInsert.OrdersForm orderForm = new FormInsert.OrdersForm();
                    orderForm.ShowDialog();
                    break;

            }
        }

        private void re_btn_Click(object sender, EventArgs e)
        {
            switch (nameTable)
            {
                case "users":
                    sql = $@"SELECT id_user AS 'ID', firstname 'Имя', lastname AS 'Фамилимя', login_user AS 'Лoгин', email AS 'Пoчтa', password_user AS 'Пароль' FROM users";
                    break;
                case "products":
                    sql = $@"SELECT id_product AS 'ID', name_product AS 'Hаименование', types_products.name_type_product AS 'Tиn продукта', price_product AS 'ена' FROM products, types_products WHERE products.id_type_product = types_products.id_type_product";
                    break;
                case "types_products":
                    sql = $@"SELECT id_type_product AS 'ID', name_type_product AS 'Hаименование' FROM types_products";
                    break;
                case "orders":
                    sql = $@"SELECT id_order AS 'ID', date_start_order AS 'Дaта нaчaлa', date_end_order AS 'Дата окончания', products.name_product AS 'Продукт', amount_products AS 'количество', status_order AS 'Cтатус', users.login_user AS 'Пользоватeль' FROM orders JOIN products ON orders.id_product = products.id_product JOIN users ON orders.id_user = users.id_user";
                    break;

                default:
                    MessageBox.Show("Ошибка: такой таблицы не существует");
                    this.Close();
                    break;
            }


            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}