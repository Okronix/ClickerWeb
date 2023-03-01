namespace ClickerWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_start = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_choose_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_scheduler = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picGit = new System.Windows.Forms.PictureBox();
            this.picNAB = new System.Windows.Forms.PictureBox();
            this.picTG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(378, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(117, 81);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(12, 296);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Запуск";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btn_choose_file
            // 
            this.btn_choose_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choose_file.ForeColor = System.Drawing.Color.Black;
            this.btn_choose_file.Location = new System.Drawing.Point(93, 296);
            this.btn_choose_file.Name = "btn_choose_file";
            this.btn_choose_file.Size = new System.Drawing.Size(98, 23);
            this.btn_choose_file.TabIndex = 6;
            this.btn_choose_file.Text = "Указать список";
            this.btn_choose_file.UseVisualStyleBackColor = true;
            this.btn_choose_file.Click += new System.EventHandler(this.btn_choose_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "ClickerWeb - выбор списка";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(155, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Уйдет времени: 0 сек.    Ссылок: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Upload.ee",
            "ZippyShare.com",
            "AnonFiles.com",
            "Другой id"});
            this.comboBox1.Location = new System.Drawing.Point(12, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_scheduler
            // 
            this.btn_scheduler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_scheduler.ForeColor = System.Drawing.Color.Black;
            this.btn_scheduler.Location = new System.Drawing.Point(285, 296);
            this.btn_scheduler.Name = "btn_scheduler";
            this.btn_scheduler.Size = new System.Drawing.Size(87, 23);
            this.btn_scheduler.TabIndex = 15;
            this.btn_scheduler.Text = "Планировщик";
            this.btn_scheduler.UseVisualStyleBackColor = true;
            this.btn_scheduler.Click += new System.EventHandler(this.btn_scheduler_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 20);
            this.textBox2.TabIndex = 16;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(93, 217);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Изменить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(174, 217);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(12, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(255, 217);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(117, 23);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Очистить список";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picGit
            // 
            this.picGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGit.Image = global::ClickerWeb.Properties.Resources.GitHub_Mark_32px;
            this.picGit.Location = new System.Drawing.Point(318, 264);
            this.picGit.Name = "picGit";
            this.picGit.Size = new System.Drawing.Size(29, 26);
            this.picGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGit.TabIndex = 22;
            this.picGit.TabStop = false;
            this.picGit.Click += new System.EventHandler(this.picGit_Click);
            // 
            // picNAB
            // 
            this.picNAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNAB.Image = ((System.Drawing.Image)(resources.GetObject("picNAB.Image")));
            this.picNAB.Location = new System.Drawing.Point(343, 264);
            this.picNAB.Name = "picNAB";
            this.picNAB.Size = new System.Drawing.Size(29, 26);
            this.picNAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNAB.TabIndex = 11;
            this.picNAB.TabStop = false;
            this.picNAB.Click += new System.EventHandler(this.picNAB_Click);
            // 
            // picTG
            // 
            this.picTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTG.Image = global::ClickerWeb.Properties.Resources.tg_ico;
            this.picTG.Location = new System.Drawing.Point(290, 264);
            this.picTG.Name = "picTG";
            this.picTG.Size = new System.Drawing.Size(29, 26);
            this.picTG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTG.TabIndex = 10;
            this.picTG.TabStop = false;
            this.picTG.Click += new System.EventHandler(this.picTG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 327);
            this.Controls.Add(this.picGit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_scheduler);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNAB);
            this.Controls.Add(this.picTG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_choose_file);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickerWeb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_choose_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picTG;
        private System.Windows.Forms.PictureBox picNAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_scheduler;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picGit;
    }
}

