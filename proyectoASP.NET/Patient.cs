using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoASP.NET
{
    public class Patient : Persona
    {
        private int _id_patient;
        private int _id_asigned_doc;

        public Patient(String dni, String name, String surname, int id, int id_doc) : base(dni, name, surname)
        {
            _id_patient = id;
            _id_asigned_doc = id_doc;
        }

        public int id_patient
        {
            get
            {
                return _id_patient;
            }
            set
            {
                _id_patient = value;
            }
        }
        public int id_asigned_doc
        {
            get
            {
                return _id_asigned_doc;
            }
            set
            {
                _id_asigned_doc = value;
            }
        }
        public override string ToString()
        {
            return "PACIENTE " + this.id_patient + ", " + base.ToString() + ", " + this.id_asigned_doc;
        }
    }
}