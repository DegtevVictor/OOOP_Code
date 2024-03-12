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

namespace WpfApp1
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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Это окно выбора, выберите Да для выхода", 
                "Hello World", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Information, 
                MessageBoxResult.Yes);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    break;
                default:
                    MessageBox.Show("Выход не произведён");
                    Button1_Click(sender, e);
                    break;
            }
        }
    }
}
