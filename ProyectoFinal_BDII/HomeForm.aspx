﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HomeForm.aspx.vb" Inherits="ProyectoFinal_BDII.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="smPageManager" ScriptMode="Release" runat="server">
            <Scripts runat="server">
                <asp:ScriptReference Path="~/Scripts/bootstrap.min.js" />
            </Scripts>
        </asp:ScriptManager>
        <table style="width: 100%;">
            <tr>
                <td>Clientes</td>
                <td><asp:Button ID="Button1" runat="server" Text="Clientes" OnClick="Button1_Click" class="btn btn-primary"/></td>
            </tr>
        </table>
    </form>
    
</body>
</html>
