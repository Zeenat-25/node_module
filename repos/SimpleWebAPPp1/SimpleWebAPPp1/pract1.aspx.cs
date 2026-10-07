using System;

namespace SimpleWebAPPp1
{
    public partial class Pract1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Name: " + txtname.Text + "<br>");
            Response.Write("Contact: " + txtcontact.Text + "<br>");
            Response.Write("Location: " + lstlocation.SelectedItem.Text + "<br>");

            if (male.Checked)
                Response.Write("Gender: Male<br>");

            if (female.Checked)
                Response.Write("Gender: Female<br>");

            Response.Write("Education: ");

            if (ssc.Checked)
                Response.Write("SSC ");

            if (hsc.Checked)
                Response.Write("HSC ");

            if (graduate.Checked)
                Response.Write("Graduate");
        }
    }
}