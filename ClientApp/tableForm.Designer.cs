namespace ClientApp
{
    partial class tableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.sorting_txt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.sortingBtn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.re_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(763, 236);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(167, 22);
            this.Search_txt.TabIndex = 13;
            // 
            // sorting_txt
            // 
            this.sorting_txt.Location = new System.Drawing.Point(763, 330);
            this.sorting_txt.Name = "sorting_txt";
            this.sorting_txt.Size = new System.Drawing.Size(167, 22);
            this.sorting_txt.TabIndex = 14;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.SearchBtn.FlatAppearance.BorderSize = 3;
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(763, 264);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(167, 41);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // sortingBtn
            // 
            this.sortingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.sortingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.sortingBtn.FlatAppearance.BorderSize = 3;
            this.sortingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.sortingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortingBtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortingBtn.ForeColor = System.Drawing.Color.White;
            this.sortingBtn.Location = new System.Drawing.Point(763, 358);
            this.sortingBtn.Name = "sortingBtn";
            this.sortingBtn.Size = new System.Drawing.Size(167, 41);
            this.sortingBtn.TabIndex = 10;
            this.sortingBtn.Text = "Сортировка";
            this.sortingBtn.UseVisualStyleBackColor = false;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Back_btn.FlatAppearance.BorderSize = 3;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(692, 1);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(307, 56);
            this.Back_btn.TabIndex = 11;
            this.Back_btn.Text = "вернуться";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.addBtn.FlatAppearance.BorderSize = 3;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(763, 95);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 56);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 442);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // re_btn
            // 
            this.re_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.re_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.re_btn.FlatAppearance.BorderSize = 3;
            this.re_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(61)))), ((int)(((byte)(103)))));
            this.re_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.re_btn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.re_btn.ForeColor = System.Drawing.Color.White;
            this.re_btn.Location = new System.Drawing.Point(763, 157);
            this.re_btn.Name = "re_btn";
            this.re_btn.Size = new System.Drawing.Size(167, 56);
            this.re_btn.TabIndex = 12;
            this.re_btn.Text = "Обновить";
            this.re_btn.UseVisualStyleBackColor = false;
            this.re_btn.Click += new System.EventHandler(this.re_btn_Click);
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(996, 442);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.sorting_txt);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.sortingBtn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.re_btn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1014, 489);
            this.MinimumSize = new System.Drawing.Size(1014, 489);
            this.Name = "tableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tableForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tableForm_FormClosing);
            this.Load += new System.EventHandler(this.tableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.TextBox sorting_txt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button sortingBtn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button re_btn;
    }
}