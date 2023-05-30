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
using System.Drawing.Printing;

namespace textr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; 
                string fileName = openFileDialog1.FileName; 
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); 
}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
{
                    var name = saveFileDialog1.FileName; //Задаем имя файлу
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); 
}
                 richTextBox.Clear();
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.ForeColor = MyDialog.Color;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                richTextBox.ForeColor = MyDialog.Color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox.Font;
            fontDialog1.Color = richTextBox.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor = fontDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox.Font;
            fontDialog1.Color = richTextBox.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor = fontDialog1.Color;
            }
        }

        private void левыйКрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void центрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void правыйКрайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
