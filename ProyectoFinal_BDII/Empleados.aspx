<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Empleados.aspx.vb" Inherits="ProyectoFinal_BDII.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Css/styles.css" rel="stylesheet" type="text/css" />
    <link href="Css/stylesEmpleados.css" rel="stylesheet" type="text/css" />
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700" rel="stylesheet" type="text/css" />
    <title>Empleados - Muebles los Alpes</title>
</head>
<body id="page-top">
    <form runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
            <div class="container">
                <a href="HomeAdmin.aspx" class="navbar-brand">
                    <img src="assets/img/navbar-logo.png" alt="..." /></a>

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    Menu
                    <i class="fas fa-bars ms-1"></i>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav text-uppercase ms-auto py-4 py-lg-0">
                        <li><a href="../HomeAdmin.aspx" style="text-decoration: none" class="navbar-text">Home</a></li>
                    </ul>
                </div>
            </div>
        </nav>
        <section class="page-section bg-dark " id="empleados">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase text-light">Empleados</h2>
                    <asp:Button ID="btnAddEmpleado" runat="server" Text="+ AGREGAR NUEVO" class="btn btn-outline-warning float-end" OnClick="BtnAddEmpleado_Click" />
                </div>
            </div>
        </section>

        <section class="py-4">
            <div class="mask d-flex align-items-center">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12">
                            <div class="card shadow-2-strong" style="background-color: #f5f7fa;">
                                <div class="card-body">
                                    <div class="table-responsive">
                                        <asp:GridView ID="GridViewEmpleados" class="table table-borderless mb-0 " runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnRowCommand="GridViewEmpleados_RowCommand">
                                            <Columns>
                                                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                                                <asp:BoundField DataField="Empleado" HeaderText="EMPLEADO" />
                                                <asp:BoundField DataField="ROL" HeaderText="ROL" />
                                                <asp:BoundField DataField="Telefono" HeaderText="TELEFONO" />
                                                <asp:BoundField DataField="Email" HeaderText="EMAIL" />
                                                <asp:ButtonField ButtonType="Link"
                                                    ItemStyle-HorizontalAlign="Left"
                                                    ControlStyle-BorderColor="Transparent"
                                                    ControlStyle-BackColor="Turquoise"
                                                    CommandName="EditarEmpleado"
                                                    HeaderText="EDITAR"
                                                    Text="✏️" />
                                                <asp:ButtonField ButtonType="Link"
                                                    ItemStyle-HorizontalAlign="Left"
                                                    ControlStyle-BorderColor="Transparent"
                                                    ControlStyle-BackColor="Red"
                                                    CommandName="EliminarEmpleado"
                                                    HeaderText="ELIMINAR"
                                                    Text="✖️" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

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
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="js/scripts.js"></script>
</body>
</html>
