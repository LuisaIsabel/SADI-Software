<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistrarPropietarios.aspx.cs" Inherits="SADIsoft.registrar_propietarios.RegistrarPropietarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form class="form-horizontal" runat="server">
        <fieldset>

            <!-- Form Name -->
            <legend>Registrar Propietarios</legend>

           <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Nombre</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombreP" runat="server" type="text" class="form-control input-md" placeholder="Nombre" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Apellido</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellidoP" runat="server" type="text" class="form-control input-md" placeholder="Apelllido" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Cedula</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCedulaP" runat="server" type="text" class="form-control input-md" placeholder="Cedula" required ></asp:TextBox>
                   
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
                    <asp:DropDownList ID="ddlProvinciaP" runat="server" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaP_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textNunicio">Municipio</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlMunicipioP" runat="server" class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlMunicipioP_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textSector">Sector</label>
                <div class="col-md-4"> 
                    <asp:DropDownList ID="ddlSectorP" runat="server" class="form-control" AutoPostBack="True"></asp:DropDownList>
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Calle</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCalleP" runat="server" type="text" class="form-control input-md" placeholder="Calle" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textNumero">Numero</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumeroP" runat="server" type="text" class="form-control input-md" placeholder="Numero" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Telefono 1</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonos1P" runat="server" type="text" class="form-control input-md" placeholder="Telefono1" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Telefono 2</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonos2P" runat="server" type="text" class="form-control input-md" placeholder="Telefono Opcional" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Email</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmail1P" runat="server" type="text" class="form-control input-md" placeholder="Email" required ></asp:TextBox>
                   
                </div>
            </div>

           <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="btnRegistrarr"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnRegistrarPropietario" runat="server" Text="Registrar Propietario" class="btn btn-primary" OnClick="btnRegistrarPropietario_Click"/>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="* La cedula no es valida" Visible="False"></asp:Label>
                </div>
            </div>


        </fieldset>
    </form>


</asp:Content>
