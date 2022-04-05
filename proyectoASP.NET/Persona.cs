using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoASP.NET
{
    public class Persona
    {
        private String _dni;
        private String _name;
        private String _surname;

        public String dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public String name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public String surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public Persona(String dni, String name, String surname)
        {
            _dni = dni;
            _name = name;
            _surname = surname;
        }
        public override string ToString()
        {
            return this.dni + ", " + this.name + ", " + this.surname;
        }
    }
}