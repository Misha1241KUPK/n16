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

namespace var_16
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

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            int s;
            int a = Convert.ToInt32(t1.Text);
            int b = Convert.ToInt32(t2.Text);
            int c = Convert.ToInt32(t3.Text);
            int d = Convert.ToInt32(t4.Text);
            s = c + d - (a * b);
            if (s >= 0)
                MessageBox.Show("Зарплаты хватит всем");
            else
                MessageBox.Show("Зарплаты не хватит");
        }
    }
}
