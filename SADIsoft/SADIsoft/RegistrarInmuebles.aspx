<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarInmuebles.aspx.cs" Inherits="SADI.RegistrarInmuebles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cerrar Sesion</asp:LinkButton>
    
        <br />
        Registrar Inmuebles<br />
        <br />
        Seleccione propietario:&nbsp;
        <asp:DropDownList ID="ddlPropietario" runat="server" Height="23px" OnSelectedIndexChanged="ddlPropietario_SelectedIndexChanged" Width="148px">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlPropietario" ErrorMessage="* Debe seleccionar un propietario" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
        <br />
        <br />
        Direccion<br />
        <br />
        Provincia:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" Height="28px" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" Width="190px">
        </asp:DropDownList>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="* Campo requerido" ForeColor="Red" InitialValue="-Seleccione-"></asp:RequiredFieldValidator>
        <br />
        <br />
        Municipio:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMunicipio" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlMunicipio_SelectedIndexChanged" Width="188px">
        </asp:DropDownList>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlMunicipio" ErrorMessage="* Campo requerido" ForeColor="Red" InitialValue="-Seleccione-"></asp:RequiredFieldValidator>
        <br />
        <br />
        Sector:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlSector" runat="server" AutoPostBack="True" Height="16px" Width="186px">
        </asp:DropDownList>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlSector" ErrorMessage="* Campo requerido" ForeColor="Red" InitialValue="-Seleccione-"></asp:RequiredFieldValidator>
        <br />
        <br />
        Calle:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCalle" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Numero:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtNumero" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <br />
        Tipo:
        <asp:RadioButton ID="rbAlquiler" runat="server" AutoPostBack="True" Checked="True" GroupName="tipo" Text="Alquiler" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbVenta" runat="server" AutoPostBack="True" GroupName="tipo" Text="Venta" />
        <br />
        <br />
        Precio Alquiler:&nbsp;  <asp:TextBox ID="txtPrecioAlquiler" runat="server"></asp:TextBox>
        <br />
        <br />
       Depositos:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlDepositos" runat="server">
            <asp:ListItem>-Seleccione-</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlDepositos" ErrorMessage="* Campo requerido" InitialValue="-Seleccione-" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;Precio Venta:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrecioVenta" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        Niveles:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlNiveles" runat="server">
            <asp:ListItem>-Seleccione-</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlNiveles" ErrorMessage="* Campo requerido" InitialValue="-Seleccione-" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Tipo de Inmueble:&nbsp;&nbsp;
        <asp:RadioButton ID="rbVivienda" runat="server" Checked="True" GroupName="TipoInmueble" Text="Vivienda" />
&nbsp;&nbsp;
        <asp:RadioButton ID="rbLocal" runat="server" GroupName="TipoInmueble" Text="Local Comercial" />
        <br />
        <br />
        Habitaciones:&nbsp;
        <asp:DropDownList ID="ddlHabitaciones" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="ddlHabitaciones" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Baños:&nbsp;
        <asp:DropDownList ID="ddlBanos" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="ddlBanos" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:CheckBox ID="cbSotano" runat="server" Text="Sotano" />
        <br />
        <asp:CheckBox ID="cbPiscina" runat="server" Text="Piscina" />
        <br />
        <asp:CheckBox ID="cbMarquesina" runat="server" AutoPostBack="True" Text="Marquesina/ Parqueo" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad de Vehiculos:&nbsp;
        <asp:DropDownList ID="ddlCapacidadMarquesina" runat="server" Enabled="False">
            <asp:ListItem>-Seleccione-</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Comentarios: <asp:TextBox ID="txtComentarios" runat="server" Height="58px" TextMode="MultiLine" Width="308px"></asp:TextBox>
        <br />
        <br />
        Fotos       <br />
        Foto 1:&nFoto 1:&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="FileUpload1" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Foto 2:&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload2" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="FileUpload2" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Foto 3:&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload3" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="FileUpload3" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Foto 4:&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload4" runat="server" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="FileUpload4" ErrorMessage="* Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
