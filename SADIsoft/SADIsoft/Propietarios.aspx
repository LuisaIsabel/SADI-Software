<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Propietarios.aspx.cs" Inherits="SADI.Propietarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cerrar Sesion</asp:LinkButton>
        <br />
    
        Propietarios Registrados<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <div style="text-align: left">
            Telefono1:&nbsp; <asp:TextBox ID="txtTelefono1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Telefono 2:&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            Email:&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
        </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" EnableSortingAndPagingCallbacks="True">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" SortExpression="Cedula" />
                <asp:BoundField DataField="Telefono1" HeaderText="Telefono1" SortExpression="Telefono1" />
                <asp:BoundField DataField="Telefono2" HeaderText="Telefono2" SortExpression="Telefono2" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Direccion_Calle" HeaderText="Direccion_Calle" SortExpression="Direccion_Calle" />
                <asp:BoundField DataField="Direccion_Numero" HeaderText="Direccion_Numero" SortExpression="Direccion_Numero" />
                <asp:BoundField DataField="Provincia" HeaderText="Provincia" SortExpression="Provincia" />
                <asp:BoundField DataField="Municipio" HeaderText="Municipio" SortExpression="Municipio" />
                <asp:BoundField DataField="Sector" HeaderText="Sector" SortExpression="Sector" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SadiConnectionString %>" SelectCommand="SELECT 
     P.PropietarioId AS ID, 
     P.Nombre,
     P.Apellido,
     P.Cedula, 
     P.Telefono1, 
     P.Telefono2, 
     U.NombreUsuario AS Email,
     D.Calle AS Direccion_Calle, 
     D.Numero AS Direccion_Numero, 
     Pr.Nombre AS Provincia, 
     M.Nombre AS Municipio, 
     S.Nombre AS Sector
FROM Propietarios AS P
LEFT JOIN Usuarios AS U ON p.UsuarioId = U.UsuarioId 
INNER JOIN Direcciones AS D ON P.DireccionId = D.DireccionId 
INNER JOIN Provincias AS Pr ON D.ProvinciaId = Pr.ProvinciaId
INNER JOIN Municipios AS M ON D.MunicipioId = M.MunicipioId
INNER JOIN Sectores AS S ON D.SectorId = S.SectorId" UpdateCommand="USP_Actualizar_Propietario" UpdateCommandType="StoredProcedure">
            <UpdateParameters>
                <asp:Parameter Name="PropietarioID" Type="Int32" />
                <asp:Parameter Name="Tel1" Type="String" />
                <asp:Parameter Name="Tel2" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/ResgistrarPropietario.aspx" style="text-align: center" Text="Volver a la pagina de Registro de Propietarios" UseSubmitBehavior="False" />
&nbsp;</div>
    </form>
</body>
</html>
