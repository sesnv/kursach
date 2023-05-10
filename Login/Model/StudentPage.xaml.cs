using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Login.Model
{
    /// <summary>
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    
    public partial class StudentPage : Window
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://do.sibstrin.ru/login/index.php");
        }

        // Button 2 click event
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.iprbookshop.ru");
        }

        // Button 3 click event
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            InfoPage newWindow = new InfoPage();
            newWindow.Show();
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            this.Close();
        }
    }
}
