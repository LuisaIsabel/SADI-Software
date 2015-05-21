<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContratoLitis.aspx.cs" Inherits="SADIsoft.ContratoLitis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Seleccione propietario:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlPropietario1" runat="server" AutoPostBack="True"></asp:DropDownList>
        <br /><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Generar Contrato" />
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
