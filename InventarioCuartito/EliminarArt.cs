using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventarioCuartito
{
    public partial class EliminarArt : Form
    {
        public EliminarArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int cantidadEliminar = (int)numericUpDown1.Value;

            if (!string.IsNullOrEmpty(nombre) && cantidadEliminar > 0)
            {
                bool encontrado = false;

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string item = listBox1.Items[i].ToString();

                    string[] partes = item.Split('-');

                    string nombreArticulo = partes[0].Trim();
                    int cantidadActual = int.Parse(partes[1].Replace("Cantidad:", "").Trim());

                    if (nombreArticulo == nombre)
                    {
                        encontrado = true;

                        DialogResult resultado = MessageBox.Show(
                            $"¿Eliminar {cantidadEliminar} de {nombre}?",
                            "Confirmación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.Yes)
                        {
                            int nuevaCantidad = cantidadActual - cantidadEliminar;

                            // Si queda 0 o menos, lo eliminamos
                            if (nuevaCantidad <= 0)
                            {
                                listBox1.Items.RemoveAt(i);
                            }
                            else
                            {
                                listBox1.Items[i] = $"{nombre} - Cantidad: {nuevaCantidad}";
                            }

                            MessageBox.Show("Actualizado correctamente");
                        }

                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("El artículo no existe");
                }
            }
            else
            {
                MessageBox.Show("Ingresa nombre y cantidad");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarArt_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Laptop - Cantidad: 5");
            listBox1.Items.Add("Mouse - Cantidad: 10");
            listBox1.Items.Add("Teclado - Cantidad: 3");
            listBox1.Items.Add("Monitor - Cantidad: 2");
            listBox1.Items.Add("USB - Cantidad: 15");
        }
    }
}
