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
using System.Windows.Shapes;

namespace Yachts
{
    /// <summary>
    /// Логика взаимодействия для EditUsers.xaml
    /// </summary>
    public partial class EditUsers : Window
    {
        public WorldYachtsEntities context = new WorldYachtsEntities();
        public Main _main;
        public User _user;
        public EditUsers(object o, Main main)
        {
            InitializeComponent();
            _user = (o as Button).DataContext as User;

            txtLogin.Text = _user.Login;
            txtPassword.Text = _user.Password;

            _main = main;
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            _user.Login = txtLogin.Text;
            _user.Password = txtPassword.Text;
            MessageBox.Show("Seccess!");
            _main.RefreshTable();
            context.SaveChanges();
        }
    }
}
