namespace InventarioCuartito
{
    partial class Form1
    {

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscador:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(825, 27);
            button1.Name = "button1";
            button1.Size = new Size(35, 29);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 31);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 3;
            label2.Text = "Agregar Articulos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 75);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 4;
            label3.Text = "Eliminar Articulos";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(825, 71);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(903, 494);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;


    }

}
