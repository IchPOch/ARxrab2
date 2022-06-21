using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reflection;
namespace ARxrab2
{
    
    public partial class Form1 : Form
    {
        public string fileContent = string.Empty;
        public string filePath = string.Empty;
        public string Folder = string.Empty;
        public Form1()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {

                double free = drive.AvailableFreeSpace;
                double a = (free / 1024) / 1024 / 1024;
                double all = drive.TotalSize;
                double b = (all / 1024) / 1024 / 1024;
                MessageBox.Show(" Svobod : " + Convert.ToString(a) + " Vsego: " + Convert.ToString(b));
            }
        }
        void perebor_updates(string begin_dir, string end_dir)
        {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            //Перебираем все внутренние папки
            foreach (DirectoryInfo dir in dir_inf.GetDirectories())
            {
                //Проверяем - если директории не существует, то создаём;
                if (Directory.Exists(end_dir + "\\" + dir.Name) != true)
                {
                    Directory.CreateDirectory(end_dir + "\\" + dir.Name);
                }

                //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                perebor_updates(dir.FullName, end_dir + "\\" + dir.Name);
            }

            //Перебираем файлики в папке источнике.
            foreach (string file in Directory.GetFiles(begin_dir))
            {
                //Определяем (отделяем) имя файла с расширением - без пути (но с слешем "\").
                string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                //Копируем файлик с перезаписью из источника в приёмник.
                File.Copy(file, end_dir + "\\" + filik, true);
            }
        }
        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            bool blnProcess = false;
            if (keyData == Keys.F1)
            {
                blnProcess = true;
                ///Обработчик события///
                MessageBox.Show("Zachem nazhal na etu knopku");
            }
            if (blnProcess == true)
                return true;
            else
                return base.ProcessCmdKey(ref m, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.SelectedPath;
                }
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                string s2 = new DirectoryInfo(textBox1.Text).Name;
                perebor_updates(textBox1.Text, textBox2.Text + "\\" + s2);
            }
            else
            {
                try
                {
                    File.Copy(textBox1.Text, textBox2.Text + "\\" + Path.GetFileName(textBox1.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                string s2 = new DirectoryInfo(textBox1.Text).Name;
                perebor_updates(textBox1.Text, textBox2.Text + "\\" + s2);
                Directory.Delete(textBox1.Text, true);
            }
            else
            {
                try
                {
                    File.Move(textBox1.Text, textBox2.Text + "\\" + Path.GetFileName(textBox1.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Hide();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                Directory.Delete(textBox1.Text, true);
            }
            else
            {
                try
                {
                    File.Delete(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Properties_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(textBox1.Text);
                label1.Text = ($"Имя файла: {fileInfo.Name}");
                label2.Text = ($"Время создания: {fileInfo.CreationTime}");
                label3.Text = ($"Размер: {fileInfo.Length} (бит)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Ren_Click(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                try
                {
                    Directory.Move(textBox1.Text, Path.GetDirectoryName(textBox1.Text) + "\\" + RenameTxt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    File.Move(textBox1.Text, Path.GetDirectoryName(textBox1.Text) + "\\" + RenameTxt.Text + Path.GetExtension(textBox1.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void folderCh_CheckedChanged(object sender, EventArgs e)
        {
            if (folderCh.Checked == true)
            {
                button1.Text = "Papka";
            }
            else
            {
                button1.Text = "File";
            }
        }

        private void Threads_Click(object sender, EventArgs e)
        {
            if (ThreadCombo.Text == "Highest")
            {
                Thread myThread1 = new Thread(() => button3_Click(sender, e));
                myThread1.Priority = ThreadPriority.Highest;
                myThread1.Start();
            }
            if (ThreadCombo.Text == "Above normal")
            {
                Thread myThread1 = new Thread(() => button3_Click(sender, e));
                myThread1.Priority = ThreadPriority.AboveNormal;
                myThread1.Start();
            }
            if (ThreadCombo.Text == "Normal")
            {
                Thread myThread1 = new Thread(() => button3_Click(sender, e));
                myThread1.Priority = ThreadPriority.Normal;
                myThread1.Start();
            }
            if (ThreadCombo.Text == "Below normal")
            {
                Thread myThread1 = new Thread(() => button3_Click(sender, e));
                myThread1.Priority = ThreadPriority.BelowNormal;
                myThread1.Start();
            }
            if (ThreadCombo.Text == "Lowest")
            {
                Thread myThread1 = new Thread(() => button3_Click(sender, e));
                myThread1.Priority = ThreadPriority.Lowest;
                myThread1.Start();
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (dllCheck.Checked == true)
            {
                Assembly assem = Assembly.Load("Task");
                var type = assem.GetType("Task.Class1");
                Object obj = assem.CreateInstance("Task.Class1");
                var mi = type.GetMethod("Func");
                Object[] numbers = new Object[2];
                numbers[0] = Convert.ToInt32(arg1.Text);
                numbers[1] = Convert.ToInt32(arg2.Text);
                answer.Text = (mi.Invoke(obj, numbers).ToString());
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Close.Checked == true)
            {
                MessageBox.Show("ахах)");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
