<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HomeAdmin.aspx.vb" Inherits="ProyectoFinal_BDII.HomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/stylesAdmin.css" rel="stylesheet" type="text/css" />
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Muebles los Alpes</title>
</head>
<body id="page-top">
    <form runat="server">
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand" href="#page-top">
                <img src="assets/img/navbar-logo.png" alt="..." /></a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                Menu
                    <i class="fas fa-bars ms-1"></i>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav text-uppercase ms-auto py-4 py-lg-0">
                    <li class="nav-item"><a class="nav-link" href="#inventario">Inventario</a></li>
                    <li class="nav-item"><a class="nav-link" href="#clientes">Clientes</a></li>
                    <li class="nav-item"><a class="nav-link" href="#empleados">Empleados</a></li>
                    <li class="nav-item"><a class="nav-link" href="#reportes"></a></li>
                </ul>
            </div>
        </div>
    </nav>
    <header class="masthead">
        <div class="container">
            <div class="masthead-subheading">Bienvenido/a!</div>
            <div class="masthead-heading text-uppercase">Muebles los Alpes</div>
            <a class="btn btn-primary btn-xl text-uppercase" href="#inventario">Visualizar Inventario</a>
        </div>
    </header>
    <section class="page-section bg-light" id="inventario">
        <div class="container">
            <div class="text-center">
                <h2 class="section-heading text-uppercase">Más Vendidos</h2>
                <h3 class="section-subheading text-muted">Productos con más movimiento en los últimos días.</h3>
            </div>
            <div class="row">
                <div class="col-lg-4 col-sm-6 mb-4">
                    <!-- inventario item 1-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal1">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto10.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Silla para exterior</div>
                            <div class="inventario-caption-subheading text-muted">Fabricada con materiales alta calidad.</div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-sm-6 mb-4">
                    <!-- inventario item 2-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal2">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto2.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Mesita de noche</div>
                            <div class="inventario-caption-subheading text-muted">Mesa de madera, tamaño pequeño.</div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-sm-6 mb-4">
                    <!-- inventario item 3-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal3">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto9.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Estanteria de madena</div>
                            <div class="inventario-caption-subheading text-muted">Fabricada con materiales de alta calidad.</div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-sm-6 mb-4 mb-lg-0">
                    <!-- inventario item 4-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal4">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto7.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Silla para interior</div>
                            <div class="inventario-caption-subheading text-muted">Silla confortable de color negro.</div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-sm-6 mb-4 mb-sm-0">
                    <!-- inventario item 5-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal5">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto8.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Mesa plegable</div>
                            <div class="inventario-caption-subheading text-muted">Mesa de madera plegable de tamaño pequeño.</div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 col-sm-6">
                    <!-- inventario item 6-->
                    <div class="inventario-item">
                        <a class="inventario-link" data-bs-toggle="modal" href="#inventarioModal6">
                            <div class="inventario-hover">
                                <div class="inventario-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                            </div>
                            <img class="img-fluid" src="Img/producto4.jpg" alt="..." />
                        </a>
                        <div class="inventario-caption">
                            <div class="inventario-caption-heading">Estantería alta</div>
                            <div class="inventario-caption-subheading text-muted">Estantería de madera, alta y angosta.</div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row align-items-center justify-content-center float-end p-3 m-0">
                <asp:Button ID="BtnInvGeneral" runat="server" Text="Inventario General" class="btn btn-primary btn-xl text-uppercase" OnClick="BtnInvGeneral_Click" />
            </div>
        </div>
    </section>
   
        <!-- Clientes-->
        <section class="page-section" id="clientes">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Mejores Clientes</h2>
                    <h3 class="section-subheading text-muted">Clientes con más compras en los últimos días.</h3>
                </div>
                <ul class="timeline">
                    <li>
                        <div class="timeline-image">
                            <img class="rounded-circle img-fluid" src="assets/img/about/1.jpg" alt="..." />
                        </div>
                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4 class="subheading">#1</h4>
                                <h4>Ana María González Sánchez</h4>
                            </div>
                            
                        </div>
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-image">
                            <img class="rounded-circle img-fluid" src="assets/img/about/2.jpg" alt="..." />
                        </div>
                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4>#2</h4>
                                <h4 class="subheading">Juan David Gómez Pérez</h4>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class="timeline-image">
                            <img class="rounded-circle img-fluid" src="assets/img/about/3.jpg" alt="..." />
                        </div>
                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4>#3</h4>
                                <h4 class="subheading">Carla María Gómez Hernández</h4>
                            </div>
                        </div>
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-image">
                            <img class="rounded-circle img-fluid" src="assets/img/about/4.jpg" alt="..." />
                        </div>
                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4>#4</h4>
                                <h4 class="subheading">Mario Alberto Cruz Solis</h4>
                            </div>
                        </div>
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-image">
                            <h4>Sé parte
                                <br />
                                de nuestra
                                <br />
                                Historia!
                            </h4>
                        </div>
                    </li>
                </ul>
                <div class="row align-items-center justify-content-center float-end">
                    <asp:Button ID="BtnClientes" runat="server" Text="Ver Todos" class="btn btn-primary btn-xl text-uppercase" OnClick="BtnClientes_Click" />
                </div>
            </div>
        </section>
        <!-- Empleados-->
        <section class="page-section bg-light" id="empleados">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Mejores Empleados</h2>
                    <h3 class="section-subheading text-muted">Empleados con mayor cantidad de ventas.</h3>
                </div>
                <div class="row">
                    <div class="col-lg-4">
                        <div class="empleados-member">
                            <img class="mx-auto rounded-circle" src="assets/img/team/1.jpg" alt="..." />
                            <h4>Carlos Enrique Martínez Soto</h4>
                            <p class="text-muted">Asistente Administrativo</p>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Carlos Martinez Twitter Profile"><i class="fab fa-twitter"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Carlos Martinez Facebook Profile"><i class="fab fa-facebook-f"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Carlos Martinez LinkedIn Profile"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="empleados-member">
                            <img class="mx-auto rounded-circle" src="assets/img/team/2.jpg" alt="..." />
                            <h4>María José Pérez Ramírez</h4>
                            <p class="text-muted">Jefe de Producción</p>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Maria Perez Twitter Profile"><i class="fab fa-twitter"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Maria Perez Facebook Profile"><i class="fab fa-facebook-f"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Maria Perez LinkedIn Profile"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="empleados-member">
                            <img class="mx-auto rounded-circle" src="assets/img/team/3.jpg" alt="..." />
                            <h4>Juan Carlos Gómez García</h4>
                            <p class="text-muted">Gerente de Operaciones</p>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Juan Gómez Twitter Profile"><i class="fab fa-twitter"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Juan Gómez Facebook Profile"><i class="fab fa-facebook-f"></i></a>
                            <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Juan Gómez LinkedIn Profile"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-8 mx-auto text-center">
                        <p class="Muebleria Los Alpes posse una gran cantidad artículos."></p>
                    </div>
                </div>
            <div class="row align-items-center justify-content-center float-end">
                <asp:Button ID="BtnEmpleados" runat="server" Text="Ver Todos" class="btn btn-primary btn-xl text-uppercase" OnClick="BtnEmpleados_Click" />
            </div>
            </div>
            
        </section>
    
    <!-- reportes-->
    <!--<section class="page-section" id="reportes">
        <div class="container">
            <div class="text-center">
                <h2 class="section-heading text-uppercase">Generar Reporte</h2>
                <h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
            </div>
            <div>
                <button class="btn btn-primary btn-xl text-uppercase disabled" id="reportVentas" type="submit">Reporte de Ventas</button>
                <button class="btn btn-primary btn-xl text-uppercase disabled" id="reportProductos" type="submit">Reporte de Productos</button>
                <button class="btn btn-primary btn-xl text-uppercase disabled" id="reportClientes" type="submit">Reporte de Clientes</button>
            </div>
        </div>
    </section>-->
    <!-- Footer-->
    <footer class="footer py-4">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-4 text-lg-start">Copyright &copy; Muebles los Alpes 2023</div>
                <div class="col-lg-4 my-3 my-lg-0">
                    <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Twitter"><i class="fab fa-twitter"></i></a>
                    <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="Facebook"><i class="fab fa-facebook-f"></i></a>
                    <a class="btn btn-dark btn-social mx-2" href="#!" aria-label="LinkedIn"><i class="fab fa-linkedin-in"></i></a>
                </div>
                <div class="col-lg-4 text-lg-end">
                    <a class="link-dark text-decoration-none me-3" href="#!">Política de Privacidad</a>
                    <a class="link-dark text-decoration-none" href="#!">Términos de Uso</a>
                </div>
            </div>
        </div>
    </footer>
    <!-- inventario Modals-->
    <!-- inventario item 1 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal1" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Silla para exterior</h2>
                                <p class="item-intro text-muted">Fabricada con materiales alta calidad.</p>
                                <img class="img-fluid d-block mx-auto" src="Img/producto10.jpg" alt="..." />

                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Peso:</strong>
                                        15 kg
                                    </li>
                                    <li>
                                        <strong>Color:</strong>
                                        Blanco y Negro
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Cerrar Producto
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- inventario item 2 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal2" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Project Name</h2>
                                <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>
                                <img class="img-fluid d-block mx-auto" src="assets/img/portfolio/2.jpg" alt="..." />
                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Client:</strong>
                                        Explore
                                    </li>
                                    <li>
                                        <strong>Category:</strong>
                                        Graphic Design
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Close Project
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- inventario item 3 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal3" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Project Name</h2>
                                <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>
                                <img class="img-fluid d-block mx-auto" src="assets/img/portfolio/3.jpg" alt="..." />
                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Client:</strong>
                                        Finish
                                    </li>
                                    <li>
                                        <strong>Category:</strong>
                                        Identity
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Close Project
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- inventario item 4 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal4" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Project Name</h2>
                                <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>
                                <img class="img-fluid d-block mx-auto" src="assets/img/portfolio/4.jpg" alt="..." />
                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Client:</strong>
                                        Lines
                                    </li>
                                    <li>
                                        <strong>Category:</strong>
                                        Branding
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Close Project
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- inventario item 5 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal5" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Project Name</h2>
                                <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>
                                <img class="img-fluid d-block mx-auto" src="assets/img/portfolio/5.jpg" alt="..." />
                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Client:</strong>
                                        Southwest
                                    </li>
                                    <li>
                                        <strong>Category:</strong>
                                        Website Design
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Close Project
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- inventario item 6 modal popup-->
    <div class="inventario-modal modal fade" id="inventarioModal6" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-bs-dismiss="modal">
                    <img src="assets/img/close-icon.svg" alt="Close modal" />
                </div>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-lg-8">
                            <div class="modal-body">
                                <!-- Project details-->
                                <h2 class="text-uppercase">Project Name</h2>
                                <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>
                                <img class="img-fluid d-block mx-auto" src="assets/img/portfolio/6.jpg" alt="..." />
                                <p>Use this area to describe your project. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Est blanditiis dolorem culpa incidunt minus dignissimos deserunt repellat aperiam quasi sunt officia expedita beatae cupiditate, maiores repudiandae, nostrum, reiciendis facere nemo!</p>
                                <ul class="list-inline">
                                    <li>
                                        <strong>Client:</strong>
                                        Window
                                    </li>
                                    <li>
                                        <strong>Category:</strong>
                                        Photography
                                    </li>
                                </ul>
                                <button class="btn btn-primary btn-xl text-uppercase" data-bs-dismiss="modal" type="button">
                                    <i class="fas fa-xmark me-1"></i>
                                    Close Project
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="js/scripts.js"></script>
</body>
</html>
