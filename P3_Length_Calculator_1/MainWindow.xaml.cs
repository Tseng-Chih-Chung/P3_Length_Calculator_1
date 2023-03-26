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

        double douOutput; // double浮點數型態的douOutput變數
        private void txtMG_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtMG.Text, out douOutput) == true)
            { 
                txtG.Text = string.Format("{0:0.#####}", douOutput / 1000);
                txtKG.Text = string.Format("{0:0.#####}", douOutput / 1000000);
                txtMT.Text = string.Format("{0:0.#####}", douOutput / 1000000000);
                txtOZ.Text = string.Format("{0:0.#####}", douOutput / 28349.523125);
                txtLB.Text = string.Format("{0:0.#####}", douOutput / 453592.37);
                txtInfo.Text ="運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
        }

        private void txtG_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtG.Text, out douOutput) == true)
            {
                txtMG.Text = string.Format("{0:0.#####}", douOutput * 1000);
                txtKG.Text = string.Format("{0:0.#####}", douOutput / 1000);
                txtMT.Text = string.Format("{0:0.#####}", douOutput / 1000000);
                txtOZ.Text = string.Format("{0:0.#####}", douOutput / 28.349523125);
                txtLB.Text = string.Format("{0:0.#####}", douOutput / 453.59237);
                txtInfo.Text = "運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
        }

        private void txtKG_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtKG.Text, out douOutput) == true)
            {
                txtMG.Text = string.Format("{0:0.#####}", douOutput * 1000000);
                txtG.Text = string.Format("{0:0.#####}", douOutput * 1000);
                txtMT.Text = string.Format("{0:0.#####}", douOutput / 1000);
                txtOZ.Text = string.Format("{0:0.#####}", douOutput / 0.0283495231);
                txtLB.Text = string.Format("{0:0.#####}", douOutput / 0.45359237);
                txtInfo.Text = "運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
        }

        private void txtMT_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtMT.Text, out douOutput) == true)
            {
                txtMG.Text = string.Format("{0:0.#####}", douOutput * 1000000000);
                txtG.Text = string.Format("{0:0.#####}", douOutput * 1000000);
                txtKG.Text = string.Format("{0:0.#####}", douOutput * 1000);
                txtOZ.Text = string.Format("{0:0.#####}", douOutput / 0.0000283495);
                txtLB.Text = string.Format("{0:0.#####}", douOutput / 0.0004535924);
                txtInfo.Text = "運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
        }

        private void txtOZ_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtOZ.Text, out douOutput) == true)
            {
                txtMG.Text = string.Format("{0:0.}", douOutput / 0.00003527396195);
                txtG.Text = string.Format("{0:0.}", douOutput / 0.035273962);
                txtKG.Text = string.Format("{0:0.#####}", douOutput / 35.27396195);
                txtMT.Text = string.Format("{0:0.#####}", douOutput / 35273.96195);
                txtLB.Text = string.Format("{0:0.#####}", douOutput / 16);
                txtInfo.Text = "運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
        }

        private void txtLB_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtLB.Text, out douOutput) == true)
            {
                txtMG.Text = string.Format("{0:0.#}", douOutput / 0.00000220462262185);
                txtG.Text = string.Format("{0:0.}", douOutput / 0.0022046226);
                txtKG.Text = string.Format("{0:0.#####}", douOutput / 2.2046226218);
                txtMT.Text = string.Format("{0:0.#####}", douOutput / 2204.62262185);
                txtOZ.Text = string.Format("{0:0.#####}", douOutput * 16);
                txtInfo.Text = "運算成功 計算結果有誤差 切勿全盤相信";
            }
            else
            {
                txtInfo.Text = "錯誤 只能輸入數字";
                txtMG.Text = "";
                txtG.Text = "";
                txtKG.Text = "";
                txtMT.Text = "";
                txtOZ.Text = "";
                txtLB.Text = "";
            }
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
