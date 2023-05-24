<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddCliente.aspx.vb" Inherits="ProyectoFinal_BDII.AddCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/styles.css" rel="stylesheet" type="text/css" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Agregar Cliente - Muebles los Alpes</title>
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
                        <li><a href="../Clientes.aspx" style="text-decoration: none" class="navbar-text">Clientes</a></li>
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
                                                <label for="validationServer01">ID CLIENTE</label>
                                                <asp:TextBox runat="server" ID="txtIdCliente" class="form-control" placeholder="1" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer02">NUMERO DOCUMENTACION</label>
                                                <asp:TextBox runat="server" ID="txtNumDocumentacion" class="form-control" placeholder="123456789" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer03">NIT</label>
                                                <asp:TextBox runat="server" ID="txtNit" class="form-control" placeholder="112233445" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer04">PRIMER NOMBRE</label>
                                                <asp:TextBox runat="server" ID="txtPrimerNombre" class="form-control" placeholder="Juan" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer05">SEGUNDO NOMBRE</label>
                                                <asp:TextBox runat="server" ID="txtSegundoNombre" class="form-control" placeholder="José" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer06">PRIMER APELLIDO</label>
                                                <asp:TextBox runat="server" ID="txtPrimerApellido" class="form-control" placeholder="Pérez" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer07">SEGUNDO APELLIDO</label>
                                                <asp:TextBox runat="server" ID="txtSegundoApellido" class="form-control" placeholder="Gómez" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServerEmail">EMAIL</label>
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text" id="inputGroupPrepend3">@</span>
                                                    </div>
                                                    <asp:TextBox runat="server" ID="txtEmail" class="form-control" placeholder="juanperez@mail.com" required="required" aria-describedby="inputGroupPrepend3"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label for="validationServer08">CONTRASEÑA</label>
                                                <asp:TextBox runat="server" ID="txtPassword" class="form-control" placeholder="******" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer09">TIPO DOCUMENTACION</label>
                                                <asp:TextBox runat="server" ID="txtTipoDocu" class="form-control" placeholder="DPI" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer10">NUMERO RESIDENCIAL</label>
                                                <asp:TextBox runat="server" ID="txtNumResidencial" class="form-control" placeholder="1122-3344" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer11">NUMERO CELULAR</label>
                                                <asp:TextBox runat="server" ID="txtNumCelular" class="form-control" placeholder="1234-5678" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer17">PROFESION</label>
                                                <asp:TextBox runat="server" ID="txtProfesion" class="form-control" placeholder="2" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer12">PAIS</label>
                                                <asp:TextBox runat="server" ID="txtPais" class="form-control" placeholder="Guatemala" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer13">DEPARTAMENTO</label>
                                                <asp:TextBox runat="server" ID="txtDepartamento" class="form-control" placeholder="Guatemala" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer14">CIUDAD</label>
                                                <asp:TextBox runat="server" ID="txtCiudad" class="form-control" placeholder="Nueva York" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer15">DIRECCION</label>
                                                <asp:TextBox runat="server" ID="txtDireccion" class="form-control" placeholder="12B The Tower" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer16">FECHA</label>
                                                <asp:TextBox runat="server" ID="txtFecha" class="form-control" placeholder="01/01/2000" required="required" ></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label for="validationServer18">NOTAS</label>
                                                <asp:TextBox runat="server" ID="txtNotas" class="form-control" placeholder="Texto para nota" required="required" ></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row fl text-center">
                                            <div class="col-md-12 mb-3">
                                                <asp:Button ID="btnAgregarCliente" runat="server" Text="AGREGAR NUEVO" class="btn btn-outline-warning" OnClick="btnAgregarCliente_Click" />
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
