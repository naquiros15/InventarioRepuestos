﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizarRepuestos.aspx.cs" Inherits="Interfaz.Gestion_Repuestos.actualizarRepuestos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .style1
        {
            width: 490px;
        }
        .style2
        {
            width: 563px;
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
                <td align="center" class="style2">
                    Actualizar Repuestos</td>
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
                    &nbsp;</td>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="right" class="style2">
                    <asp:GridView ID="GridViewRepuestos" runat="server" align="center" 
                        BackColor="White" BorderColor="#999999" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
                        AutoGenerateSelectButton="True" 
                        onselectedindexchanging="GridViewRepuestos_SelectedIndexChanging">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Número de Parte:"></asp:Label>
                &nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxParte" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Marca:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxMarca" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Inventario:"></asp:Label>
                &nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxInventario" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="Modelo:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxModelo" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
                &nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="Combustible:"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxCombustible" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
                        <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td align="left" class="style2">
                    &nbsp;&nbsp;&nbsp;
                    Precio Unitario:&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxPrecio" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label8" runat="server" Text="Estilo:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxEstilo" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
                &nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxTipo" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" Text="Año:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxAnio" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Descripción Vehiculo:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBoxDescripcionV" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right"class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
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
                <td align="center"class="style1">
                    &nbsp;</td>
                <td class="style2" align="center">
                    &nbsp;<asp:Button 
                        ID="ButtonGuardar" runat="server" Height="28px" Text="Guardar Cambios" 
                        Width="131px" onclick="ButtonGuardar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="ButtonVolver" runat="server" Height="26px" Text="Volver" 
                        Width="67px" onclick="ButtonVolver_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
