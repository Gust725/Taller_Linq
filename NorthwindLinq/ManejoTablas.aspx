    <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManejoTablas.aspx.cs" Inherits="NorthwindLinq.ManejoTablas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/mystyle.css" rel="stylesheet" />
    <center>
        <h3>VISTAS</h3>
    </center>
    <br />
    <center>
        <asp:Button CssClass="btn btn-primary btn-lg" Text="InnerJoin1" runat="server" ID="btnIJ1" Height="65px" OnClick="btnIJ1_Click"/>
        <asp:Button CssClass="btn btn-primary btn-lg" Text="InnerJoin2" runat="server" ID="btnIJ2" Height="65px" OnClick="btnIJ2_Click"/>
        <asp:Button CssClass="btn btn-primary btn-lg" Text="InnerJoin3" runat="server" ID="btnIJ3" Height="65px" OnClick="btnIJ3_Click"/>
        <asp:Button CssClass="btn btn-primary btn-lg" Text="InnerJoin4" runat="server" ID="btnIJ4" Height="65px" OnClick="btnIJ4_Click"/>


        <br />
        <br />
        <p>
            <asp:GridView runat="server" ID="gvInnerJoin" CssClass="table table-borderless table-hover"></asp:GridView>
        </p>
    </center>
</asp:Content>
