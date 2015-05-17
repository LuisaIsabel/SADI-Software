<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="PropietariosReg.aspx.cs" Inherits="SADIsoft.propietarios_registrados.PropietariosReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="form-horizontal" runat="server">
        <fieldset>
            <!-- Form Name -->
            <legend>Propietarios Registrados</legend>

              <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textTele">Telefono 1</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonops1" runat="server" type="text" class="form-control input-md" placeholder="Telefono" required ></asp:TextBox>
                   
                </div>
            </div>

              <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textTelefono2">Telefono 2</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonos2" runat="server" type="text" class="form-control input-md" placeholder="Email" required ></asp:TextBox>
                   
                </div>
            </div>

             <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textEmail">Email</label>
                <div class="col-md-4">
                    <asp:TextBox ID="TextEmail" runat="server" type="text" class="form-control input-md" placeholder="Email" required ></asp:TextBox>
                   
                </div>
            </div>
                  <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="label"></label>
                <div class="col-md-4">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
            </div>
             <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="btnRegistrarr"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnActualizarP" runat="server" Text="Actualizar" class="btn btn-primary" OnClick="btnActualizarP_Click"/>
                </div>
            </div>


              <!-- Text input-->
            <div class="form-group">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
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
INNER JOIN Sectores AS S ON D.SectorId = S.SectorId"></asp:SqlDataSource>

            </div>

            
        </fieldset>
    </form>
</asp:Content>
