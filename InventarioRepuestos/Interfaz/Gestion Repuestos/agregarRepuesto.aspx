<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarRepuesto.aspx.cs" Inherits="Interfaz.Gestion_Repuestos.agregarRepuestos" %>

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
                    Agregar Repuestos</td>
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
                    <asp:Label ID="Label2" runat="server" Text="Número de Parte:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxParte" runat="server" Height="22px" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Tipo:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:DropDownList ID="DropDownListTipo" runat="server" Width="128px" 
                        Height="22px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label7" runat="server" Text="Marca:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:DropDownList ID="DropDownListMarca" runat="server" Width="128px" 
                        Height="22px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    <asp:Label ID="Label4" runat="server" Text="Modelo:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:DropDownList ID="DropDownListModelo" runat="server" Width="128px" 
                        Height="22px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Label ID="Label5" runat="server" Text="Año:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:DropDownList ID="DropDownListAnio" runat="server" Width="128px" 
                        Height="22px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Label ID="Label6" runat="server" Text="Inventario:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxInventario" runat="server" Height="22px" 
                        Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Label ID="Label8" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    <asp:TextBox ID="TextBoxDescripcion" runat="server" Height="22px" 
                        Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    <asp:Label ID="Label9" runat="server" Text="Precio:"></asp:Label>
                </td>
                <td align="right" class="style2">
                    &nbsp;<asp:TextBox ID="TextBoxPrecio" runat="server" Height="22px" 
                        Width="128px"></asp:TextBox>
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
        </table>
    
    </div>
    </form>
</body>
</html>
