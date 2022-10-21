    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="NorthwindLinq.Suppliers1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/mystyle.css" rel="stylesheet" />
    <center>
        <h3>SUPPLIERS</h3>
    </center>
    <br />
    <center>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">SupplierID::</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtSupplierID_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Company Name:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtCompanyName_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Contact Name:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtContactName_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Contact Title:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtConcatTitle_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Address:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtAdress_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">City:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtCity_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Region:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtRegion_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Postal Code:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtPostal_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Country:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtCountry_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Phone:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtPhone_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Fax:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtFax_Sup" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Home Page:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtHomePage_Sup" CssClass="form-control" />
        </p>
        <p>
            <br />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Agregar" runat="server" ID="btnAgregarSupplier" OnClick="btnAgregarSupplier_Click" Height="69px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Eliminar" runat="server" ID="btnEliminarSupplier" OnClick="btnEliminarSupplier_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Editar" runat="server" ID="btnEditarSupplier" OnClick="btnEditarSupplier_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Proyeccion" runat="server" ID="btnProyeccion2" OnClick="btnProyeccion2_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Expresiones Lambda" runat="server" ID="btnExpLambda2" OnClick="btnExpLambda2_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Clase Parcial" runat="server" ID="btnClaseParcial2" OnClick="btnClaseParcial2_Click" Height="68px" />
            <br />
        </p>
        <br />
        <br />
        <p>
            <asp:GridView runat="server" ID="gvSuppliers" CssClass="table table-borderless table-hover"></asp:GridView>
        </p>
    </center>
</asp:Content>
