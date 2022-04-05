using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoASP.NET
{
    public class Medico : Persona
    {
        private int _id_doc;

        public Medico(String dni, String name, String surname, int id) : base(dni, name, surname)
        {
            _id_doc = id;
        }
        public int id_doc
        {
            get
            {
                return _id_doc;

            }
            set
            {
                _id_doc = value;
            }
        }
        public override string ToString()
        {
            return "MEDICO " + this.id_doc + ", " + base.ToString();
        }

    }
}