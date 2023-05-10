using Login.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class user
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MailAddress { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            if (rbDean.IsChecked == true && username == "admin" && password == "admin")
            {
                DecanatPage newWindow = new DecanatPage();

                // Show the new window
                newWindow.Show();

                // Close the current window
                this.Close();
            }
            else if (rbStudent.IsChecked == true)
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=new_bd;Integrated Security=True");
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    string query = "SELECT COUNT(1) FROM student WHERE familiya=@familiya AND paroli=@paroli";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@familiya", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@paroli", txtPassword.Password);
                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        StudentPage dashboard = new StudentPage();
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password incorrect");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Username or password incorrect");

                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }
    }
}


