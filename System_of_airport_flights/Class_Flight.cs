using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_of_airport_flights
{
    class Class_Flight
    {
        private DateTime date_time;

        public DateTime Date_time
        {
            get { return date_time ; }
            set { date_time = value; }
        }
        private string flight_num;

        public string Flight_num
        {
            get { return flight_num; }
            set { flight_num = value; }
        }
        private string airline;

        public string Airline
        {
            get { return airline; }
            set { airline = value; }
        }
        private string city_of_arrival;

        public string City_of_arrival
        {
            get { return city_of_arrival; }
            set { city_of_arrival = value; }
        }

        private char terminal;

        public char Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }
        private string flight_status;

        public string Flight_status
        {
            get { return flight_status; }
            set { flight_status = value; }
        }
        public Class_Flight(DateTime date_time, string flight_num, string airline, string city_of_arrival, char terminal, string flight_status)
        {
            this.date_time = date_time;
            this.flight_num = flight_num;
            this.airline = airline;
            this.city_of_arrival = city_of_arrival;
            this.terminal = terminal;
            this.flight_status = flight_status;
        }
        public string ShowFlightCharacters()
        {
            return this.date_time + " " + this.flight_num + " " + this.airline + " " + this.city_of_arrival + " " + this.terminal + " " + this.flight_status;
        }
    }
}
