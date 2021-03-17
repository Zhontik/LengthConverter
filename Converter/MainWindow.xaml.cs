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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConverterDataBase DataConvert = new ConverterDataBase();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GiveResult(object sender, RoutedEventArgs e)
        {
            string text = FromValue.Text;
            double fromNum;
            if (text != "")
            {
                try
                {
                    fromNum = Double.Parse(FromValue.Text);
                    ToValue.Text = $"{CountResult(fromNum, FromValueType.Text, ToValueType.Text)}";
                }
                catch
                {
                    ToValue.Text = ("Введено некорректное число");
                }
            }

        }
        private double CountResult(double num, string fromType, string toType)
        {
            double res = num / DataConvert.fromMetresTo[fromType] * DataConvert.fromMetresTo[toType];
            return res;
        }
    }
}
