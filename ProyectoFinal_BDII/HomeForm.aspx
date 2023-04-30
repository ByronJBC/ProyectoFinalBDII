<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HomeForm.aspx.vb" Inherits="ProyectoFinal_BDII.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
    	.form-style-1 {
    		margin: 10px auto;
    		max-width: 400px;
    		padding: 20px 12px 10px 20px;
    		font: 13px "Lucida Sans Unicode", "Lucida Grande", sans-serif;
    	}

    		.form-style-1 input[type=submit], .form-style-1 input[type=button] {
    			background: #4B99AD;
    			padding: 8px 15px 8px 15px;
    			border: none;
    			color: #fff;
    		}

    			.form-style-1 input[type=submit]:hover, .form-style-1 input[type=button]:hover {
    				background: #4691A4;
    				box-shadow: none;
    				-moz-box-shadow: none;
    				-webkit-box-shadow: none;
    			}

    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-style-1">
        <table style="width: 100%;">
            <tr>
                <td>Clientes</td>
                <td><asp:Button ID="Button1" runat="server" Text="Clientes" OnClick="Button1_Click" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
