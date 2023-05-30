using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.label5.Text = "Текстовый редактор";
            this.label6.Text = "Версия {0}";
            this.label7.Text = "Вукало А.В."; // AssemblyCopyright;
            this.label8.Text = "КМПО";
            this.textBox1.Text = ""; //AssemblyDescription;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
