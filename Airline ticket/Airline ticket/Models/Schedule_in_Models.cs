using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket.Models
{
    public class Schedule_in_Models : INotifyPropertyChanged
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

        public Schedule_in_Models() { }


        public DateTime _Date_In;

        public DateTime Date_In
        {
            get { return _Date_In; }
            set { _Date_In = value; OnpropertyChanged(); }
        }

        public DateTime _Date_out;

        public DateTime Date_out
        {
            get { return _Date_out; }
            set { _Date_out = value; OnpropertyChanged(); }
        }

        public string Date => $"{Date_In.ToString()}    {Date_out.ToString()}";
    }
}
