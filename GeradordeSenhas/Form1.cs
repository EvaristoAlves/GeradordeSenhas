using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradordeSenhas
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_gerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvxwyz";
            if( check_maiuscula.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
            if (check_numeros.Checked)
                chars += "123456789";
            if (check_simbolos.Checked)
                chars += "#/$!?ç=\"";

            lista_senhas.Items.Clear();
            Random rnd = new Random();

            for( int n = 1; n <= num_senhas; n ++)
            {
                StringBuilder str = new StringBuilder();
                for( int m = 1; m <= count_chars.Value; m++)
                {
                    int pos = rnd.Next(0, chars.Length);
                    str.Append(chars[pos].ToString());
                }

                lista_senhas.Items.Add(str.ToString());
            }
        }
    }
}
