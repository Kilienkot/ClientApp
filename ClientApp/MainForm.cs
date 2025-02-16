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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            MiniApp.SizeMode = TabSizeMode.Fixed;
            MiniApp.Appearance = TabAppearance.FlatButtons; //Скрытие TabControl
            MiniApp.ItemSize = new Size(0, 1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablePage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableForm tf = new tableForm("users", "пользователи");
            this.Hide();
            tf.ShowDialog();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableForm tf = new tableForm("products", "товары");
            this.Hide();
            tf.ShowDialog();
        }

        private void типыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableForm tf = new tableForm("types_products", "типы товаров");
            this.Hide();
            tf.ShowDialog();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableForm tf = new tableForm("orders", "заказы");
            this.Hide();
            tf.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}





