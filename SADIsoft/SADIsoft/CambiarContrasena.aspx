<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="SADI.CambiarContrasena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cambie su contraseña<br />
        <br />
        <br />
        Ingrese su Nueva contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtContrasena" ErrorMessage="RequiredFieldValidator" ForeColor="Red">* Este campo en requerido</asp:RequiredFieldValidator>
        <br />
        <br />
        Introduzca nuevamente la contraseña:&nbsp;&nbsp;
        <asp:TextBox ID="txtContrasena1" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContrasena1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">* Este campo en requerido</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtContrasena" ControlToValidate="txtContrasena1" ErrorMessage="CompareValidator" ForeColor="Red">* Las contraseñas no coinciden</asp:CompareValidator>
        <br />
    
    </div>
        <asp:Button ID="btnListo" runat="server" OnClick="btnListo_Click" Text="Listo" />
    </form>
</body>
</html>
