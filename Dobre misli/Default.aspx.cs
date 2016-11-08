using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        TextBox tb = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {
            misli.Controls.Add(tb);
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "\r\n" + misel.Text;
            
        }

        protected void misel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}