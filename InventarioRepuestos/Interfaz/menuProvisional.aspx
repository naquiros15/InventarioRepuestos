<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuProvisional.aspx.cs" Inherits="Interfaz.menuProvisional" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style2
        {
            width: 812px;
        }
        .style3
        {
            width: 2px;
            height: 23px;
        }
        .style4
        {
            width: 812px;
            height: 23px;
        }
        .style5
        {
            width: 2px;
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
                <td align="right" class="style3">
                    </td>
                <td align="right" class="style4">
                    </td>
            </tr>
            <tr>
                <td align="right" class="style5">
                </td>
                <td align="center" class="style2">
                    <asp:Button ID="Button2" runat="server" Text="Agregar" 
                        onclick="Button2_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Borrar" 
                        onclick="Button3_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Actualizar" 
                        onclick="Button4_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button6" runat="server" Text="Consultas" 
                        onclick="Button6_Click" />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Salir" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style5">
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
