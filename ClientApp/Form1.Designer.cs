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
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlConnection2 = new MySql.Data.MySqlClient.MySqlConnection();
            this.login_page = new System.Windows.Forms.TabPage();
            this.Login_btn_na = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.passwordUser = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autorizacion_panel = new System.Windows.Forms.TabControl();
            this.login_page.SuspendLayout();
            this.autorizacion_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_page
            // 
            this.login_page.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.login_page.Controls.Add(this.label2);
            this.login_page.Controls.Add(this.label1);
            this.login_page.Controls.Add(this.Login_button);
            this.login_page.Controls.Add(this.passwordUser);
            this.login_page.Controls.Add(this.loginUser);
            this.login_page.Controls.Add(this.reg_btn);
            this.login_page.Controls.Add(this.Login_btn_na);
            this.login_page.Location = new System.Drawing.Point(4, 25);
            this.login_page.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_page.Name = "login_page";
            this.login_page.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_page.Size = new System.Drawing.Size(491, 684);
            this.login_page.TabIndex = 0;
            this.login_page.Text = "login";
            this.login_page.Click += new System.EventHandler(this.login_page_Click);
            // 
            // Login_btn_na
            // 
            this.Login_btn_na.BackColor = System.Drawing.Color.RoyalBlue;
            this.Login_btn_na.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Login_btn_na.FlatAppearance.BorderSize = 3;
            this.Login_btn_na.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.Login_btn_na.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn_na.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_btn_na.ForeColor = System.Drawing.Color.White;
            this.Login_btn_na.Location = new System.Drawing.Point(49, 62);
            this.Login_btn_na.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_btn_na.Name = "Login_btn_na";
            this.Login_btn_na.Size = new System.Drawing.Size(167, 57);
            this.Login_btn_na.TabIndex = 4;
            this.Login_btn_na.Text = "Войти";
            this.Login_btn_na.UseVisualStyleBackColor = false;
            this.Login_btn_na.Click += new System.EventHandler(this.Login_btn_na_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reg_btn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.reg_btn.FlatAppearance.BorderSize = 3;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(269, 62);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(167, 57);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Регистрация";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // loginUser
            // 
            this.loginUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loginUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUser.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUser.ForeColor = System.Drawing.Color.White;
            this.loginUser.Location = new System.Drawing.Point(49, 223);
            this.loginUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginUser.Multiline = true;
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(389, 67);
            this.loginUser.TabIndex = 6;
            // 
            // passwordUser
            // 
            this.passwordUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.passwordUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordUser.Font = new System.Drawing.Font("Consolas", 25F);
            this.passwordUser.ForeColor = System.Drawing.Color.White;
            this.passwordUser.Location = new System.Drawing.Point(49, 366);
            this.passwordUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordUser.Multiline = true;
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Size = new System.Drawing.Size(389, 67);
            this.passwordUser.TabIndex = 7;
            this.passwordUser.UseSystemPasswordChar = true;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Login_button.FlatAppearance.BorderSize = 3;
            this.Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(49, 500);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(388, 78);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Авторизоваться";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // autorizacion_panel
            // 
            this.autorizacion_panel.Controls.Add(this.login_page);
            this.autorizacion_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorizacion_panel.Location = new System.Drawing.Point(0, 0);
            this.autorizacion_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizacion_panel.Name = "autorizacion_panel";
            this.autorizacion_panel.SelectedIndex = 0;
            this.autorizacion_panel.Size = new System.Drawing.Size(499, 713);
            this.autorizacion_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(499, 713);
            this.Controls.Add(this.autorizacion_panel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 752);
            this.MinimumSize = new System.Drawing.Size(515, 752);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.login_page.ResumeLayout(false);
            this.login_page.PerformLayout();
            this.autorizacion_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection2;
        private System.Windows.Forms.TabPage login_page;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox passwordUser;
        private System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Button Login_btn_na;
        private System.Windows.Forms.TabControl autorizacion_panel;
    }
}

