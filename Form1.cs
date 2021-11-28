using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBuyList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                if (textBox1.Text.Length > 0)
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    ProcesBarActualise();
                }
                else
                {
                    MessageBox.Show("Wartość jest pusta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista jest pełna!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesBarActualise()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                ProcesBarActualise();
            }
            else
            {
                MessageBox.Show("Żaden element nie został zaznaczony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
