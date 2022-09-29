using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string operaciones = "+-/*";
            if (operaciones.ToString().Contains(operador_TextBox.Text) && operador_TextBox.Text != "")
            {
                calcular_Button.IsEnabled = true;
            }
            else
            {
                calcular_Button.IsEnabled = false;
            }
        }

        private void calcular_Button_Click(object sender, RoutedEventArgs e)
        {
            float op1, op2;
            float resultado = 0;
            if (float.TryParse(operando1_TextBox.Text, out op1) && float.TryParse(operando2_TextBox.Text, out op2))
            {
                switch (operador_TextBox.Text)
                {
                    case "+":
                        resultado = op1 + op2;
                        break;
                    case "-":
                        resultado = op1 - op2;
                        break;
                    case "/":
                        resultado = op1 / op2;
                        break;
                    case "*":
                        resultado = op1 * op2;
                        break;
                }
                resultado_TextBox.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }
        }

        private void limpiar_Button_Click(object sender, RoutedEventArgs e)
        {
            operador_TextBox.Clear();
            operando1_TextBox.Clear();
            operando2_TextBox.Clear();
            resultado_TextBox.Clear();
        }
    }
}
