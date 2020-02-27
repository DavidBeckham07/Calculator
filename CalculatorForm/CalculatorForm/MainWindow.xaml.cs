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

namespace CalculatorForm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double para1;
            double para2;
            if (Double.TryParse(Para1.Text, out para1) && Double.TryParse(Para2.Text, out para2))
            {
                Result.Text = Calculate(para1, para2);

            }
            else
            {
                Result.Text = "输入错误！请重新输入";
            }

            
            
            
        }


        private String Calculate(double para1, double para2)
        {
            String result = "";

            switch (Sigh.SelectedIndex)
            {
                case -1:
                    result = "请选择运算符号！";
                    break;

                case 0:
                    result = (para1 + para2).ToString();
                    break;
                case 1:
                    result = (para1 - para2).ToString();
                    break;
                case 2:
                    result = (para1 * para2).ToString();
                    break;
                case 3:
                    if(para2 == 0)
                    {
                        result = "除数不能为0！";

                    }
                    else
                    {
                        result = (para1 / para2).ToString();
                    }
                    break;

            }
            return result;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
