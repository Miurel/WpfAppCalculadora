using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppCalculadora.views
{
    /// <summary>
    /// Lógica de interacción para calculadora.xaml
    /// </summary>
    public partial class calculadora : Window
        
    {
        double num1=0;
        double num2=0;
        String Operation;
        
        public calculadora()
        
   
            
        {
            InitializeComponent();
        }

        Clases.Suma op1 = new Clases.Suma();
        Clases.Resta op2 = new Clases.Resta();
        Clases.Multiplicacion op3 = new Clases.Multiplicacion();
        Clases.Division op4 = new Clases.Division();

        private void Buttonigual_Click(object sender, RoutedEventArgs e)
        {
            num2 = Double.Parse(resTextBox.Text);

            double Suma;
            double Resta;
            double Multiplicacion;
            double Division;

            switch (Operation)
            {
                case "+":
                    Suma = op1.Sum((num1), (num2));
                    resTextBox.Text = Suma.ToString();

                    break;
                case "-":
                    Resta = op2.Res((num1), (num2));
                    resTextBox.Text = Resta.ToString();
                    break;
                case "*":
                    Multiplicacion = op3.Multi((num1), (num2));
                    resTextBox.Text = Multiplicacion.ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("SYSTEM ERROR");
                        resTextBox.Clear();
                    }
                    else
                    {
                        Division = op4.Div((num1), (num2));
                        resTextBox.Text = Division.ToString();
                        
                    }
                    break;
                case " ":
                    
                        MessageBox.Show("no se encontro en numero secundario");
                   
                    
                    break;
            }

        }

        private void Buttonmenos_Click(object sender, RoutedEventArgs e)
        {
            Operation = "-";
            num1 = Double.Parse(resTextBox.Text);
            resTextBox.Clear();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "2";
            

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Text = resTextBox.Text + "0";

        }

        private void Buttonmas_Click(object sender, RoutedEventArgs e)
        {
            Operation = "+";
            num1 = Double.Parse(resTextBox.Text);
            resTextBox.Clear();
        }

        private void Buttonmultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            Operation = "*";
            num1 = Double.Parse(resTextBox.Text);
            resTextBox.Clear();
        }

        private void Buttondivision_Click(object sender, RoutedEventArgs e)
        {
            Operation = "/";
            num1 = Double.Parse(resTextBox.Text);
            resTextBox.Clear();
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {

            if (resTextBox.Text.Length == 1)
            {
                resTextBox.Text = "";
            }
            else
            {
                if (resTextBox.Text == "")
                {
                    MessageBox.Show("La pantalla esta vacia");
                }
                else
                {
                    resTextBox.Text = resTextBox.Text.Substring(0, resTextBox.Text.Length - 1);
                }
                
                
            }
                



        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            resTextBox.Clear();

        }

        private void Buttonpunto_Click(object sender, RoutedEventArgs e)
        {
            String Buttonpunto;
            Buttonpunto = resTextBox.Text;

            if (Buttonpunto.Length <= 0)
            {
                resTextBox.Text= "0.";

            }
            else
            {
                if (!existepunto(resTextBox.Text))
                {
                    resTextBox.Text =(resTextBox.Text + ".");

                }
            }
        }
        public static bool existepunto(String Buttonpunto)
        {
            bool res;
            res = false;

            for (int i = 0; i < Buttonpunto.Length; i++)
            {
                if (Buttonpunto.Substring(i, + 1).Equals("."))
                {
                    res = true;
                    break;
                }

            }
            return res;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NO SE ENCUENTRA DISPONIBLE...");
        }
    }
}
