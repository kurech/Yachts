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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        WorldYachtsEntities context = new WorldYachtsEntities();
        List<User> search = new List<User>();
        public Main()
        {
            InitializeComponent();
            RefreshTable();
        }

        public void RefreshTable()
        {
            dataGridUsers.ItemsSource = context.User.ToList();
        }

        private void editUsers_Click(object sender, RoutedEventArgs e)
        {
            EditUsers editUsers = new EditUsers(sender, this);
            editUsers.Show();
        }

        private void deleteUsers_Click(object sender, RoutedEventArgs e)
        {
            DeleteUsers deleteUsers = new DeleteUsers(sender, this);
            deleteUsers.Show();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach(User user in context.User)
            {
                if(user.Login == txtSearch.Text)
                {
                    search.Add(user);
                    dataGridUsers.ItemsSource = search;
                }
                if(txtSearch.Text == "")
                {
                    RefreshTable();
                }
            }
        }

        private void cmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSort.SelectedIndex == 0)
            {
                dataGridUsers.ItemsSource = context.User.OrderBy(n => n.Login).ToList();
            }
            if (cmbSort.SelectedIndex == 1)
            {
                dataGridUsers.ItemsSource = context.User.OrderByDescending(n => n.Login).ToList();
            }
        }
    }
}
