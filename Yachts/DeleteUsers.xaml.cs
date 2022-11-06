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
    /// Логика взаимодействия для DeleteUsers.xaml
    /// </summary>
    public partial class DeleteUsers : Window
    {
        public WorldYachtsEntities context = new WorldYachtsEntities();
        public Main _main;
        public User _user;
        public DeleteUsers(object o, Main main)
        {
            InitializeComponent();
            _user = (o as Button).DataContext as User;
            _main = main;
            lbluser.Content = _user.Login;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            context.User.Remove(_user);
            context.SaveChanges();
            _main.RefreshTable();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
