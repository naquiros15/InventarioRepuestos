<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuProvisional.aspx.cs" Inherits="Interfaz.menuProvisional" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 216px;
        }
        .style2
        {
            width: 812px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
    
        <table style="width:100%;" >
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="right" class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Large" 
        ForeColor="#284E98" StaticSubMenuIndent="10px" onmenuitemclick="Menu1_MenuItemClick">
        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#B5C7DE" />
        <DynamicSelectedStyle BackColor="#507CD1" />
        <Items>
            <asp:MenuItem Text="Agregar Repuesto" Value="Agregar Repuesto"></asp:MenuItem>
            <asp:MenuItem Text="Borrar Repuesto" Value="Nuevo elemento"></asp:MenuItem>
            <asp:MenuItem Text="Actualizar Repuestos" Value="Nuevo elemento"></asp:MenuItem>
            <asp:MenuItem Text="Actualizar Inventario" Value="Nuevo elemento">
            </asp:MenuItem>
            <asp:MenuItem Text="Buscar" Value="Nuevo elemento"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#507CD1" />
    </asp:Menu>
                </td>
                <td align="center" class="style2">
                    <asp:Button ID="Button2" runat="server" Text="Agregar Respuesto" 
                        onclick="Button2_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Borrar Repuesto" 
                        onclick="Button3_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Actualizar Repuestos" 
                        onclick="Button4_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Text="Actualizar Inventario" 
                        onclick="Button5_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Buscar" onclick="Button6_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Salir" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="right" class="style2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
