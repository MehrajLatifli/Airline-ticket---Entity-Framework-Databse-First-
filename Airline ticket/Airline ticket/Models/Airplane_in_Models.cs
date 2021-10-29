using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket.Models
{
    public class Airplane_in_Models : INotifyPropertyChanged
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

        public Airplane_in_Models() { }


        public string _Name_of_Airplane;

        public string Name_of_Airplane
        {
            get { return _Name_of_Airplane; }
            set { _Name_of_Airplane = value; OnpropertyChanged(); }
        }

        public long _Passengers__count;

        public long Passengers__count
        {
            get { return _Passengers__count; }
            set { _Passengers__count = value; OnpropertyChanged(); }
        }

        public string FullAirplane => $"{Name_of_Airplane.ToString()}   {Passengers__count.ToString()}";
    }
}

