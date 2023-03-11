using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using static StudentListChunga.AppManager;

namespace StudentListChunga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       private Student _estudiante = null;
        private string _path = "C:\\Users\\costa\\Desktop\\JSONES";
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        

        private void Substract_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //SHOW
        {

            _estudiante = new Student(Convert.ToInt32(AgeBox.Text), NameBox.Text, DescBox.Text);
            JsonShow.Text = _estudiante.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e) //SAVE
        {
            Save();
            

        }

        private void DescBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddButton(object sender, RoutedEventArgs e) //Add
        {
            JsonShow.Text = " ";

            try
            {
                string name = NameBox.Text;
                int Age = Int32.Parse(AgeBox.Text);
                string desc = DescBox.Text;

                Instance.Students.Add(new Student(Age, name, desc));
            }

            catch 
            {
               Error("SEXO");
            }

            ShowStudentList();
        }

        public string ShowStudentList()
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented= true;
            string Json = JsonSerializer.Serialize(Instance.Students, options);

           JsonShow.Text = Json;

            return Json;
        }

        public void Save()
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, ShowStudentList());
            }
            catch
            {
                Error("Error al guardar");
            }

        }

        void Load()
        {
            string s = "";
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                s = File.ReadAllText(openFileDialog.FileName);
            try
            {
                var json = JsonSerializer.Deserialize<List<Student>>(s);
                if (json != null)
                    Instance.Students = json;
            }
            catch
            {
                Error("Tipo de archivo inválido.");
            }

            ShowStudentList();
        }



        private void Load_Button(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
