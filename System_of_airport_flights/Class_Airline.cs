using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_of_airport_flights
{
    class Class_Airline
    {
        private string airline_name;

        public string Airline_name
        {
            get { return airline_name; }
            set { airline_name = value; }
        }

        private string routes;

        public string Routes
        {
            get { return routes; }
            set { routes = value; }
        }

        private string airline_plane;
   
        public string Airline_plane
        {
            get { return airline_plane; }
            set { airline_plane = value; }
        }

        public Class_Airline(string airline_name, string routes, string airline_plane)
        {
            this.airline_name = airline_name;
            this.routes = routes;
            this.airline_plane = airline_plane;
        }
        public string ShowAirlineCharacters()
        {
            return this.airline_name + " " + this.routes + " " + this.airline_plane;
        }
    }
}
