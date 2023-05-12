<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddEmpleado.aspx.vb" Inherits="ProyectoFinal_BDII.AddEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/styles.css" rel="stylesheet" type="text/css" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Añadir Empleado - Muebles los Alpes</title>
</head>
<body>
    <form runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark fixed-top bg-dark" id="mainNav">
            <div class="container">
                <a href="HomeAdmin.aspx" class="navbar-brand">
                    <img src="assets/img/navbar-logo.png" alt="..." /></a>

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    Menu
                    <i class="fas fa-bars ms-1"></i>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav text-uppercase ms-auto py-4">
                        <li><a href="../Empleados.aspx" style="text-decoration: none" class="navbar-text">Empleados</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        <section>
            <div class="mask d-flex align-items-center">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12">
                            <div class="card shadow-2-strong" style="background-color: #f5f7fa;">
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <div class="row ">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer01">ID EMPLEADO</label>
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                            <input type="text" class="form-control is-valid" id="validationServer01" placeholder="1" required="required" />
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer02">ROL</label>
                                                <input type="text" class="form-control is-valid" id="validationServer02" placeholder="Administrador" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer03">REGISTRO</label>
                                                <input type="text" class="form-control is-valid" id="validationServer03" placeholder="112233445" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer04">PRIMER NOMBRE</label>
                                                <input type="text" class="form-control is-valid" id="validationServer04" placeholder="Juan" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer05">SEGUNDO NOMBRE</label>
                                                <input type="text" class="form-control is-valid" id="validationServer05" placeholder="José" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer06">PRIMER APELLIDO</label>
                                                <input type="text" class="form-control is-valid" id="validationServer06" placeholder="Pérez" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer07">SEGUNDO APELLIDO</label>
                                                <input type="text" class="form-control is-valid" id="validationServer07" placeholder="Gómez" required="required" />
                                                <div class="valid-feedback">
                                                    Looks good!
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServerEmail">EMAIL</label>
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text" id="inputGroupPrepend3">@</span>
                                                    </div>
                                                    <input type="text" class="form-control is-invalid" id="validationServerEmail" placeholder="juanperez@mail.com" aria-describedby="inputGroupPrepend3" required="required" />
                                                    <div class="invalid-feedback">
                                                        Please choose a email.
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer08">CONTRASEÑA</label>
                                                <input type="text" class="form-control is-invalid" id="validationServer08" placeholder="******" required="required" />
                                                <div class="invalid-feedback">
                                                    Please provide a valid city.
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer09">AREA</label>
                                                <input type="text" class="form-control is-invalid" id="validationServer09" placeholder="Desarrollo" required="required" />
                                                <div class="invalid-feedback">
                                                    Please provide a valid state.
                                                </div>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer10">SUCURSAL</label>
                                                <input type="text" class="form-control is-invalid" id="validationServer10" placeholder="SUC-1" required="required" />
                                                <div class="invalid-feedback">
                                                    Please provide a valid zip.
                                                </div>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer11">TELEFONO</label>
                                                <input type="text" class="form-control is-invalid" id="validationServer11" placeholder="1234-5678" required="required" />
                                                <div class="invalid-feedback">
                                                    Please provide a valid zip.
                                                </div>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer16">FECHA</label>
                                                <input type="text" class="form-control is-invalid" id="validationServer16" placeholder="01/01/2000" required="required" />
                                                <div class="invalid-feedback">
                                                    Please provide a valid zip.
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <asp:Button ID="btnAgregarEmpleado" runat="server" Text="AGREGAR NUEVO" class="btn btn-outline-warning"  />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
