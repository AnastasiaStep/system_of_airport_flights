using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_of_airport_flights
{
    class Flight
    {

        static public List<Flight> flights = new List<Flight>();

        private DateTime date_time;

        public DateTime Date_time
        {
            get { return date_time ; }
            set { date_time = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string airline;

        public string Airline
        {
            get { return airline; }
            set { airline = value; }
        }
        private string cityOfArrival;

        public string CityOfArrival
        {
            get { return cityOfArrival; }
            set { cityOfArrival = value; }
        }

        private string terminal;

        public string Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Flight(DateTime date_time, string number, string airline, string cityOfArrival, string terminal, string status)
        {

            this.date_time = date_time;
            this.number = number;
            this.airline = airline;
            this.cityOfArrival = cityOfArrival;
            this.terminal = terminal;
            this.status = status;

        }

        public Flight() { }
        public string ShowFlightCharacters()
        {
            return this.date_time + " " + this.number + " " + this.airline + " " + this.cityOfArrival + " " + this.terminal + " " + this.status;
        }

        static public void GetFlight(string path)
        {

            string[] data = File.ReadAllLines(path);

            try
            {

                if (data.Length == 0) { return; }

                foreach (string str in data)
                {

                    string[] flight = str.Split(',');

                    string[] date = flight[0].Split(' ');

                    Flight.flights.Add(new Flight(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), int.Parse(date[3]), int.Parse(date[4]), int.Parse(date[5])), 
                        flight[1], flight[2], flight[3], flight[4], flight[5]));

                } 
            } catch
            {
                
            }
            
        }
        
        static public void AddFlight(Flight flight, string path)
        {

            flights.Add(flight);

            using (StreamWriter sw = File.AppendText(path))
            {

                sw.WriteLine ("{0} {1} {2} {3} {4} {5},{6},{7},{8},{9},{10}", flight.date_time.Year, flight.date_time.Month, flight.date_time.Day, flight.date_time.Hour, flight.date_time.Minute, 
                    flight.date_time.Second, flight.Number, flight.Airline, flight.CityOfArrival, flight.Terminal, flight.Status);

            }

        } 

    }
}
