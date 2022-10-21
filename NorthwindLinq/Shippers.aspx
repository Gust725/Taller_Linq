<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shippers.aspx.cs" Inherits="NorthwindLinq.Shippers1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/mystyle.css" rel="stylesheet" />
    <center>
        <h3>SHIPPERS</h3>
    </center>
    <br />
    <center>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">ShipperID AI:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtShipperID" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Company Name:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtCompanyName" CssClass="form-control" />
        </p>
        <p>
            <asp:Label runat="server" CssClass="form-label" ForeColor="#161BBE">Phone:</asp:Label>
            <br />
            <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control" />
        </p>
        <p>
            <br />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregarShip_Click" Height="66px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminarShip_Click" Height="66px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Editar" runat="server" ID="btnEditar" OnClick="btnEditarShip_Click" Height="66px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Proyeccion" runat="server" ID="btnProyeccion3" OnClick="btnProyeccion3_Click" Height="66px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Expresiones Lambda" runat="server" ID="btnExpLambda3" OnClick="btnExpLambda3_Click" Height="66px" />
            <asp:Button CssClass="btn btn-primary btn-lg" Text="Clase Parcial" runat="server" ID="btnClaseParcial3" OnClick="btnClaseParcial3_Click" Height="66px" />
            <br />
        </p>
        <br />
        <br />
        <p>
            <asp:GridView runat="server" ID="gvShippers" CssClass="table table-borderless table-hover"></asp:GridView>
        </p>
    </center>

</asp:Content>
