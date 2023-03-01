using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerWeb
{
    public partial class Form1 : Form
    {
        string butid = "d_l";
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Application.StartupPath.ToString();
            comboBox1.SelectedIndex = 0;
        }

        void status_upd()
        {
            int i = listBox1.Items.Count;
            label1.Text = $@"Уйдет времени: {(i * 4.2).ToString()} сек.    Ссылок: {i.ToString()}";
            if (i > 0)
            {
                if (listBox1.Items[0].ToString().Contains("upload.ee"))
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (listBox1.Items[0].ToString().Contains("zippyshare.com"))
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (listBox1.Items[0].ToString().Contains("anonfiles.com"))
                {
                    comboBox1.SelectedIndex = 2;
                }
                else
                {
                    comboBox1.SelectedIndex = 3;
                }
            }
        }

        async private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                status_upd();
                webBrowser1.ScriptErrorsSuppressed = true;
                if (comboBox1.Text == "Другой id")
                    butid = textBox1.Text;
                try
                {
                    
                    for (int i = listBox1.Items.Count-1; i >= 0; i--)
                    {
                        webBrowser1.Navigate((listBox1.Items[i]).ToString());
                        await Task.Delay(2000);
                        webBrowser1.Document.GetElementById(butid).InvokeMember("Click");
                        await Task.Delay(2000);
                        System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /IM iexplore.exe");
                    }
                    MessageBox.Show("Работа завершена!");
                }
                catch{MessageBox.Show("Указаны неверные ссылки или id кнопки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            catch{MessageBox.Show("Указан неверный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);}


        }

        private void btn_choose_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    listBox1.Items.Clear();
                    string[] lines = File.ReadAllLines(fileName);
                    listBox1.Items.AddRange(lines);
                    status_upd();
                }
                catch { }
            }
        }

        private void picGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Okronix/");
        }

        private void picTG_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/devFRAME/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Другой id")
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
            }

            if (comboBox1.Text == "Upload.ee")
            {
                butid = "d_l";
            }
            else if (comboBox1.Text == "ZippyShare.com")
            {
                butid = "dlbutton";
            }
            else { }
        }

        private void btn_scheduler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро :)", "ClickerWeb");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int indexList = 0;
            if (listBox1.SelectedIndex != -1)
            {
                indexList = listBox1.SelectedIndex;
                if ((textBox2.Text.Contains("http://")) || textBox2.Text.Contains("https://"))
                {
                    listBox1.Items.RemoveAt(indexList);
                    listBox1.Items.Insert(indexList, textBox2.Text);
                }
                else{MessageBox.Show("Введите ссылку в поле");}
            }
            else{MessageBox.Show("Для начала выберите строку");}

            status_upd();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int indexList;
            if (listBox1.SelectedIndex != -1)
            {
                indexList = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(indexList);
                if (listBox1.Items.Count != 0)
                {
                    listBox1.SelectedIndex = indexList - 1;
                }
            }
            else{MessageBox.Show("Для начала выберите строку");}

            status_upd();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text.Contains("http://")) || textBox2.Text.Contains("https://"))
            {
                listBox1.Items.Add(textBox2.Text);
            }
            else
            {MessageBox.Show("Введите ссылку в поле");}

            status_upd();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            status_upd();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.Active = true;

            t.SetToolTip(picTG, "Перейти в телеграм канал автора");
            t.SetToolTip(picGit, "Перейти на GitHub автора");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
