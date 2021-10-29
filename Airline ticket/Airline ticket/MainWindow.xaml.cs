using Airline_ticket.Entities;
using Airline_ticket.FakeRepository;
using Airline_ticket.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Airline_ticket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public FakeRepo FakeRepo_FlightType { get; set; }
        public FakeRepo FakeRepo_City { get; set; }
        public FakeRepo FakeRepo_Schedule { get; set; }
        public FakeRepo FakeRepo_Airplain { get; set; }
        public FakeRepo FakeRepo_Pilot { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }



        private ObservableCollection<Pilot> allPilot;

        public ObservableCollection<Pilot> AllPilot
        {
            get { return allPilot; }
            set { allPilot = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FlightType> allFlightType;

        public ObservableCollection<FlightType> AllFlightType
        {
            get { return allFlightType; }
            set { allFlightType = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Schedule> allSchedule;

        public ObservableCollection<Schedule> AllSchedule
        {
            get { return allSchedule; }
            set { allSchedule = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Airplane> allAirplane;

        public ObservableCollection<Airplane> AllAirplane
        {
            get { return allAirplane; }
            set { allAirplane = value; OnPropertyChanged(); }
        }

        private ObservableCollection<City> allCity;

        public ObservableCollection<City> AllCity
        {
            get { return allCity; }
            set { allCity = value; OnPropertyChanged(); }
        }

        private ObservableCollection<AirplanePilot> allAirplanePilot;

        public ObservableCollection<AirplanePilot> AllAirplanePilot
        {
            get { return allAirplanePilot; }
            set { allAirplanePilot = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Ticket> allTicket;

        public ObservableCollection<Ticket> AllTicket
        {
            get { return allTicket; }
            set { allTicket = value; OnPropertyChanged(); }
        }


        private Pilot currentPilot;

        public Pilot CurrentPilot
        {
            get { return currentPilot; }
            set { currentPilot = value; OnPropertyChanged(); }
        }

        private FlightType currentFlightType;

        public FlightType CurrentFlightType
        {
            get { return currentFlightType; }
            set { currentFlightType = value; OnPropertyChanged(); }
        }

        private Schedule currentSchedule;

        public Schedule CurrentSchedule
        {
            get { return currentSchedule; }
            set { currentSchedule = value; OnPropertyChanged(); }
        }

        private Airplane currentAirplane;

        public Airplane CurrentAirplane
        {
            get { return currentAirplane; }
            set { currentAirplane = value; OnPropertyChanged(); }
        }

        private City currentCity;

        public City CurrentCity
        {
            get { return currentCity; }
            set { currentCity = value; OnPropertyChanged(); }
        }

        private AirplanePilot currentAirplanePilot;

        public AirplanePilot CurrentAirplanePilot
        {
            get { return currentAirplanePilot; }
            set { currentAirplanePilot = value; OnPropertyChanged(); }
        }

        private Ticket currentTicket;

        public Ticket CurrentTicket
        {
            get { return currentTicket; }
            set { currentTicket = value; OnPropertyChanged(); }
        }




        private ObservableCollection<City_in_Models> allCity_in_Models;

        public ObservableCollection<City_in_Models> AllCity_in_Models
        {
            get { return allCity_in_Models; }
            set { allCity_in_Models = value; OnPropertyChanged(); }
        }

        private City_in_Models currentCity_in_Models;

        public City_in_Models CurrentCity_in_Models
        {
            get { return currentCity_in_Models; }
            set { currentCity_in_Models = value; OnPropertyChanged(); }
        }


        private ObservableCollection<FlightType_in_Models> allFlightType_in_Models;

        public ObservableCollection<FlightType_in_Models> AllFlightType_in_Models
        {
            get { return allFlightType_in_Models; }
            set { allFlightType_in_Models = value; OnPropertyChanged(); }
        }

        private FlightType_in_Models currentFlightType_in_Models;

        public FlightType_in_Models CurrentFlightType_in_Models
        {
            get { return currentFlightType_in_Models; }
            set { currentFlightType_in_Models = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Pilot_in_Models> allPilot_in_Models;

        public ObservableCollection<Pilot_in_Models> AllPilot_in_Models
        {
            get { return allPilot_in_Models; }
            set { allPilot_in_Models = value; OnPropertyChanged(); }
        }

        private Pilot_in_Models currentPilot_in_Models;

        public Pilot_in_Models CurrentPilot_in_Models
        {
            get { return currentPilot_in_Models; }
            set { currentPilot_in_Models = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Schedule_in_Models> allSchedule_in_Models;

        public ObservableCollection<Schedule_in_Models> AllSchedule_in_Models
        {
            get { return allSchedule_in_Models; }
            set { allSchedule_in_Models = value; OnPropertyChanged(); }
        }

        private Schedule_in_Models currentSchedule_in_Models;

        public Schedule_in_Models CurrentSchedule_in_Models
        {
            get { return currentSchedule_in_Models; }
            set { currentSchedule_in_Models = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Airplane_in_Models> allAirplane_in_Models;

        public ObservableCollection<Airplane_in_Models> AllAirplane_in_Models
        {
            get { return allAirplane_in_Models; }
            set { allAirplane_in_Models = value; OnPropertyChanged(); }
        }

        private Airplane_in_Models currentAirplane_in_Models;

        public Airplane_in_Models CurrentAirplane_in_Models
        {
            get { return currentAirplane_in_Models; }
            set { currentAirplane_in_Models = value; OnPropertyChanged(); }
        }







        public MainWindow()
        {
            InitializeComponent();

 


                FakeRepo_FlightType = new FakeRepo();
            AllFlightType_in_Models = new ObservableCollection<FlightType_in_Models>(FakeRepo_FlightType.GetFlightType_In_Models());


            FakeRepo_City = new FakeRepo();
            AllCity_in_Models = new ObservableCollection<City_in_Models>(FakeRepo_City.GetCity_In_Models());


            FakeRepo_Schedule = new FakeRepo();
            AllSchedule_in_Models = new ObservableCollection<Schedule_in_Models>(FakeRepo_Schedule.GetSchedule_In_Models());

            FakeRepo_Pilot = new FakeRepo();
            AllPilot_in_Models = new ObservableCollection<Pilot_in_Models>(FakeRepo_Pilot.GetPilot_in_Models());

            FakeRepo_Airplain = new FakeRepo();
            AllAirplane_in_Models = new ObservableCollection<Airplane_in_Models>(FakeRepo_Airplain.GetAirplane_In_Models());


            using (var context = new Airline_ticketEntities1())
            {

                context.Database.CreateIfNotExists();


                var count = context.Tickets
               .Where(o => o.IdTicket <= '0')
               .SelectMany(o => o.AirplanePilot.Tickets)
               .Count();


                try
                {

           


                    if (count == 0)
                    {
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.FlightTypes");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Schedules");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Airplanes");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Pilots");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.AirplanePilots");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Cities");
                        context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Tickets");



                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.FlightTypes', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Schedules', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Airplanes', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Pilots', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.AirplanePilots', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Cities', RESEED, 0)");
                        context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Tickets', RESEED, 0)");

                        context.SaveChanges();
                    }

                }
                catch (Exception)
                {


                }
            }


            AllTicket = GetAllData();


            using (var context = new Airline_ticketEntities1())
            {
                fulldatalistview.ItemsSource = AllTicket;
            }



            FlightTypeComboBox.ItemsSource = AllFlightType_in_Models;
 
            FlightTypeComboBox.DisplayMemberPath = "Flight_Type";

            CityComboBox.ItemsSource = AllCity_in_Models;
            CityComboBox.DisplayMemberPath = "FullCity";

            AirplaneComboBox.ItemsSource = AllAirplane_in_Models;
            AirplaneComboBox.DisplayMemberPath = "FullAirplane";
            
            ScheduleComboBox.ItemsSource = AllSchedule_in_Models;
            ScheduleComboBox.DisplayMemberPath = "Date";
       
            PilotComboBox.ItemsSource = AllPilot_in_Models;
            PilotComboBox.DisplayMemberPath = "FullPilot";


        }

        public ObservableCollection<Ticket> GetAllData()
        {
            var orders = new ObservableCollection<Ticket>();

            using (var context = new Airline_ticketEntities1())
            {
                orders = new ObservableCollection<Ticket>(context.Tickets.Include("City").Include("FlightType").Include("Schedule").Include("AirplanePilot.Pilot").Include("AirplanePilot.Airplane"));


                return orders;
            }
        }

        public ObservableCollection<AirplanePilot> GetAllData2()
        {
            var orders = new ObservableCollection<AirplanePilot>();

            using (var context = new Airline_ticketEntities1())
            {
                orders = new ObservableCollection<AirplanePilot>(context.AirplanePilots.Include("Airplane").Include("Pilot"));

              
            }

            return orders;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (FlightTypeComboBox.SelectedIndex != -1 && CityComboBox.SelectedIndex != -1 && AirplaneComboBox.SelectedIndex != -1 && ScheduleComboBox.SelectedIndex != -1 && PilotComboBox.SelectedIndex != -1)
            {
                using (var context = new Airline_ticketEntities1())
                {

                    var count = context.Tickets
                .Where(o => o.IdTicket <= '0')
                .SelectMany(o => o.AirplanePilot.Tickets)
                .Count();

  

                    try
                    {

                        if (count == 0)
                        {
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.FlightTypes");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Schedules");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Airplanes");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Pilots");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.AirplanePilots");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Cities");
                            context.Database.ExecuteSqlCommand(@"  delete from Airline_ticket.dbo.Tickets");



                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.FlightTypes', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Schedules', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Airplanes', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Pilots', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.AirplanePilots', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Cities', RESEED, 0)");
                            context.Database.ExecuteSqlCommand(@"  DBCC CHECKIDENT ('Airline_ticket.dbo.Tickets', RESEED, 0)");

                            context.SaveChanges();
                        }

                    }
                    catch (Exception)
                    {


                    }

                    CurrentTicket = new Ticket();


                    CurrentPilot = new Pilot();

                    CurrentAirplane = new Airplane();

                    CurrentAirplanePilot = new AirplanePilot();

                    CurrentAirplanePilot.Pilot = new Pilot();

                    CurrentPilot_in_Models = new Pilot_in_Models();

                    CurrentAirplanePilot.Airplane = new Airplane();

                    CurrentAirplane = new Airplane();

                    CurrentTicket.FlightType = new FlightType();

                    CurrentTicket.Schedule = new Schedule();

                    CurrentTicket.City = new City();

                    CurrentTicket.AirplanePilot = new AirplanePilot();

                    CurrentFlightType_in_Models = new FlightType_in_Models();

                    CurrentSchedule_in_Models = new Schedule_in_Models();

                    CurrentCity_in_Models = new City_in_Models();

                    CurrentPilot_in_Models = new Pilot_in_Models();

                    CurrentAirplane_in_Models = new Airplane_in_Models();

                    CurrentTicket.AirplanePilot.Pilot = new Pilot();

                    CurrentTicket.AirplanePilot.Airplane = new Airplane();

                    var item = FlightTypeComboBox.SelectedValue as FlightType_in_Models;
                    var item2 = ScheduleComboBox.SelectedValue as Schedule_in_Models;
                    var item3 = CityComboBox.SelectedValue as City_in_Models;
                    var item4 = AirplaneComboBox.SelectedValue as Airplane_in_Models;
                    var item5 = PilotComboBox.SelectedValue as Pilot_in_Models;


                    try
                    {

                        Guid guid = Guid.NewGuid();


                        MessageBox.Show($"{item.Flight_Type} {item2.Date_In} {item2.Date_out} {item3.From_City} {item3.To_City} {item5.Pilots_name} {item5.Pilots_surname} {item4.Name_of_Airplane} {item4.Passengers__count}");


                        CurrentTicket.Code_of_Ticket = guid.ToString();
                        CurrentTicket.FlightType.Flight_Type = item.Flight_Type;
                        CurrentTicket.Schedule.Date_In = item2.Date_In;
                        CurrentTicket.Schedule.Date_out = item2.Date_out;
                        CurrentTicket.City.From_City = item3.From_City;
                        CurrentTicket.City.To_City = item3.To_City;
                        CurrentTicket.AirplanePilot.Pilot.Pilots_name = item5.Pilots_name;
                        CurrentTicket.AirplanePilot.Pilot.Pilots_surname = item5.Pilots_surname;
                        CurrentTicket.AirplanePilot.Airplane.Name_of_Airplane = item4.Name_of_Airplane;
                        CurrentTicket.AirplanePilot.Airplane.Passengers__count = item4.Passengers__count;



                        context.Entry(CurrentTicket).State = System.Data.Entity.EntityState.Added;
                        context.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                // raise a new exception nesting  
                                // the current instance as InnerException  
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }


                    AllTicket = GetAllData();
                    fulldatalistview.ItemsSource = AllTicket;

                }
            }


            else
            {
                MessageBox.Show($"Select item in each Combo boxes.");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (FlightTypeComboBox.SelectedIndex != -1 && CityComboBox.SelectedIndex != -1 && AirplaneComboBox.SelectedIndex != -1 && ScheduleComboBox.SelectedIndex != -1 && PilotComboBox.SelectedIndex != -1)
            {
                using (var context = new Airline_ticketEntities1())
                {

                    CurrentTicket = new Ticket();


                    CurrentPilot = new Pilot();

                    CurrentAirplane = new Airplane();

                    CurrentAirplanePilot = new AirplanePilot();

                    CurrentAirplanePilot.Pilot = new Pilot();

                    CurrentPilot_in_Models = new Pilot_in_Models();

                    CurrentAirplanePilot.Airplane = new Airplane();

                    CurrentAirplane = new Airplane();

                    CurrentTicket.FlightType = new FlightType();

                    CurrentTicket.Schedule = new Schedule();

                    CurrentTicket.City = new City();

                    CurrentTicket.AirplanePilot = new AirplanePilot();

                    CurrentFlightType_in_Models = new FlightType_in_Models();

                    CurrentSchedule_in_Models = new Schedule_in_Models();

                    CurrentCity_in_Models = new City_in_Models();

                    CurrentPilot_in_Models = new Pilot_in_Models();

                    CurrentAirplane_in_Models = new Airplane_in_Models();

                    CurrentTicket.AirplanePilot.Pilot = new Pilot();

                    CurrentTicket.AirplanePilot.Airplane = new Airplane();

                    var item = FlightTypeComboBox.SelectedValue as FlightType_in_Models;
                    var item2 = ScheduleComboBox.SelectedValue as Schedule_in_Models;
                    var item3 = CityComboBox.SelectedValue as City_in_Models;
                    var item4 = AirplaneComboBox.SelectedValue as Airplane_in_Models;
                    var item5 = PilotComboBox.SelectedValue as Pilot_in_Models;


                    if (fulldatalistview.SelectedIndex != -1)
                    {
                        var selected = fulldatalistview.SelectedItem as Ticket;
                        Ticket ticket = context.Tickets.Find(selected.IdTicket);



                        try
                        {

                            Guid guid = Guid.NewGuid();

                            MessageBox.Show($"{item.Flight_Type} {item2.Date_In} {item2.Date_out} {item3.From_City} {item3.To_City} {item5.Pilots_name} {item5.Pilots_surname} {item4.Name_of_Airplane} {item4.Passengers__count}");


                            ticket.Code_of_Ticket = guid.ToString();
                            ticket.FlightType.Flight_Type = item.Flight_Type;
                            ticket.Schedule.Date_In = item2.Date_In;
                            ticket.Schedule.Date_out = item2.Date_out;
                            ticket.City.From_City = item3.From_City;
                            ticket.City.To_City = item3.To_City;
                            ticket.AirplanePilot.Pilot.Pilots_name = item5.Pilots_name;
                            ticket.AirplanePilot.Pilot.Pilots_surname = item5.Pilots_surname;
                            ticket.AirplanePilot.Airplane.Name_of_Airplane = item4.Name_of_Airplane;
                            ticket.AirplanePilot.Airplane.Passengers__count = item4.Passengers__count;



                            context.Entry(ticket).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();

                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                        {
                            Exception raise = dbEx;
                            foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                                foreach (var validationError in validationErrors.ValidationErrors)
                                {
                                    string message = string.Format("{0}:{1}",
                                        validationErrors.Entry.Entity.ToString(),
                                        validationError.ErrorMessage);
                                    // raise a new exception nesting  
                                    // the current instance as InnerException  
                                    raise = new InvalidOperationException(message, raise);
                                }
                            }
                            throw raise;
                        }





                        AllTicket = GetAllData();
                        fulldatalistview.ItemsSource = AllTicket;
                    }
                }
            }

            else
            {
                MessageBox.Show($"Select item in each Combo boxes.");
            }
        
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Airline_ticketEntities1())
            {


                var selected = fulldatalistview.SelectedItem as Ticket;

                if (selected != null)
                {
                    Ticket ticket = context.Tickets.Find(selected.IdTicket);


                    var ap = context.AirplanePilots.Find(selected.AirplanePilotsId);

                    var p = context.Pilots.Find(selected.AirplanePilot.PilotsId);
                    var a = context.Airplanes.Find(selected.AirplanePilot.AirplanesId);


                    var c = context.Cities.Find(selected.CitiesId);

                    var f = context.FlightTypes.Find(selected.FlightTypesId);

                    var s = context.Schedules.Find(selected.SchedulesId);




                    context.Entry(ap).Collection("Tickets").Load();
                    context.Entry(ap).Collection("Tickets").Load();
                    context.Entry(ap).Collection("Tickets").Load();
                    context.Entry(c).Collection("Tickets").Load();
                    context.Entry(f).Collection("Tickets").Load();
                    context.Entry(s).Collection("Tickets").Load();

                    context.Entry(ticket).State = System.Data.Entity.EntityState.Deleted;

                    context.Entry(ap).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(c).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(f).State = System.Data.Entity.EntityState.Deleted;
                    context.Entry(s).State = System.Data.Entity.EntityState.Deleted;


                    context.SaveChanges();


                    AllTicket = GetAllData();
                    fulldatalistview.ItemsSource = AllTicket;

                }

                else
                {
                    MessageBox.Show($"Data base is empty.");
                }
            }
            
        }
    }
}

