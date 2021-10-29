using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket.Models
{
    public class City_in_Models : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public City_in_Models() { }


        public string _From_City;

        public string From_City
        {
            get { return _From_City; }
            set { _From_City = value; OnpropertyChanged(); }
        }

        public string _To_City;

        public string To_City
        {
            get { return _To_City; }
            set { _To_City = value; OnpropertyChanged(); }
        }

        public string FullCity => $"{From_City.ToString()}   {To_City.ToString()}";
    }
}
