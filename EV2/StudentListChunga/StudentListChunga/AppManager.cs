using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace StudentListChunga
{
    internal class AppManager
    {
        private static AppManager _instance = new AppManager();
        public List<Student> _students = new List<Student>();

        public static AppManager Instance => _instance;
        public List<Student> Students
        {
            get => _students;
            set
            {
                if (value != null)
                    _students = value;
            }
        }

        public static void Error(string text)
        {
            string messageBoxText = text;
            string caption = "ERROR";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

      
    }
}
