<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="NorthwindLinq.Products1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/mystyle.css" rel="stylesheet" />
    <center>
        <h3>PRODUCTS</h3>
    </center>
    <br />
    <center>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">ID:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtIdProduct" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Product Name:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">SupplierID:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtSupplierID" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">CategoryID:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtCategoryID" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Quantity Unit:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtQuantityUnit" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Unit Price:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtUnitPrice" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Stock:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtStock" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Units on Order:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtUnitsOnOrder" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Reorder Level:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtReorderLevel" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Discontinued:</asp:Label>
            <br />
            <asp:CheckBox runat="server" ID="chkDiscontinued" CssClass="form-control" />
        </p>
        <p>
            <br />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Editar" runat="server" ID="btnEditar" OnClick="btnEditar_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Proyeccion" runat="server" ID="btnProyeccion" OnClick="btnProyeccion_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Expresiones Lambda" runat="server" ID="btnExpLambda1" OnClick="btnExpLambda1_Click" Height="68px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Clase Parcial" runat="server" ID="btnClaseParcial1" OnClick="btnClaseParcial1_Click" Height="68px" />
            <br />
        </p>
        <br />
        <br />
        <p>
            <asp:GridView runat="server" ID="gvProducts" CssClass="table table-borderless table-hover"></asp:GridView>
        </p>
    </center>
</asp:Content>
    
