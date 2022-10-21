using NorthwindLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindLinq
{
    public partial class Shippers1 : System.Web.UI.Page
    {
        NorthWindDataContext dbNorhWind = new NorthWindDataContext();

        private IList<Shippers> Listar()
        {
            var consulta = from V in dbNorhWind.Shippers
                           select V;
            return consulta.ToList();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvShippers.DataSource = Listar();
                gvShippers.DataBind();
            }
        }

        protected void btnAgregarShip_Click(object sender, EventArgs e)
        {
            Shippers shippers = new Shippers();
            shippers.CompanyName = txtCompanyName.Text;
            shippers.Phone = txtPhone.Text;
            dbNorhWind.Shippers.InsertOnSubmit(shippers);
            try
            {
                dbNorhWind.SubmitChanges();
                gvShippers.DataSource = Listar();
                gvShippers.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnEliminarShip_Click(object sender, EventArgs e)
        {

            var ShipperEliminado = (from S in dbNorhWind.Shippers where S.ShipperID.Equals(txtShipperID.Text.ToString()) select S).First();
            dbNorhWind.Shippers.DeleteOnSubmit(ShipperEliminado);
            try
            {
                dbNorhWind.SubmitChanges();
                gvShippers.DataSource = Listar();
                gvShippers.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnEditarShip_Click(object sender, EventArgs e)
        {
            Shippers shippers = dbNorhWind.Shippers.Single(S => S.ShipperID == int.Parse(txtShipperID.Text));
            shippers.CompanyName = txtCompanyName.Text;
            shippers.Phone = txtPhone.Text;
            try
            {
                dbNorhWind.SubmitChanges();
                gvShippers.DataSource = Listar();
                gvShippers.DataBind();
            }
            catch (Exception segs)
            {
                Response.Write("Error: " + segs.Message);
            }
        }

        protected void btnProyeccion3_Click(object sender, EventArgs e)
        {
            var consulta = from S in dbNorhWind.Shippers
                           select new
                           {
                               S.CompanyName
                           };

            try
            {

                gvShippers.DataSource = consulta;
                gvShippers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnExpLambda3_Click(object sender, EventArgs e)
        {
            var consulta = dbNorhWind.Shippers.Where(S => S.CompanyName == "Speedy Express");
            try
            {

                gvShippers.DataSource = consulta;
                gvShippers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnClaseParcial3_Click(object sender, EventArgs e)
        {
            var consulta = from S in dbNorhWind.Shippers
                           select new
                           {
                               Codigo = S.ShipperID,
                               Datos = S.DescripcionShippers()

                           };

            try
            {

                gvShippers.DataSource = consulta;
                gvShippers.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}