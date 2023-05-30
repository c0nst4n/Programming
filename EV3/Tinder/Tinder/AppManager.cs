using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinder
{
    public class AppManager
    {
        private static AppManager _instance;

        public static AppManager Instance => _instance;

        static AppManager()
        {
            _instance = new AppManager();
            
        }

        public ObservableCollection<User> FilterUsers(string pattern, int offset, int limit)
        {
            
           return Database.Filter(pattern, offset, limit);
        }

    }
}
