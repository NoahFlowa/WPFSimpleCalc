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

namespace SimpleCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            value1_tb.Text = "";
            value2_tb.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double value1;
            double value2;
            double result, theResult = 0;

            if (value1_tb.Text == null)
            {
                MessageBox.Show("Failed to read Value 1's value.\n This application will now close.");
                this.Close();
            }

            if (value2_tb.Text == null)
            {
                MessageBox.Show("Failed to read Value 2's value.\n This application will now close.");
                this.Close();
            }

            Double.TryParse(value1_tb.Text, out value1);
            Double.TryParse(value2_tb.Text, out value2);

            if (add_radio.IsChecked == true)
            {
                result = value1 + value2;
                theResult = result;
                //MessageBox.Show("Answer: " + result.ToString());
                //resultInfo.theResult = result;
            }
            else if (sub_radio.IsChecked == true)
            {
                result = value1 - value2;
                theResult = result;
                //MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }
            else if (mult_radio.IsChecked == true)
            {
                result = value1 * value2;
                theResult = result;
                //MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }
            else if (divide_radio.IsChecked == true)
            {
                result = value1 / value2;
                theResult = result;
                //MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }

            SolutionForm solutionForm = new SolutionForm(new SolutionInfo(theResult));
            solutionForm.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
