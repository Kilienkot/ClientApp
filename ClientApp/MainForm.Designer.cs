namespace ClientApp
{
    partial class MainForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соревнованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сооруженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соревнованияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.организаторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(624, 148);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Добро пожаловать!\nВыбери вкладку";
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.соревнованияToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 146);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(624, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.типыТоваровToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.справочникиToolStripMenuItem.Text = "Спорт";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователиToolStripMenuItem.Text = "Виды спорта";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.товарыToolStripMenuItem.Text = "Спортсмены";
            // 
            // типыТоваровToolStripMenuItem
            // 
            this.типыТоваровToolStripMenuItem.Name = "типыТоваровToolStripMenuItem";
            this.типыТоваровToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.типыТоваровToolStripMenuItem.Text = "Тренеры";
            this.типыТоваровToolStripMenuItem.Click += new System.EventHandler(this.типыТоваровToolStripMenuItem_Click_1);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.сооруженияToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.документыToolStripMenuItem.Text = "Клубы";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.заказыToolStripMenuItem.Text = "Клубы";
            // 
            // соревнованияToolStripMenuItem
            // 
            this.соревнованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организаторыToolStripMenuItem,
            this.соревнованияToolStripMenuItem1});
            this.соревнованияToolStripMenuItem.Name = "соревнованияToolStripMenuItem";
            this.соревнованияToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.соревнованияToolStripMenuItem.Text = "Соревнования";
            // 
            // сооруженияToolStripMenuItem
            // 
            this.сооруженияToolStripMenuItem.Name = "сооруженияToolStripMenuItem";
            this.сооруженияToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.сооруженияToolStripMenuItem.Text = "Сооружения";
            // 
            // соревнованияToolStripMenuItem1
            // 
            this.соревнованияToolStripMenuItem1.Name = "соревнованияToolStripMenuItem1";
            this.соревнованияToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.соревнованияToolStripMenuItem1.Text = "Соревнования";
            // 
            // организаторыToolStripMenuItem
            // 
            this.организаторыToolStripMenuItem.Name = "организаторыToolStripMenuItem";
            this.организаторыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.организаторыToolStripMenuItem.Text = "Организаторы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(624, 170);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соревнованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сооруженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организаторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соревнованияToolStripMenuItem1;
    }
}