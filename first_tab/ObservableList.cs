using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class ObservableList : ObservableCollection<City>
    {


        public ObservableList() : base()
        {
            Add(new City("Marseille", 22, 4));
            Add(new City("Berlin", 3110, 70));
            Add(new City("Toulouse", 6, 1.25));
            Add(new City("Paris", 14.21f, 14.23f));
            Add(new City("Toulon", 211.21, 51.23));
            Add(new City("Nice", 142, 68));
            Add(new City("Strasbourg", 83, 94));
            Add(new City("Lille", 75, 157));
        }
    }
}
