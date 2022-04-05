using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoASP.NET
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Patient temp = new Patient(txtDni.Text, txtName.Text, txtApellido.Text, Convert.ToInt32(txtIdPat.Text), Convert.ToInt32(txtIdDoc.Text));
            _Default.initLists();
            _Default.addPat(temp);
        }
    }
}