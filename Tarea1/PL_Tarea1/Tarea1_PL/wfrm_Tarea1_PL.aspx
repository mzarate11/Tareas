<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Tarea1_PL.aspx.cs" Inherits="PL_Tarea1.Tarea1_PL.wfrm_Tarea1_PL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <h1>Tarea 1 - Programación 4</h1>
</head>
<body>
    <form id="form1" runat="server">
        <h1>&nbsp;Calculadora</h1>
        <asp:Label ID="lb_Digito1" runat="server" Text="Digito 1:   "></asp:Label><asp:TextBox ID="txt_Digito1" runat="server"></asp:TextBox>
    <div>
    
    </div>
        <p>
            <asp:Label ID="lb_Digito2" runat="server" Text="Digito 2:  "></asp:Label><asp:TextBox ID="txt_Digito2" runat="server" Height="16px"></asp:TextBox>

        </p>

        <asp:DropDownList ID="dld_Opciones" runat="server">
            <asp:ListItem Value="Sumar"></asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
            <asp:ListItem>Dividir</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="bttn_Calclular" runat="server" Text="Calcular" OnClick="bttn_Calclular_Click" />
        <asp:Button ID="bttn_limpiar" runat="server" Text="Limpiar" Width="70px" OnClick="bttn_limpiar_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_resultado" runat="server" Text="Resultado:     "></asp:Label><asp:TextBox ID="txt_Resultado" runat="server"></asp:TextBox>
    </form>
</body>
</html>
