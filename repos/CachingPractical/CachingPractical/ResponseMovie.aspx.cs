using System;
using System.Web.UI.WebControls;

namespace CachingPractical
{
    public partial class ResponseMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string theatre = Convert.ToString(Session["Theatre"]);

            if (Cache[theatre] == null)
            {
                TableRow row = new TableRow();

                row.Cells.Add(new TableCell { Text = "Show Timings" });
                row.Cells.Add(new TableCell { Text = "9:00 AM" });
                row.Cells.Add(new TableCell { Text = "12:00 PM" });
                row.Cells.Add(new TableCell { Text = "5:00 PM" });

                Table1.Rows.Add(row);

                Cache.Insert(
                    theatre,
                    Table1,
                    null,
                    DateTime.Now.AddSeconds(30),
                    TimeSpan.Zero);
            }
            else
            {
                Response.Write("Reading From Cache");
            }
        }
    }
}