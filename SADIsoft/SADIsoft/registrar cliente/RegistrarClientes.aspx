<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistrarClientes.aspx.cs" Inherits="SADIsoft.registrar_cliente.RegistrarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="form-horizontal" runat="server">
        <fieldset>

            <!-- Form Name -->
            <legend>Registrar Clientes</legend>

           <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Nombre</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNombre1" runat="server" type="text" class="form-control input-md" placeholder="Nombre" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Apellido</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtApellido1" runat="server" type="text" class="form-control input-md" placeholder="Apelllido" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Cedula</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtCedula1" runat="server" type="text" class="form-control input-md" placeholder="Cedula" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Direccion</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtDireccion1" runat="server" type="text" class="form-control input-md" placeholder="Direccion" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Telefono 1</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonos1" runat="server" type="text" class="form-control input-md" placeholder="Telefono1" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Telefono 2</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtTelefonos2" runat="server" type="text" class="form-control input-md" placeholder="Telefono Opcional" required ></asp:TextBox>
                   
                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textCalle">Email</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmail1" runat="server" type="text" class="form-control input-md" placeholder="Email" required ></asp:TextBox>
                   
                </div>
            </div>

           <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="btnRegistrarr"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnRegistrarCliente" runat="server" Text="Registrar Cliente" class="btn btn-primary" OnClick="btnRegistrarCliente_Click"/>
                </div>
            </div>


        </fieldset>
    </form>

</asp:Content>
