namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double capCantidad = Convert.ToDouble(textCantidad.Text);
            double resultado = 0;


            if (comboMoneda.SelectedIndex == -1)
            {
                textResultado.Text = "No has seleccionado nada";
            }
            else
            {
                switch (comboMoneda.SelectedItem.ToString())
                {
                    case "DOGE":
                        resultado = capCantidad / 0.001;
                        textResultado.Text = resultado.ToString();
                        break;
                    case "XRP":
                        resultado = capCantidad / 1.6;
                        textResultado.Text = resultado.ToString();
                        break;
                    case "BITCOIN":
                        resultado = (capCantidad / 10000);
                        textResultado.Text = resultado.ToString();
                        break;
                    case "BAT":
                        resultado = (capCantidad / 1);
                        textResultado.Text = resultado.ToString();
                        break;
                    default:
                        textResultado.Text = "No es ninguno";
                        break;
                }
            }
            
        }
    }
}