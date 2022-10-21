using NorthwindLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindLinq
{
    public partial class Suppliers1 : System.Web.UI.Page
    {
        NorthWindDataContext dbNortWind = new NorthWindDataContext();

        private IList<Suppliers> Listar()
        {
            var list = from Sup in dbNortWind.Suppliers
                       select Sup;
            return list.ToList();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvSuppliers.DataSource = Listar();
                gvSuppliers.DataBind();
              
            }

          
        }

        private void LlenarDropDownList()
        {
           /* var consulta = (from S in ventas.Producto
                            select new
                            {
                                P.UnidadMedida
                            }).Distinct();
            cboUnidad.DataSource = consulta;
            cboUnidad.ValueMember = "UnidadMedida";*/
        }

        protected void btnAgregarSupplier_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.CompanyName = txtCompanyName_Sup.Text;
            suppliers.ContactName = txtContactName_Sup.Text;
            suppliers.ContactTitle = txtConcatTitle_Sup.Text;
            suppliers.Address = txtAdress_Sup.Text;
            suppliers.Region = txtRegion_Sup.Text;
            suppliers.PostalCode = txtPostal_Sup.Text;
            suppliers.Country = txtCountry_Sup.Text;
            suppliers.Phone = txtPhone_Sup.Text;
            suppliers.Fax = txtFax_Sup.Text;
            suppliers.HomePage = txtHomePage_Sup.Text;

            dbNortWind.Suppliers.InsertOnSubmit(suppliers);
            try
            {
                dbNortWind.SubmitChanges();
                gvSuppliers.DataSource = Listar();
                gvSuppliers.DataBind();
            }catch(Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnEliminarSupplier_Click(object sender, EventArgs e)
        {
            var SupplierEliminado = (from S in dbNortWind.Suppliers where S.SupplierID.Equals(txtSupplierID_Sup.Text.ToString()) select S).First();
            dbNortWind.Suppliers.DeleteOnSubmit(SupplierEliminado);
            try
            {
                dbNortWind.SubmitChanges();
                gvSuppliers.DataSource = Listar();
                gvSuppliers.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnEditarSupplier_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = dbNortWind.Suppliers.Single(S => S.SupplierID == int.Parse(txtSupplierID_Sup.Text));
            suppliers.CompanyName = txtCompanyName_Sup.Text;
            suppliers.ContactName = txtContactName_Sup.Text;
            suppliers.ContactTitle = txtConcatTitle_Sup.Text;
            suppliers.Address = txtAdress_Sup.Text;
            suppliers.Region = txtRegion_Sup.Text;
            suppliers.PostalCode = txtPostal_Sup.Text;
            suppliers.Country = txtCountry_Sup.Text;
            suppliers.Phone = txtPhone_Sup.Text;
            suppliers.Fax = txtFax_Sup.Text;
            suppliers.HomePage = txtHomePage_Sup.Text;
            try
            {
                dbNortWind.SubmitChanges();
                gvSuppliers.DataSource = Listar();
                gvSuppliers.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnProyeccion2_Click(object sender, EventArgs e)
        {
            var consulta = from S in dbNortWind.Suppliers
                           select new
                           {
                               S.CompanyName,
                               S.Address,
                               S.City
                           };

            try
            {

                gvSuppliers.DataSource = consulta;
                gvSuppliers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        

        protected void btnClaseParcial2_Click(object sender, EventArgs e)
        {
            var consulta = from S in dbNortWind.Suppliers
                           select new
                           {
                               Codigo = S.SupplierID,
                               Datos = S.DescripcionSuppliers()

                           };

            try
            {

                gvSuppliers.DataSource = consulta;
                gvSuppliers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnExpLambda2_Click(object sender, EventArgs e)
        {
            var consulta = dbNortWind.Suppliers.Where(S => S.City != "Sao Paulo");
           

            try
            {

                gvSuppliers.DataSource = consulta;
                gvSuppliers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}