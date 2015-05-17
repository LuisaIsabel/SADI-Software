<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="SADIsoft.registrar_usuario.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form class="form-horizontal" runat="server">
        <fieldset>
            <!-- Form Name -->
            <legend>Registrar Usuario</legend>

              <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="textEmail">Email</label>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEmail1" runat="server" type="text" class="form-control input-md" placeholder="Email" required ></asp:TextBox>
                   
                </div>
            </div>

             <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="btnRegistrarr"></label>
                <div class="col-md-4">
                    <asp:Button ID="btnRegistrarUsuario" runat="server" Text="Registrar Usuario" class="btn btn-primary" OnClick="btnRegistrarUsuario_Click"/>
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>
