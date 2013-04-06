<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarCliente.aspx.cs" Inherits="Interfaz.Facturacion.agregarCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 600px;
        }
        .style2
        {
            width: 166px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table style="width:100%;" >
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    Agregar Clientes</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label2" runat="server" Text="Identificación:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxId" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    Nombre:</td>
                <td class="style2" align="right">
                    <asp:TextBox ID="TextBoxNombre" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    Apellido:</td>
                <td class="style2" align="right">
                    <asp:TextBox ID="TextBoxApellido" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Teléfono:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxTel" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Celular:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxCel" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Dirección:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxDir" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Tipo:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxTipo" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Button ID="ButtonAgregar" runat="server" Height="26px" Text="Agregar" 
                        Width="67px" onclick="ButtonAgregar_Click" />
                </td>
                <td align="right" class="style2">
                    <asp:Button ID="ButtonCancelar"  align="right" runat="server" Height="26px" Text="Cancelar" 
                        Width="67px" onclick="ButtonCancelar_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
    </body>
</html>
