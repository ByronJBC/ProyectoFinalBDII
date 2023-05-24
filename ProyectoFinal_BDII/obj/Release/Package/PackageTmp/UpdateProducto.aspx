<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateProducto.aspx.vb" Inherits="ProyectoFinal_BDII.UpdateProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/styles.css" rel="stylesheet" type="text/css" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Actualizar Producto - Muebles los Alpes</title>
</head>
<body>
    <form runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark fixed-top bg-dark" id="mainNav">
            <div class="container">
                <a href="../HomeAdmin.aspx" class="navbar-brand">
                    <img src="assets/img/navbar-logo.png" alt="..." /></a>

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    Menu
                    <i class="fas fa-bars ms-1"></i>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav text-uppercase ms-auto py-4">
                        <li><a href="../Productos.aspx" style="text-decoration: none" class="navbar-text">Productos</a></li>
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
                                                <label>ID PRODUCTO</label>
                                                <asp:TextBox runat="server" ID="txtIdProducto" class="form-control" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>NOMBRE</label>
                                                <asp:TextBox runat="server" ID="txtNombre" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>DESCRIPCION</label>
                                                <asp:TextBox runat="server" ID="txtDescripcion" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3 mb-3">
                                                <label>TIPO PRODUCTO</label>
                                                <asp:TextBox runat="server" ID="txtTipoProducto" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>TIPO MATERIAL</label>
                                                <asp:TextBox runat="server" ID="txtTipoMaterial" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>DIMENSION</label>
                                                <asp:TextBox runat="server" ID="txtDimension" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 mb-3">
                                                <label>COLOR</label>
                                                <asp:TextBox runat="server" ID="txtColor" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6 mb-3">
                                                <label>PESO</label>
                                                <asp:TextBox runat="server" ID="txtPeso" class="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-md-6 mb-3">
                                                <label>NOMBRE IMAGEN</label>
                                                <asp:TextBox runat="server" ID="txtNombreImagen" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12 mb-3">
                                                <label>IMAGEN</label>
                                                <asp:TextBox runat="server" ID="txtImagen" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row fl text-center">
                                            <div class="col-md-12 mb-3">
                                                <asp:Button ID="BtnActualizarProducto" runat="server" Text="ACTUALIZAR" class="btn btn-outline-warning" OnClick="BtnActualizarProducto_Click" />
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
