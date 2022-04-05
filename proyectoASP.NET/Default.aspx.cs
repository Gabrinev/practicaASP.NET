using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoASP.NET
{
    
    public partial class _Default : Page
    {
        public static List<Patient> patlist;
        public static List<Medico> doclist;

        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!Page.IsPostBack)
            {
                

            }

        }
        public static void initLists()
        {
            patlist = new List<Patient>();
            doclist = new List<Medico>();

        }

        public static void addPat(Patient p)
        {
            patlist.Add(p);

        }

        protected void btnDocsList_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            foreach (Medico m in doclist)
            {
                ListBox1.Items.Add(m.ToString());
            }
        }

        protected void btnAllList_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            foreach (Medico m in doclist)
            {
                ListBox1.Items.Add(m.ToString());
            }
            

            foreach (Patient p in patlist)
            {
                ListBox1.Items.Add(p.ToString());
            }
            
        }
    }
}