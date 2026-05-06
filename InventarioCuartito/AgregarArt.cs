using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioCuartito
{
    public partial class AgregarArt : Form
    {
        public AgregarArt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int cantidad = (int)numericUpDown1.Value;

            if (!string.IsNullOrEmpty(nombre))
            {
                string articulo = $"{nombre} - Cantidad: {cantidad}";
                listBox1.Items.Add(articulo);

                textBox1.Clear();
                numericUpDown1.Value = 0;
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
