<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistrarInmuebles.aspx.cs" Inherits="SADIsoft.registrar_inmueble.RegistrarInmuebles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="form-horizontal" runat="server">
        <fieldset>
            <!-- Form Name -->
            <legend>Registrar Inmueble</legend>
            
             <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textPripietario">Seleccione el Propietario</label>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlPropietario1" runat="server" class="form-control" OnSelectedIndexChanged="ddlPropietario1_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textDireccion">Direccion</label>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textProvincia">Provincia</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlProvincia1" runat="server" class="form-control" OnSelectedIndexChanged="ddlProvincia1_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textNunicio">Municipio</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlMunicipio1" runat="server" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlMunicipio1_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textSector">Sector</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlSector1" runat="server" class="form-control" AutoPostBack="True"></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Calle</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCalle1" runat="server" type="text" class="form-control input-md" placeholder="Calle" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textNumero">Numero</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumero1" runat="server" type="text" class="form-control input-md" placeholder="Numero" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textTipo">Tipo</label>
                <div class="col-md-4"> 
                    <asp:RadioButton ID="rbAlquiler1" runat="server" GroupName="tipo" Text="Alquiler" AutoPostBack="True" />
                    <asp:RadioButton ID="rbVenta1" runat="server" GroupName="tipo" Text="Venta" AutoPostBack="True" />
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textAlquilerP">Precio Alquiler</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtPrecioAlquiler1" runat="server" type="text" class="form-control input-md" placeholder="Precio Alquiler" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textDeposito">Depositos</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlDepositos1" runat="server" class="form-control">
                        <asp:ListItem>-Seleccione-</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textPrecioV">Precio Venta</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtPrecioVenta1" runat="server" type="text" class="form-control input-md" placeholder="Precio Venta" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textNiveles">Niveles</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlNiveles1" runat="server" class="form-control">
                        <asp:ListItem>-Seleccione-</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textTipoIn">Tipo Inmueble</label>
                <div class="col-md-4"> 
                    <asp:RadioButton ID="rbVivienda1" runat="server" GroupName="tipoInmueble" Text="Vivienda" />
                    <asp:RadioButton ID="rbLocal1" runat="server" GroupName="tipoInmueble" Text="Local Comercial" />
                </div>
            </div>

             <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textHabitaciones">Habitaciones</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlHabitaciones1" runat="server" class="form-control">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

             <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textBanios">Baños</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlBanos1" runat="server" class="form-control">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textoption"></label>
                <div class="col-md-4">
                    <asp:CheckBox ID="cbSotano1" runat="server" Text="Sotano" />
                    <asp:CheckBox ID="cbPiscina1" runat="server" Text="Pisina" />
                    <asp:CheckBox ID="cbMarquesina1" runat="server" Text="Marquesina" />
                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="textNombre">Cantidad Vehiculos</label>
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlCapacidadMarquesina1" runat="server" class="form-control" Width="280px">
                                <asp:ListItem >-Seleccione-</asp:ListItem>
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textarea">Comentario</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtComentarios1" runat="server" Height="58px" TextMode="MultiLine" Width="308px"></asp:TextBox>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textfoto1">Fotos</label>
            </div>

            <!-- File Button --> 
            <div class="form-group">
                <label class="col-md-4 control-label" for="filebutton">Imagen 1</label>
                <div class="col-md-4">
                    <asp:FileUpload ID="FileUpload1" runat="server" class="input-file" type="file" />
                </div>
            </div>

            <!-- File Button --> 
            <div class="form-group">
                <label class="col-md-4 control-label" for="filebutton">Imagen 2</label>
                <div class="col-md-4">
                    <asp:FileUpload ID="FileUpload2" runat="server" class="input-file" type="file" />
                </div>
            </div>

            <!-- File Button --> 
            <div class="form-group">
                <label class="col-md-4 control-label" for="filebutton">Imagen 3</label>
                <div class="col-md-4">
                    <asp:FileUpload ID="FileUpload3" runat="server" class="input-file" type="file" />
                </div>
            </div>

            <!-- File Button --> 
            <div class="form-group">
                <label class="col-md-4 control-label" for="filebutton">Imagen 4</label>
                <div class="col-md-4">
                    <asp:FileUpload ID="FileUpload4" runat="server" class="input-file" type="file" />
                </div>
            </div>

            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="btnRegistrarr"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnRegistrar1" runat="server" Text="Registrar" class="btn btn-primary" OnClick="btnRegistrar1_Click" />
                </div>
            </div>



        </fieldset>
    </form>
</asp:Content>
