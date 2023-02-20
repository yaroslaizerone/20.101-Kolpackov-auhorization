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

namespace _20._101_Kolpackov_auhorization
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string UserLogin = TBLogin.Text.ToString();
            string UserPassword = TBPassword.Text.ToString();
            Users users = new Users();

            try
            {
                users = DataEntities.GetContext().Users.Where(x => x.Login == UserLogin && x.Password == UserPassword).FirstOrDefault();
                if (users != null)
                {
                    if (users.GetNamePost == "Администратор")
                    {
                        OutputResult("Администратор");
                    }
                    else if (users.GetNamePost == "Менеджер")
                    {
                        OutputResult("Менеджер");
                    }
                    else if (users.GetNamePost == "Клиент")
                    {
                        OutputResult("Клиент");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                
                }   
            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
            
        }

        public string OutputResult(string str)
        {
            MessageBox.Show($"Добро пожаловать! Ваша роль: {str}");
            return str;
        }
    }
}
