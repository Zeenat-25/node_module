using System;

namespace CachingPractical
{
    public partial class MovieTicket : System.Web.UI.Page
    {
        protected void btnOK_Click(object sender, EventArgs e)
        {
            Session["Theatre"] = ListBox1.SelectedItem.Text;

            Response.Redirect("ResponseMovie.aspx");
        }
    }
}