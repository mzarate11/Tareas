<%@ Page Title="" Language="C#" MasterPageFile="~/Tarea6.Master" AutoEventWireup="true" CodeBehind="wfrm_Encriptar.aspx.cs" Inherits="UI.wfrm_Encriptar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8" />
    <title>Calculadora</title>
    <link rel="stylesheet" href="Styles/Encriptado.css"/>
    <script type="text/javascript" src="Scripts/Encriptado.js"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
<form id="form1" name="Encriptar" runat="server">

    <h1>Encriptado</h1>

        <div>
            <p id="Parrafo1">
                Ingrese Texto a Encriptar
            </p>
            <br />
            <p id="Parrafo2">
            <input type="text" class="boton" id="txt_E" name="Texto_E" runat="server" onkeypress="return controlEspacio()" value="" />
            </p>
            <br />    
            <p id="Parrafo3">    
            <input type="button" class="boton" id="bttn_E" runat="server" value="Encriptar" onserverclick="bttn_E_Click" />
            </p>
            <br />
            <p id="Parrafo4">
                <input type="text" class="boton" id="txt_R" name="Texto_R" runat="server" />
            </p>
        </div>
</form>
</asp:Content>
