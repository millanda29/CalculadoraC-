using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Calculadora1 : Form
    {

        double primero;
        double segundo;
        string operador;

        public Calculadora1()
        {
            InitializeComponent();
        }

        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Multiplicacion obj3 = new Clases.Multiplicacion();
        Clases.Division obj4 = new Clases.Division();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "÷";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            double sum;
            double res;
            double mul;
            double? div; // Cambiado a double? para permitir valores nulos

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar(primero, segundo);
                    Pantalla.Text = $"{primero} + {segundo}\r\n{sum}"; // Mostrar proceso y resultado con salto de línea
                    Pantalla.SelectionStart = 0;
                    Pantalla.SelectionLength = $"{primero} + {segundo}".Length;
                    Pantalla.SelectionFont = new Font(Pantalla.Font.FontFamily, 8); // Establecer tamaño de fuente menor para el proceso matemático
                    Pantalla.SelectionStart = $"{primero} + {segundo}\r\n".Length;
                    Pantalla.SelectionLength = sum.ToString().Length;
                    Pantalla.SelectionFont = new Font(Pantalla.Font.FontFamily, 12); // Establecer tamaño de fuente mayor para el resultado
                    break;
                case "-":
                    res = obj2.Restar(primero, segundo);
                    Pantalla.Text = $"{primero} - {segundo}\n{res}"; // Mostrar proceso y resultado
                    break;
                case "x":
                    mul = obj3.Multiplicar(primero, segundo);
                    Pantalla.Text = $"{primero} x {segundo}\n{mul}"; // Mostrar proceso y resultado
                    break;
                case "÷":
                    div = obj4.Dividir(primero, segundo);
                    if (div.HasValue) // Verifica si la división no es nula
                    {
                        Pantalla.Text = $"{primero} ÷ {segundo}\n{div.Value}"; // Mostrar proceso y resultado
                    }
                    else
                    {
                        Pantalla.Text = obj4.Validacion(segundo); // Muestra el mensaje de error
                    }
                    break;
            }
        }



        private void btnPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "";
            else
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }
    }
}
