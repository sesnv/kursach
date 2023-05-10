using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using static Login.Model.InfoPage;

namespace Login.Model
{
    /// <summary>
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    
    public partial class InfoPage : Window
    {
        public class user
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MailAddress { get; set; }
        }


        //You can keep your Logged user in a static class



        public static class PublicParameters
        {
            public static user CurrentUser;



            //Define only one connection string in your application.
            public static string ConnectionString = @"Data Source=   (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated 
 Security=True;"
        }



        void Login()
        {
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlComm = new SqlCommand("SELECT COUNT(1) FROM tbl WHERE Username=@Username AND Password=@Password", sqlConn))
                {
                    if (sqlComm.Connection.State == System.Data.ConnectionState.Closed)
                        sqlComm.Connection.Open();
                    SqlDataReader sqlRd = sqlComm.ExecuteReader();
                    sqlComm.Parameters.AddWithValue("@Username", txtbxUsername.Text);
                    sqlComm.Parameters.AddWithValue("@Password", pswbxPassword.Password);



                    //Your username column must be unique
                    while (sqlRd.Read())
                    {
                        PublicParameters.CurrentUser = new Controllers.User();
                        PublicParameters.CurrentUser.FirstName = sqlRd["FirstName"].ToString();
                        PublicParameters.CurrentUser.LastName = sqlRd["LastName"].ToString();
                        PublicParameters.CurrentUser.MailAddress = sqlRd["MailAddress"].ToString();
                        //And other properties to assign
                    }



                    if (PublicParameters.CurrentUser != null)
                    {
                        MessageBox.Show("Login successfully!");
                        //Yo have your logged user 
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect");
                    }
                }
            }
        }
        public InfoPage()
        {
            InitializeComponent();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StudentPage newWindow = new StudentPage();

            newWindow.Show();

            this.Close();
        }
    }
}
