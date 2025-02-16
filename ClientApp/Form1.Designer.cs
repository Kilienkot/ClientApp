namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.autorizacion_panel = new System.Windows.Forms.TabControl();
            this.login_page = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.passwordUser = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.Login_btn_na = new System.Windows.Forms.Button();
            this.registr_page = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.enter_pswrd_txt = new System.Windows.Forms.TextBox();
            this.pswrd_txt = new System.Windows.Forms.TextBox();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.reg_btn_na = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlConnection2 = new MySql.Data.MySqlClient.MySqlConnection();
            this.autorizacion_panel.SuspendLayout();
            this.login_page.SuspendLayout();
            this.registr_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // autorizacion_panel
            // 
            this.autorizacion_panel.Controls.Add(this.login_page);
            this.autorizacion_panel.Controls.Add(this.registr_page);
            this.autorizacion_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorizacion_panel.Location = new System.Drawing.Point(0, 0);
            this.autorizacion_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autorizacion_panel.Name = "autorizacion_panel";
            this.autorizacion_panel.SelectedIndex = 0;
            this.autorizacion_panel.Size = new System.Drawing.Size(374, 579);
            this.autorizacion_panel.TabIndex = 2;
            // 
            // login_page
            // 
            this.login_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.login_page.Controls.Add(this.label2);
            this.login_page.Controls.Add(this.label1);
            this.login_page.Controls.Add(this.Login_button);
            this.login_page.Controls.Add(this.passwordUser);
            this.login_page.Controls.Add(this.loginUser);
            this.login_page.Controls.Add(this.reg_btn);
            this.login_page.Controls.Add(this.Login_btn_na);
            this.login_page.Location = new System.Drawing.Point(4, 22);
            this.login_page.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_page.Name = "login_page";
            this.login_page.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_page.Size = new System.Drawing.Size(366, 553);
            this.login_page.TabIndex = 0;
            this.login_page.Text = "login";
            this.login_page.Click += new System.EventHandler(this.login_page_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_button.FlatAppearance.BorderSize = 3;
            this.Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(37, 406);
            this.Login_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(291, 63);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Авторизоваться";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // passwordUser
            // 
            this.passwordUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.passwordUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordUser.Font = new System.Drawing.Font("Consolas", 25F);
            this.passwordUser.ForeColor = System.Drawing.Color.White;
            this.passwordUser.Location = new System.Drawing.Point(37, 297);
            this.passwordUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordUser.Multiline = true;
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Size = new System.Drawing.Size(292, 55);
            this.passwordUser.TabIndex = 7;
            this.passwordUser.UseSystemPasswordChar = true;
            // 
            // loginUser
            // 
            this.loginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.loginUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUser.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUser.ForeColor = System.Drawing.Color.White;
            this.loginUser.Location = new System.Drawing.Point(37, 181);
            this.loginUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginUser.Multiline = true;
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(292, 55);
            this.loginUser.TabIndex = 6;
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.reg_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.reg_btn.FlatAppearance.BorderSize = 3;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(202, 50);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(125, 46);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Регистрация";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // Login_btn_na
            // 
            this.Login_btn_na.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_btn_na.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_btn_na.FlatAppearance.BorderSize = 3;
            this.Login_btn_na.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_btn_na.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn_na.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_btn_na.ForeColor = System.Drawing.Color.White;
            this.Login_btn_na.Location = new System.Drawing.Point(37, 50);
            this.Login_btn_na.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_btn_na.Name = "Login_btn_na";
            this.Login_btn_na.Size = new System.Drawing.Size(125, 46);
            this.Login_btn_na.TabIndex = 4;
            this.Login_btn_na.Text = "Войти";
            this.Login_btn_na.UseVisualStyleBackColor = false;
            // 
            // registr_page
            // 
            this.registr_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.registr_page.Controls.Add(this.label6);
            this.registr_page.Controls.Add(this.label8);
            this.registr_page.Controls.Add(this.label7);
            this.registr_page.Controls.Add(this.label5);
            this.registr_page.Controls.Add(this.label3);
            this.registr_page.Controls.Add(this.label4);
            this.registr_page.Controls.Add(this.register_btn);
            this.registr_page.Controls.Add(this.mail_txt);
            this.registr_page.Controls.Add(this.enter_pswrd_txt);
            this.registr_page.Controls.Add(this.pswrd_txt);
            this.registr_page.Controls.Add(this.login_txt);
            this.registr_page.Controls.Add(this.surname_txt);
            this.registr_page.Controls.Add(this.name_txt);
            this.registr_page.Controls.Add(this.reg_btn_na);
            this.registr_page.Controls.Add(this.Login_btn);
            this.registr_page.Location = new System.Drawing.Point(4, 22);
            this.registr_page.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registr_page.Name = "registr_page";
            this.registr_page.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registr_page.Size = new System.Drawing.Size(366, 553);
            this.registr_page.TabIndex = 1;
            this.registr_page.Text = "registr";
            this.registr_page.Click += new System.EventHandler(this.registr_page_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(186, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Почта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Повторите пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.register_btn.FlatAppearance.BorderSize = 3;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(40, 466);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(291, 63);
            this.register_btn.TabIndex = 15;
            this.register_btn.Text = "Зарегестрироваться";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // mail_txt
            // 
            this.mail_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.mail_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_txt.Font = new System.Drawing.Font("Consolas", 15F);
            this.mail_txt.ForeColor = System.Drawing.Color.White;
            this.mail_txt.Location = new System.Drawing.Point(190, 220);
            this.mail_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mail_txt.MaxLength = 25;
            this.mail_txt.Multiline = true;
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(142, 55);
            this.mail_txt.TabIndex = 14;
            this.mail_txt.UseSystemPasswordChar = true;
            // 
            // enter_pswrd_txt
            // 
            this.enter_pswrd_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.enter_pswrd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enter_pswrd_txt.Font = new System.Drawing.Font("Consolas", 25F);
            this.enter_pswrd_txt.ForeColor = System.Drawing.Color.White;
            this.enter_pswrd_txt.Location = new System.Drawing.Point(40, 395);
            this.enter_pswrd_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enter_pswrd_txt.MaxLength = 15;
            this.enter_pswrd_txt.Multiline = true;
            this.enter_pswrd_txt.Name = "enter_pswrd_txt";
            this.enter_pswrd_txt.Size = new System.Drawing.Size(292, 55);
            this.enter_pswrd_txt.TabIndex = 14;
            this.enter_pswrd_txt.UseSystemPasswordChar = true;
            // 
            // pswrd_txt
            // 
            this.pswrd_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.pswrd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswrd_txt.Font = new System.Drawing.Font("Consolas", 25F);
            this.pswrd_txt.ForeColor = System.Drawing.Color.White;
            this.pswrd_txt.Location = new System.Drawing.Point(40, 308);
            this.pswrd_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pswrd_txt.MaxLength = 15;
            this.pswrd_txt.Multiline = true;
            this.pswrd_txt.Name = "pswrd_txt";
            this.pswrd_txt.Size = new System.Drawing.Size(292, 55);
            this.pswrd_txt.TabIndex = 14;
            this.pswrd_txt.UseSystemPasswordChar = true;
            // 
            // login_txt
            // 
            this.login_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.login_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_txt.Font = new System.Drawing.Font("Consolas", 20F);
            this.login_txt.ForeColor = System.Drawing.Color.White;
            this.login_txt.Location = new System.Drawing.Point(40, 220);
            this.login_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_txt.MaxLength = 16;
            this.login_txt.Multiline = true;
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(142, 55);
            this.login_txt.TabIndex = 14;
            this.login_txt.UseSystemPasswordChar = true;
            // 
            // surname_txt
            // 
            this.surname_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.surname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname_txt.Font = new System.Drawing.Font("Consolas", 20F);
            this.surname_txt.ForeColor = System.Drawing.Color.White;
            this.surname_txt.Location = new System.Drawing.Point(190, 134);
            this.surname_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surname_txt.MaxLength = 16;
            this.surname_txt.Multiline = true;
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(142, 55);
            this.surname_txt.TabIndex = 14;
            this.surname_txt.UseSystemPasswordChar = true;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_txt.ForeColor = System.Drawing.Color.White;
            this.name_txt.Location = new System.Drawing.Point(40, 134);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_txt.MaxLength = 16;
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(142, 55);
            this.name_txt.TabIndex = 13;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // reg_btn_na
            // 
            this.reg_btn_na.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.reg_btn_na.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.reg_btn_na.FlatAppearance.BorderSize = 3;
            this.reg_btn_na.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.reg_btn_na.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn_na.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn_na.ForeColor = System.Drawing.Color.White;
            this.reg_btn_na.Location = new System.Drawing.Point(202, 50);
            this.reg_btn_na.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reg_btn_na.Name = "reg_btn_na";
            this.reg_btn_na.Size = new System.Drawing.Size(125, 46);
            this.reg_btn_na.TabIndex = 12;
            this.reg_btn_na.Text = "Регистрация";
            this.reg_btn_na.UseVisualStyleBackColor = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_btn.FlatAppearance.BorderSize = 3;
            this.Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(37, 50);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(125, 46);
            this.Login_btn.TabIndex = 11;
            this.Login_btn.Text = "Войти";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(374, 579);
            this.Controls.Add(this.autorizacion_panel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 618);
            this.MinimumSize = new System.Drawing.Size(390, 618);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.autorizacion_panel.ResumeLayout(false);
            this.login_page.ResumeLayout(false);
            this.login_page.PerformLayout();
            this.registr_page.ResumeLayout(false);
            this.registr_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl autorizacion_panel;
        private System.Windows.Forms.TabPage login_page;
        private System.Windows.Forms.TabPage registr_page;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button Login_btn_na;
        private System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox passwordUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button reg_btn_na;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enter_pswrd_txt;
        private System.Windows.Forms.TextBox pswrd_txt;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection2;
    }
}

