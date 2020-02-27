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

namespace Calculator3
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            double para1 = 0;
            double para2 = 0;

            if(Double.TryParse(Para1.Text, out para1) && Double.TryParse(Para2.Text, out para2))

            {
                Result.Text = Calculate(para1, para2);
            }
            else
            {
                Result.Text = "输入错误，请重新输入！";
            }
        }

        private string Calculate(double para1, double para2)
        {
            String result = "";
            switch (Sign.Text)
            {
                case "+":
                    result = (para1 + para2).ToString();
                    break;
                case "-":
                    result = (para1 - para2).ToString();
                    break;
                case "*":
                    result = (para1 * para2).ToString();
                    break;
                case "/":
                    if(para2 == 0)
                    {
                        result = "除数不能为0";
                    }
                    else
                    {
                        result = (para1 / para2).ToString();
                    }
                    break;
            }
            return result;
           
        }

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Para2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
