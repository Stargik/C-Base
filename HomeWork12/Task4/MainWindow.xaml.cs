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

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler PlusEvent = null;
        public event EventHandler DivEvent = null;
        public event EventHandler MultEvent = null;
        public event EventHandler MinusEvent = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlusEvent.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MinusEvent.Invoke(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MultEvent.Invoke(sender, e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DivEvent.Invoke(sender, e);
        }
    }
}
