using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NorthwindLinq
{
    public partial class Products1 : System.Web.UI.Page
    {
        NorthWindDataContext dbNorhWind = new NorthWindDataContext();

        private IList<Products> Listar()
        {
            var consulta = from V in dbNorhWind.Products
                            select V;
            return consulta.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvProducts.DataSource = Listar();
                gvProducts.DataBind();
            }


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Products products= new Products();
            products.ProductName = txtNombreProducto.Text;
            products.SupplierID = int.Parse(txtSupplierID.Text);
            products.CategoryID = int.Parse(txtCategoryID.Text);
            products.QuantityPerUnit = txtQuantityUnit.Text;
            products.UnitPrice = int.Parse(txtUnitPrice.Text);
            products.UnitsInStock = byte.Parse(txtStock.Text);
            products.UnitsOnOrder = byte.Parse(txtUnitsOnOrder.Text);
            products.ReorderLevel = byte.Parse(txtReorderLevel.Text);
            products.Discontinued = chkDiscontinued.Checked;

            dbNorhWind.Products.InsertOnSubmit(products);
            try
            {
                dbNorhWind.SubmitChanges();
                gvProducts.DataSource = Listar();
                gvProducts.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("ERROR:"+segs.Message);
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Products products = dbNorhWind.Products.Single(V => V.ProductID == int.Parse(txtIdProduct.Text));
            products.ProductName = txtNombreProducto.Text;
            products.SupplierID = int.Parse(txtSupplierID.Text);
            products.CategoryID = int.Parse(txtCategoryID.Text);
            products.QuantityPerUnit = txtQuantityUnit.Text;
            products.UnitPrice = int.Parse(txtUnitPrice.Text);
            products.UnitsInStock = byte.Parse(txtStock.Text);
            products.UnitsOnOrder = byte.Parse(txtUnitsOnOrder.Text);
            products.ReorderLevel = byte.Parse(txtReorderLevel.Text);
            products.Discontinued = chkDiscontinued.Checked;
            try
            {
                dbNorhWind.SubmitChanges();
                gvProducts.DataSource = Listar();
                gvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            var ProductoEliminado = (from P in dbNorhWind.Products
                                    where P.ProductID.Equals(txtIdProduct.Text.ToString())
                                    select P).First();
            dbNorhWind.Products.DeleteOnSubmit(ProductoEliminado);
            try
            {
                dbNorhWind.SubmitChanges();
                gvProducts.DataSource = Listar();
                gvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
        protected void btnProyeccion_Click(object sender, EventArgs e)
        {
            var consulta = from P in dbNorhWind.Products
                           group P by P.Suppliers.SupplierID into S
                           select new
                           {
                               SupplierID = S.Key,
                               Total = S.Sum(P=> P.UnitPrice * P.UnitsInStock)
                           };

            try
            {

                gvProducts.DataSource = consulta;
                gvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
        protected void btnExpLambda1_Click(object sender, EventArgs e)
        {
            var consulta = dbNorhWind.Products.Where(P => P.UnitsInStock < 4);

            try
            {

                gvProducts.DataSource = consulta;
                gvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnClaseParcial1_Click(object sender, EventArgs e)
        {
            var consulta = from P in dbNorhWind.Products
                           select new
                           {
                               Codigo = P.ProductID,
                               Datos = P.DescripcionProducto()

                           };
            
            try
            {

                gvProducts.DataSource = consulta;
                gvProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void txtIdProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}