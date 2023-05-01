<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ProyectoFinal_BDII.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://fonts.googleapis.com/css?family=Roboto:300,400&display=swap" rel="stylesheet"/>
<link rel="stylesheet" href="fonts/icomoon/style.css"/>
<link rel="stylesheet" href="css/owl.carousel.min.css"/>
<link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
<link href="Css/stylesLogin.css" rel="stylesheet" type="text/css" />
    <title>Login - Muebles los Alpes</title>
</head>
<body>
    <div class="d-lg-flex half">
    <div class="bg order-1 order-md-2" style="background-image: url('assets/img/login-bg.jpg');">
    </div>
    <div class="contents order-2 order-md-1">

      <div class="container" >
        <div class="row align-items-center justify-content-center">
          <div class="col-md-7">
            <h3>LOGIN <strong>MUEBLES LOS ALPES</strong></h3>
            <form action="#" method="post">
              <div class="form-group first">
                <label for="username">USUARIO</label>
                <input type="text" class="form-control" placeholder="USER123" id="username"/>
              </div>
              <div class="form-group last mb-3">
                <label for="password">CONTRASEÑA</label>
                <input type="password" class="form-control" placeholder="******" id="password"/>
              </div>
                <input type="submit" value="INGRESAR" class="btn btn-outline-warning"/>
            </form>
          </div>
        </div>
      </div>
    </div>

    
  </div>
</body>
</html>
