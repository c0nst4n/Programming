using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Tinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> userlist = new ObservableCollection<User>();
        int id;

        public MainWindow()
        {
            InitializeComponent();
           ObservableCollection<User> users = new ObservableCollection<User>(AppManager.Instance.dbase.Connect());
            ListViewProducts.ItemsSource = users;
           
        }

        private void desplegar_Click(object sender, RoutedEventArgs e)
        {
           
            Button b = (Button)sender;
            User u = (User)b.DataContext;
            //MessageBox.Show(p.Description);
            string user =
                          $" Nombre: {u.name}\n" +
                          $" Edad: {u.age}\n" +
                          $" Descripción: {u.description} \n" +
                          $" Género: {u.gender} \n" +
                          $" Puntuación: {u.rating} \n";
            desc.Text = user;
            setImage(fotanga, new Uri(u.photo));


            //foto.Initialized initialized= true;
            //ListViewProducts.ItemsSource = userlist;
            id = u.Id;
        }

        public void setImage(Image img, Uri url)
        {
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = url;
            b.EndInit();
            img.Source = b;

        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            AppManager.Instance.dbase.DeleteUser(id);
        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            Window add = new AddUserWin(ListViewProducts);

            add.Show();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            UpdateUser();
        }

        private async Task UpdateUser()
        {
            string pattern = Searchtb.Text;
            await Task.Delay(2000);
            if (Searchtb.Text == pattern)
             ListViewProducts.ItemsSource = AppManager.Instance.FilterUsers(pattern, 0, int.MaxValue);

        }
    }
}
