<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPropietario.aspx.cs" Inherits="SADI.ResgistrarPropietario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click">Cerrar Sesion</asp:LinkButton>
        <br />
    
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="* Nombre requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Apellido:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="* Apellido requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Cedula:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCedula" ErrorMessage="* Cedula requerida" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtCedula" ErrorMessage="* Debe ingresar una cedula valida" ForeColor="Red" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="* La cedula no es valida" Visible="False"></asp:Label>
        <br />
        <br />
        Direccion<br />
        <br />
        Provincia:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" Width="126px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="* Provincia requerida" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
        <br />
        <br />
        Municipio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMunicipio" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlMunicipio_SelectedIndexChanged" Width="122px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlMunicipio" ErrorMessage="* Municipio requerido" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
        <br />
        <br />
        Sector:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlSector" runat="server" AutoPostBack="True" Width="124px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlSector" ErrorMessage="* Sector requerido" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
        <br />
        <br />
        Calle:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCalle" ErrorMessage="* Calle requerida" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Numero:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtNumero" ErrorMessage="* Numero requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Telefono 1:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefono1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtTelefono1" ErrorMessage="* Telefono Requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTelefono1" ErrorMessage="* Debe ingresar un numero de telefono valido" ForeColor="Red" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
        <br />
        <br />
        Telefono 2:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefono2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtTelefono2" ErrorMessage="* Debe ingresar un numero de telefono valido" ForeColor="Red" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
        <br />
        <br />
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="* Debe ingresar un Email valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    
    </div>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" style="width: 78px" Text="Registrar" />
    &nbsp;&nbsp;
    </form>
</body>
</html>
