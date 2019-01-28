<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrm_Tarea1_PL.aspx.cs" Inherits="PL_Tarea1.Tarea1_PL.wfrm_Tarea1_PL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Hojas de Estilo/hds_1.css" rel="stylesheet" type="text/css" />
    <title>Tarea1 Programación 4</title>
    
     <style type="text/css">
     
         .hds_1.css {}
         .hds_1.css {}
     
     </style>
     
</head>
<body>
    <form id="form1" runat="server">
        
        <h1>Calculadora</h1>
        
    <br/>
    <div aria-autocomplete="none">
        <asp:Label ID="lb_Digito1" runat="server" Text="Digito 1:"></asp:Label>
        <asp:TextBox style= ID="txt_Digito1" runat="server" MaxLength="5"></asp:TextBox>
        <asp:RegularExpressionValidator ID="ReValidator1" runat="server" ErrorMessage="Sólo deben ir números" Text="*" ControlToValidate="txt_Digito1" ValidationExpression="^[0-9]+([,][0-9]+)?$"></asp:RegularExpressionValidator>
 
         <p>
            <asp:Label ID="lb_Digito2" runat="server" Text="Digito 2:">

            </asp:Label><asp:TextBox ID="txt_Digito2" runat="server" MaxLength="5"></asp:TextBox>
         </p>
        
        <p>
        <asp:DropDownList ID="dld_Opciones" runat="server" Height="28px" Width="120px">
            <asp:ListItem Value="Sumar"></asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
            <asp:ListItem>Dividir</asp:ListItem>
        </asp:DropDownList>
        </p>
        <p>
        <asp:Button ID="bttn_Calcular" runat="server" Text="Calcular" OnClick="bttn_Calclular_Click" CssClass="hds_1.css" Height="28px" Width="120px"/>
        </p>
        <p>
        <asp:Button ID="bttn_limpiar" runat="server" Text="Limpiar" OnClick="bttn_limpiar_Click" Height="28px" Width="120px"/>
        </p>
        <br/>
        <asp:Label ID="lbl_resultado" runat="server" Text="Resultado:     "></asp:Label><asp:TextBox ID="txt_Resultado" runat="server" ReadOnly="True" MaxLength="15" style="margin-bottom: 0px"></asp:TextBox>
        </div>
        <footer>
            <br />
            <br />
            <br />
            <br />
            <br />
            <h2>Hecho por Manuel Zárate Brizuela 2019</h2>
        </footer>
    </form>
</body>
</html>
