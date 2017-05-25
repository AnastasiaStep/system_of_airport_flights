using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_of_airport_flights
{
    class Class_Terminal
    {
        private int exit_num;

        public int Exit_num
        {
            get { return exit_num; }
            set { exit_num = value; }
        }

        private string type_of_exit;//под типом выхода имеется ввиду рукав или автобус 

        public string Type_of_exit
        {
            get { return type_of_exit; }
            set { type_of_exit = value; }
        }

        public Class_Terminal(int exit_num, string type_of_exit)
        {
            this.exit_num = exit_num;
            this.type_of_exit = type_of_exit;
        }

        public string ShowTerminalCharacters()
        {
            return this.exit_num + " " + this.type_of_exit;
        }
    }
}
