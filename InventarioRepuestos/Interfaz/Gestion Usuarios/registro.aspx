<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Interfaz.Gestion_Usuarios.registro" %>

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
    <form id="form1" runat="server">
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
                    Registro</td>
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
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxNombre" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxApellido" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxUsuario" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxContraseña" runat="server" Height="22px" Width="128px" 
                        TextMode="Password"></asp:TextBox>
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
                    <asp:Button ID="ButtonGuardar" runat="server" Height="26px" Text="Guardar" 
                        Width="67px" onclick="ButtonGuardar_Click" />
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
        </table>
    
    </div>
    </form>
</body>
</html>
