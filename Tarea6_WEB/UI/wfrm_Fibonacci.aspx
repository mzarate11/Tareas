<%@ Page Title="" Language="C#" MasterPageFile="~/Tarea6.Master" AutoEventWireup="true" CodeBehind="wfrm_Fibonacci.aspx.cs" Inherits="UI.wfrm_Fibonacci" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8" />
    <title>Cadena Fibonacci</title>
    <link rel="stylesheet" href="Styles/Fibo.css" />
    <script src="Styles/jquery/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="Scripts/Fibo.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
<form id="form3" name="Fibonacci" runat="server">

    <h1>Cadena de Fibonacci</h1>
        
    <div>
        <p id="Parrafo1">
            Ingrese el número de limite de la cadena
        </p>
        <br />
        <p id="Parrafo2">
            <input type="text" class="inputs" id="txt_F" name="texto_F" runat="server" onkeypress="return Valida(event)" />
        </p>
        <br />
        <br />
        <p id="Parrafo3">
            <input type="button" class="inputs" id="bttn_F" name="boton" runat="server" value="Mostrar" onserverclick="bttn_F_Click" />
        </p>
        <br />
        <p id="Parrafo4">
            <input type="text" class="inputs" id="txt_R" name="texto_R" runat="server" readonly="true" />
        </p>
    </div>

</form>
</asp:Content>
