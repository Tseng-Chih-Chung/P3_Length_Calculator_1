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

namespace P3_Length_Calculator_1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtMG_KeyUp_1(object sender, KeyEventArgs e)
        {
            double douMG;
            douMG = Convert.ToDouble(txtMG.Text);
            txtG.Text = string.Format("{0:0.#####}", douMG / 1000);
            txtKG.Text = string.Format("{0:0.#####}", douMG / 1000000);
            txtMT.Text = string.Format("{0:0.#####}", douMG / 1000000000);
            txtOZ.Text = string.Format("{0:0.#####}", douMG / 28349.523125);
            txtLB.Text = string.Format("{0:0.#####}", douMG / 453592.37);
        }
    }
}
