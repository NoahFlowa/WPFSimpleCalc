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
using System.Windows.Shapes;

namespace SimpleCalc
{
    /// <summary>
    /// Interaction logic for SolutionForm.xaml
    /// </summary>
    public partial class SolutionForm : Window
    {
        public SolutionInfo _solutionInfo { get; set; }

        public SolutionForm(SolutionInfo solutionInfo)
        {
            InitializeComponent();
            _solutionInfo = solutionInfo;
        }

        private void SolutionForm_Loaded(object sender, RoutedEventArgs e)
        {
            result_lbl.Content = $"{_solutionInfo.Result}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
