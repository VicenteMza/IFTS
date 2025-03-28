using System;
using System.Windows.Forms;

namespace ComparadorNumeros
{
    public partial class Form1 : Form
    {
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Button btnAccept;
        private Button btnCalculate;
        private Label label1;
        private Label label2;

        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Comparador de números";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en pantalla

            // Configura las propiedades de los controles
            label1.Text = "DATO 1";
            label1.Location = new Point(20, 30);
            label1.AutoSize = true;

            label2.Text = "DATO 2";
            label2.Location = new Point(20, 70);
            label2.AutoSize = true;

            txtBox1.Location = new Point(100, 30);
            txtBox1.Width = 200;

            txtBox2.Location = new Point(100, 70);
            txtBox2.Width = 200;

            btnAccept.Text = "ACEPTAR";
            btnAccept.Location = new Point(100, 110);
            btnAccept.Width = 200;
            btnAccept.Height = 50;
            btnAccept.Font = new Font(btnAccept.Font.FontFamily, 7f);

            btnCalculate.Text = "CALCULO";
            btnCalculate.Location = new Point(100, 150);
            btnCalculate.Width = 200;
            btnCalculate.Height = 50;
            btnCalculate.Font = new Font(btnCalculate.Font.FontFamily, 7f); // Etiquetas


            // Cajas de texto
            txtBox1 = new TextBox
            {
                Location = new Point(100, 30),
                Width = 200
            };

            txtBox2 = new TextBox
            {
                Location = new Point(100, 70),
                Width = 200
            };

            // Botones
            btnAccept = new Button
            {
                Text = "ACEPTAR",
                Location = new Point(100, 110),
                Width = 200,
                Font = new Font(btnAccept.Font.FontFamily, 7f)

            };

            btnCalculate = new Button
            {
                Text = "CALCULO",
                Location = new Point(100, 150),
                Width = 200,
                Font = new Font(btnCalculate.Font.FontFamily, 7f)

            };

            // Agregar controles al formulario
            this.Controls.AddRange(new Control[]
            {
                label1, label2,
                txtBox1, txtBox2,
                btnAccept, btnCalculate
            });

            // Ajustar tamaño del formulario
            AjustarTamanioFormulario();

            // Asignar eventos
            btnAccept.Click += BtnAceptar_Click;
            btnCalculate.Click += BtnCalcular_Click;
        }

        private void AjustarTamanioFormulario()
        {
            int margen = 30;
            int ancho = txtBox1.Right + margen;
            int alto = btnCalculate.Bottom + margen;

            this.ClientSize = new Size(ancho, alto);
        }

        private void BtnAceptar_Click(object? sender, EventArgs e)
        {
            //Mostrar datos ingresados en un cuadro de diálogo
            if (string.IsNullOrWhiteSpace(txtBox1.Text) || string.IsNullOrWhiteSpace(txtBox2.Text))
            {
                MessageBox.Show("Por favor, ingrese datos en ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Datos ingresados:\nDato 1: {txtBox1.Text}\nDato 2: {txtBox2.Text}", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCalcular_Click(object? sender, EventArgs e)
        {
            // Solicitar dos números y mostrar el mayor
            string numero1Str = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer número", "Número 1");
            string numero2Str = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo número", "Número 2");

            // Validar que se ingresaron números
            if (!double.TryParse(numero1Str, out double numero1) ||
                !double.TryParse(numero2Str, out double numero2))
            {
                MessageBox.Show("Debe ingresar valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determinar el número mayor
            string mensaje = numero1 > numero2 ? $"El número mayor es: {numero1}" : (numero2 > numero1 ? $"El número mayor es: {numero2}" : "Los números son iguales");

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}