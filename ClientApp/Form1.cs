using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace ClientApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            autorizacion_panel.SizeMode = TabSizeMode.Fixed;
            autorizacion_panel.Appearance = TabAppearance.FlatButtons; //Скрытие TabControl
            autorizacion_panel.ItemSize = new Size(0, 1);
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            autorizacion_panel.SelectedTab = registr_page;
        }
        private void Login_btn_Click(object sender, EventArgs e)
        {
            autorizacion_panel.SelectedTab = login_page;
        }


        public Boolean CheckUserName()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand($@"SELECT * FROM users WHERE login_user = '{login_txt.Text}';", db.GetConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean CheckUserMail()
        {
            DB db = new DB();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand cmd2 = new MySqlCommand($@"SELECT * FROM users WHERE email = '{mail_txt.Text}';", db.GetConnection());
            adapter2.SelectCommand = cmd2;
            adapter2.Fill(dt2);

            int atpos = mail_txt.Text.IndexOf("@");
            int dotpos = mail_txt.Text.LastIndexOf(".");

            if (dt2.Rows.Count > 0 || atpos < 1 || dotpos < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean CheckTextBox()
        {
            string nameBox = name_txt.Text;
            string lastNameBox = surname_txt.Text;
            string emailBox = mail_txt.Text;
            string loginBox = login_txt.Text;

            if (nameBox == "" || lastNameBox == "" || emailBox == "" || loginBox == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string usern = loginUser.Text,
                   passwd = passwordUser.Text;



            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand($@"SELECT * FROM users WHERE login_user = '{usern}' AND password_user = '{passwd}';", db.GetConnection());

            if (loginUser.Text == "" || passwordUser.Text == "")
            {
                MessageBox.Show("Кажется, вы забыли заполнить одно из полей", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Авторизация прошла успешно");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            CheckTextClass nameBoxClass = new CheckTextClass(name_txt.Text);
            nameBoxClass.CheckSimbol();
            string nameUser = nameBoxClass.returnTextBox();

            CheckTextClass surnameBoxClass = new CheckTextClass(surname_txt.Text);
            surnameBoxClass.CheckSimbol();
            string surnameUser = surnameBoxClass.returnTextBox();

            CheckTextClass loginBoxClass = new CheckTextClass(login_txt.Text);
            loginBoxClass.CheckSimbol();
            string loginUser = loginBoxClass.returnTextBox();

            CheckTextClass mailBoxClass = new CheckTextClass(mail_txt.Text);
            nameBoxClass.CheckSimbol();
            string mailUser = mailBoxClass.returnTextBox();

            CheckTextClass pswrdBoxClass = new CheckTextClass(pswrd_txt.Text);
            pswrdBoxClass.CheckSimbol();
            string pswrdUser = pswrdBoxClass.returnTextBox();

            CheckTextClass enter_pswrdBoxClass = new CheckTextClass(enter_pswrd_txt.Text);
            enter_pswrdBoxClass.CheckSimbol();
            string enter_pswrdUser = enter_pswrdBoxClass.returnTextBox();

            if (pswrd_txt.Text != "")
            {
                if (pswrd_txt.Text == enter_pswrd_txt.Text)
                {
                    if (CheckTextBox())
                    {
                        if (CheckUserName())
                        {
                            if (CheckUserMail())
                            {
                                DB db = new DB();
                                MySqlCommand cmdReg = new MySqlCommand($@"INSERT INTO users (firstname, lastname, email, login_user, password_user) VALUES ('{nameUser}', '{surnameUser}', '{mailUser}', '{loginUser}', '{enter_pswrdUser}');", db.GetConnection());

                                db.openConnection();
                                if (cmdReg.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Ура, ползователь создан!!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Возникла какая то техническая неполадка. Человек, почини БД", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                db.closeConnection();
                            }
                            else
                            {
                                MessageBox.Show("Либо ты ошибся почтой, либо эта почта уже зарегестрирована", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Кажется, этот логин занят:(\nПожалуйста, выбери другой", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Вы пропустили поле", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Кажись, пароли чуток разные", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_page_Click(object sender, EventArgs e)
        {

        }

        private void reg_btn_na_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void registr_page_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_na_Click(object sender, EventArgs e)
        {

        }
    }
}
