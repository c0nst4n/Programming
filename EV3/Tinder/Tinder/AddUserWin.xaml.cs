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

namespace Tinder
{
    /// <summary>
    /// Lógica de interacción para AddUserWin.xaml
    /// </summary>
    public partial class AddUserWin : Window
    {
        public AddUserWin()
        {
            InitializeComponent();
        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            Database.AddUser(Nombre.Text, Edad.Text, Descripcion.Text, Sexo.Text, Valoracion.Text, Foto.Text);
            Close();
        }
    }
}
