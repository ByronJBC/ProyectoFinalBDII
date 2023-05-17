<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Catalogo.aspx.vb" Inherits="ProyectoFinal_BDII.Catalogo" %>

<!DOCTYPE html>
<html>
<head>
    <title>Catálogo de productos</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Catálogo de productos</h1>
            <br />
              <!-- Búsqueda -->
            <div class="form-group">
                <label for="txtSearch">Buscar:</label>
     <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Ingrese término de búsqueda"></asp:TextBox>
                  <br />
                <asp:Button ID="btnSearch" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="buscarProductos" />
            </div>
<br />
            <div class="row">
                <asp:Repeater ID="rptProductos" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 mb-4">
                            <div class="card">
                                <img src='<%# Eval("Imagen") %>' class="card-img-top" alt='<%# Eval("Nombre") %>'>
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                    <p class="card-text"><%# Eval("Descripcion") %></p>
                                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar al carrito" CssClass="btn btn-primary" CommandName="AgregarCarrito" CommandArgument='<%# Eval("ID") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</body>
</html>