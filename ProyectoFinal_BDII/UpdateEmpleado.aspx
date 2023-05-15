<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateEmpleado.aspx.vb" Inherits="ProyectoFinal_BDII.UpdateEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/styles.css" rel="stylesheet" type="text/css" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Actualizar Empleado - Muebles los Alpes</title>
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
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>ID EMPLEADO</label>
                                                <asp:TextBox runat="server" ID="txtIdEmpleado" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>PRIMER NOMBRE</label>
                                                <asp:TextBox runat="server" ID="txtPrimerNombre" class="form-control" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>SEGUNDO NOMBRE</label>
                                                <asp:TextBox runat="server" ID="txtSegundoNombre" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>PRIMER APELLIDO</label>
                                                <asp:TextBox runat="server" ID="txtPrimerApellido" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>SEGUNDO APELLIDO</label>
                                                <asp:TextBox runat="server" ID="txtSegundoApellido" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>EMAIL</label>
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text" id="inputGroupPrepend3">@</span>
                                                    </div>
                                                    <asp:TextBox runat="server" ID="txtEmail" class="form-control" aria-describedby="inputGroupPrepend3"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>CONTRASEÑA</label>
                                                <asp:TextBox runat="server" ID="txtPassword" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label>AREA</label>
                                                <asp:TextBox runat="server" ID="txtArea" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>ROL</label>
                                                <asp:TextBox runat="server" ID="txtRol" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>TELEFONO</label>
                                                <asp:TextBox runat="server" ID="txtTelefono" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>FECHA</label>
                                                <asp:TextBox runat="server" ID="txtFecha" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>REGISTRO</label>
                                                <asp:TextBox runat="server" ID="txtRegistro" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>SUCURSAL</label>
                                                <asp:TextBox runat="server" ID="txtSucursal" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row fl text-center">
                                            <div class="col-md-12 mb-3">
                                                <asp:Button ID="btnActualizarEmpleado" runat="server" Text="ACTUALIZAR" class="btn btn-outline-warning" OnClick="btnActualizarEmpleado_Click1" />
                                            </div>
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
