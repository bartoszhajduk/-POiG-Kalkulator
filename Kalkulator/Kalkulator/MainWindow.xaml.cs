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



namespace Kalkulator
{

    public partial class MainWindow : Window
    {
        
        double result = 0;
        String operation = "";
        Boolean calculating = false;
        const string errorString = "Nieprawidłowe dane";
        double last = 0;

        public MainWindow()
        {
            InitializeComponent();

        }


        private void click(object sender, RoutedEventArgs e)
        {
       
            if (txt.Text == "0" || calculating || txt.Text == errorString)
            {
                txt.Clear();
            }
            calculating = false;
            Button button = (Button)sender;
           

            if (button.Content.ToString() == ",")
            {
                if (txt.Text == "")
                {
                    txt.Text = "0" + button.Content;
                }
                if (!txt.Text.Contains(","))
                {
                    txt.Text = txt.Text + button.Content;
      
                }
            }

            else
            {
                last = Double.Parse(txt.Text +button.Content);
                txt.Text = txt.Text + button.Content;

            }
        }

        private void operator_Click(object sender, EventArgs e)
        {

            
            Button button = (Button)sender;
            
            if (button.Content.ToString() == "+/-")
            {
                txt.Text = (-Double.Parse(txt.Text)).ToString();
                last = (-last);
                calculating = false;
            }
            else if (button.Content.ToString() == "cofnij")
            {
                if (txt.Text == errorString)
                {
                    txt.Text = "0";
                }
                txt.Text = txt.Text.Remove(txt.Text.Length - 1, 1);
                if (txt.Text.Length == 0 || txt.Text == "-" )
                {
                    txt.Text = "0";
                }
                
                calculating = true;
            }

            
            
            if (calculating == false)
            {

                button_result_Click(this, null);
              

            }
            


       

            if (txt.Text == errorString)
            {
                txt.Text = "0";
                operation = "";
            }

            operation = button.Content.ToString();
            
            result = Double.Parse(txt.Text);

            calculating = true;

            
        }

        private void button_clear_entry_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "0";
            last = 0;
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "0";
            result = 0;
            last = 0;
        }

        private void button_result_Click(object sender, RoutedEventArgs e)
        {
            
            if (txt.Text == errorString)
            {
                txt.Text = "0";
                operation = "";
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        txt.Text = (result + last).ToString();
                        break;
                    case "-":
                        txt.Text = (result - last).ToString();
                        break;
                    case "/":
                        if (last == 0)
                        {
                            result = 0;
                            txt.Text = errorString;
                            return;
                        }
                        else
                        {
                            txt.Text = (result / last).ToString();
                        }
                        break;
                    case "*":
                        txt.Text = (result * last).ToString();
                        break;
                    default:
                        
                        break;

                }
                
                result = Double.Parse(txt.Text);
                operation = "";



            }
        }


        private void klawiaturaClick(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.OemPlus && !(Keyboard.IsKeyDown(Key.RightShift) || Keyboard.IsKeyDown(Key.LeftShift)))
            {

                button_result_Click(button_result, null);

            }

            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                click(button_1, null);
                
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                click(button_2, null);
                
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                click(button_3, null);
                
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                click(button_4, null);
                
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                click(button_5, null);
                
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                click(button_6, null);
                
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                click(button_7, null);
                
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                click(button_8, null);
                
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                click(button_9, null);
                
            }
            else if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                click(button_0, null);
                
            }

            else if (e.Key == Key.OemPlus || e.Key == Key.Add)
            {
                operator_Click(button_add, null);
                
            }

            else if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                operator_Click(button_minus, null);
                
            }

            else if (e.Key == Key.Back)
            {
                operator_Click(button_back, null);
                
            }

            else if (e.Key == Key.Multiply)
            {
                operator_Click(button_multiply, null);
                
            }

            else if (e.Key == Key.Divide || e.Key == Key.OemQuestion)
            {
                operator_Click(button_divide, null);
                
            }

            else if (e.Key == Key.Delete)
            {
                button_clear_entry_Click(button_clear_entry, null);
                
            }

            else if (e.Key == Key.OemComma || e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                click(button_comma, null);
                
            }
            else
            { 
                return;

            }
            e.Handled = true;

        }

      
    }
}
