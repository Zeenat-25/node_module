using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace CARTApp
{
    public partial class Default : System.Web.UI.Page
    {
        ShoppingCart Cart
        {
            get
            {
                if (Session["Cart"] == null)
                    Session["Cart"] = new ShoppingCart();

                return (ShoppingCart)Session["Cart"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProductGridView.DataSource =
                    ProductRepository.GetProducts();

                ProductGridView.DataBind();
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            GridViewRow row = (GridViewRow)b.NamingContainer;

            int id = Convert.ToInt32(
                ProductGridView.DataKeys[row.RowIndex].Value);

            Product p = ProductRepository.GetProducts()
                .Find(x => x.ID == id);

            if (!Cart.Products.Any(x => x.ID == id))
                Cart.Products.Add(p);

            ShowCart();
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int id = Convert.ToInt32(b.CommandArgument);

            Cart.Products.RemoveAll(x => x.ID == id);

            ShowCart();
        }

        void ShowCart()
        {
            CartList.DataSource = Cart.Products;
            CartList.DataBind();
        }
    }
}