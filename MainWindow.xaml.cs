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

namespace pr4_isrpo
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
        Random r;
        int x;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            r = new Random();
            x = r.Next(1, 100);
            TextBox1.Text = "" + x;
        
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            int y = Convert.ToInt32(TextBox2.Text);
            if (y > x)
                TextBox2.Text = "Больше";
            else if (y < x)
                TextBox2.Text = "Меньше";
            else if (y == x)
            {
                TextBox2.Text = "Равно";
            }
        }
    }
}
