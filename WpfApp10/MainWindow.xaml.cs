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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red = (byte)red_slider.Value; //значение красного
            byte green = (byte)green_slider.Value; //значение зеленого
            byte blue = (byte)blue_slider.Value; //значение синего
            Color color = Color.FromRgb(red, green, blue); //создание цвета
            color_button.Background = new SolidColorBrush(color); //присваивание цвета
            textBox.Text = "Red = " + Math.Round(red_slider.Value).ToString() + "\nGreen = " + Math.Round(green_slider.Value).ToString() + "\nBlue = " + Math.Round(blue_slider.Value).ToString();
        }
    }
}
