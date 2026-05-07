using System;
using System.Windows.Forms;

namespace InventarioCuartito
{

    public partial class Form1 : Form
    {
        List<string> articulos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            string texto = textBox1.Text.Trim().ToLower();
            string marca = comboBox2.Text.Trim().ToLower();
            string tipo = comboBox1.Text.Trim().ToLower();

            listBox1.Items.Clear();

            // 👇 si no hay nada escrito ni seleccionado, no mostrar nada
            if (string.IsNullOrEmpty(texto) &&
                string.IsNullOrEmpty(marca) &&
                string.IsNullOrEmpty(tipo))
            {
                return;
            }

            foreach (string item in articulos)
            {

                string itemLower = item.ToLower();

                // ✔ filtro por texto (buscador principal)
                bool coincideTexto =
                    string.IsNullOrEmpty(texto) ||
                    itemLower.Contains(texto);

                // ✔ filtro por marca
                bool coincideMarca =
                    string.IsNullOrEmpty(marca) ||
                    marca == "todos" ||
                    itemLower.Contains(marca);

                // ✔ filtro por tipo
                bool coincideTipo =
                    string.IsNullOrEmpty(tipo) ||
                    tipo == "todos" ||
                    itemLower.Contains(tipo);

                // ✔ si cumple todo lo activo, se muestra
                if (coincideTexto && coincideMarca && coincideTipo)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarArt form = new AgregarArt();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarArt form = new EliminarArt();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            articulos.Add("Laptop HP - Marca: HP - Tipo: Computadora");
            articulos.Add("Laptop Dell - Marca: Dell - Tipo: Computadora");
            articulos.Add("Mouse Logitech - Marca: Logitech - Tipo: Accesorio");
            articulos.Add("Teclado HP - Marca: HP - Tipo: Accesorio");
            articulos.Add("Monitor Samsung - Marca: Samsung - Tipo: Pantalla");

            comboBox2.Items.Clear();
            comboBox1.Items.Clear();

            comboBox2.Items.Add("Todos");
            comboBox2.Items.Add("HP");
            comboBox2.Items.Add("Dell");
            comboBox2.Items.Add("Logitech");

            // TIPO
            comboBox1.Items.Add("Todos");
            comboBox1.Items.Add("Computadora");
            comboBox1.Items.Add("Accesorio");

            // 👇 IMPORTANTE: seleccionar "Todos" correctamente
            comboBox2.SelectedItem = "Todos";
            comboBox1.SelectedItem = "Todos";

            Filtrar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }


}