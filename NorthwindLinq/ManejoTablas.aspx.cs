using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindLinq
{
    public partial class ManejoTablas : System.Web.UI.Page
    {
        NorthWindDataContext dbNorhWind = new NorthWindDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIJ1_Click(object sender, EventArgs e)
        {
            var consulta = from O in dbNorhWind.Orders
                           join E in dbNorhWind.Employees on O.EmployeeID equals E.EmployeeID
                           join C in dbNorhWind.Customers on O.CustomerID equals C.CustomerID
                           join OD in dbNorhWind.Order_Details on O.OrderID equals OD.OrderID
                           join P in dbNorhWind.Products on OD.ProductID equals P.ProductID
                           select new
                           {
                               O.OrderID,
                               P.ProductName,
                               E.LastName,
                               E.FirstName,
                               C.CompanyName,
                               C.ContactName,
                               C.Phone
                               

                           };
            gvInnerJoin.DataSource = consulta;
            gvInnerJoin.DataBind();
        }

        protected void btnIJ2_Click(object sender, EventArgs e)
        {
            var consulta = from P in dbNorhWind.Products
                           join OD in dbNorhWind.Order_Details on P.ProductID equals OD.ProductID
                           join O in dbNorhWind.Orders on OD.OrderID equals O.OrderID
                           join C in dbNorhWind.Customers on O.CustomerID equals C.CustomerID
                           select new
                           {
                               P.ProductID,
                               P.ProductName,
                               OD.UnitPrice,
                               C.CompanyName,
                               O.OrderDate
                           };
            gvInnerJoin.DataSource = consulta;
            gvInnerJoin.DataBind();
        }

        protected void btnIJ3_Click(object sender, EventArgs e)
        {
            var consulta = from S in dbNorhWind.Suppliers
                           join P in dbNorhWind.Products on S.SupplierID equals P.SupplierID
                           join C in dbNorhWind.Categories on P.CategoryID equals C.CategoryID
                           join OD in dbNorhWind.Order_Details on P.ProductID equals OD.ProductID
                           select new
                           {
                               P.ProductName,
                               S.CompanyName,
                               C.CategoryName,
                               OD.Quantity

                           };
            gvInnerJoin.DataSource = consulta;
            gvInnerJoin.DataBind();
        }

        protected void btnIJ4_Click(object sender, EventArgs e)
        {
            var consulta = from E in dbNorhWind.Employees
                           join ET in dbNorhWind.EmployeeTerritories on E.EmployeeID equals ET.EmployeeID
                           join T in dbNorhWind.Territories on ET.TerritoryID equals T.TerritoryID
                           join R in dbNorhWind.Region on T.RegionID equals R.RegionID
                           select new
                           {
                               E.FirstName,
                               E.LastName,
                               T.TerritoryDescription,
                               R.RegionDescription
                           };
            gvInnerJoin.DataSource = consulta;
            gvInnerJoin.DataBind();
        }
    }
}