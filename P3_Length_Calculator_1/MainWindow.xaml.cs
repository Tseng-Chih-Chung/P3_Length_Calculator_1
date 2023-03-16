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

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            double douG;
            douG = Convert.ToDouble(txtG.Text);
            txtMG.Text = string.Format("{0:0.#####}", douG * 1000);
            txtKG.Text = string.Format("{0:0.#####}", douG / 1000);
            txtMT.Text = string.Format("{0:0.#####}", douG / 1000000);
            txtOZ.Text = string.Format("{0:0.#####}", douG / 28.349523125);
            txtLB.Text = string.Format("{0:0.#####}", douG / 453.59237);
        }

        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            double douKG;
            douKG = Convert.ToDouble(txtKG.Text);
            txtMG.Text = string.Format("{0:0.#####}", douKG * 1000000);
            txtG.Text = string.Format("{0:0.#####}", douKG * 1000);
            txtMT.Text = string.Format("{0:0.#####}", douKG / 1000);
            txtOZ.Text = string.Format("{0:0.#####}", douKG / 0.0283495231);
            txtLB.Text = string.Format("{0:0.#####}", douKG / 0.45359237);
        }

        private void txtMT_KeyUp(object sender, KeyEventArgs e)
        {
            double douMT;
            douMT = Convert.ToDouble(txtMT.Text);
            txtMG.Text = string.Format("{0:0.#####}", douMT * 1000000000);
            txtG.Text = string.Format("{0:0.#####}", douMT * 1000000);
            txtKG.Text = string.Format("{0:0.#####}", douMT * 1000);
            txtOZ.Text = string.Format("{0:0.#####}", douMT / 0.0000283495);
            txtLB.Text = string.Format("{0:0.#####}", douMT / 0.0004535924);
        }

        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            double douOZ;
            douOZ = Convert.ToDouble(txtOZ.Text);
            txtMG.Text = string.Format("{0:0.}", douOZ / 0.00003527396195);
            txtG.Text = string.Format("{0:0.}", douOZ / 0.035273962);
            txtKG.Text = string.Format("{0:0.#####}", douOZ / 35.27396195);
            txtMT.Text = string.Format("{0:0.#####}", douOZ / 35273.96195);
            txtLB.Text = string.Format("{0:0.#####}", douOZ / 16);
        }

        private void txtLB_KeyUp(object sender, KeyEventArgs e)
        {
            double douLB;
            douLB = Convert.ToDouble(txtLB.Text);
            txtMG.Text = string.Format("{0:0.#}", douLB / 0.00000220462262185);
            txtG.Text = string.Format("{0:0.}", douLB / 0.0022046226);
            txtKG.Text = string.Format("{0:0.#####}", douLB / 2.2046226218);
            txtMT.Text = string.Format("{0:0.#####}", douLB / 2204.62262185);
            txtOZ.Text = string.Format("{0:0.#####}", douLB * 16);
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            txtMG.Text = "";
            txtG.Text = "";
            txtKG.Text = "";
            txtMT.Text = "";
            txtOZ.Text = "";
            txtLB.Text = "";
        }
    }
}
