<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginResponse.aspx.cs" Inherits="SADIsoft.LoginResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-type" content="text/html" charset="utf-8" />
    <meta http-equiv="X-US-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="stilo/estilos.css" rel="stylesheet" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css"/>

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>

    <title></title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-6 col-md-4 col-md-offset-4">
                <h1 class="text-center login-title">Iniciar Seccion en SADI</h1>
                <div class="account-wall">
                    <img class="profile-img" src="logo/lo.jpg"
                        alt=""/>
                    <form class="form-signin" runat="server">
                        <asp:TextBox ID="textUsuarios" runat="server" type="text" class="form-control" placeholder="Email" required autofocus ></asp:TextBox>
                        <asp:TextBox ID="textContrase" runat="server" type="password" class="form-control" placeholder="Password" required ></asp:TextBox>
                        <asp:Button ID="btnIniciar" runat="server" class="btn btn-lg btn-primary btn-block" Text
                            ="Iniciar Seccion" OnClick="btnIniciar_Click"/>
                        <label class="checkbox pull-left">
                            <input type="checkbox" value="remember-me"/>
                                Recordar Contraseña
                        </label>
                        <a href="#" class="pull-right need-help">SADI </a><span class="clearfix"></span>
                    </form>
                </div>
                <a href="#" class="text-center new-account">Create an account </a>
            </div>
        </div>
    </div>
</body>
</html>
