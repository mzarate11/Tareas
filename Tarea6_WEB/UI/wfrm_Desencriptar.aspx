<%@ Page Title="" Language="C#" MasterPageFile="~/Tarea6.Master" AutoEventWireup="true" CodeBehind="wfrm_Desencriptar.aspx.cs" Inherits="UI.wfrm_Desencriptar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"; charset="utf-8" />
    <title>Desencriptar</title>
    <link rel="stylesheet" href="Styles/Encriptado.css" />
    <script type="text/javascript" src="Scripts/Encriptado.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
<form id="form1" name="Desencriptar" runat="server">

    <h1>Desencriptado</h1>

        <div>
            <p id="Parrafo1">
                Ingrese el  texto a Desencriptar
            </p>
            <br />
            <p id="Parrafo2">
                <input type="text" class="boton" id="txt_D" name="texto_D" runat="server" onkeypress="return controlEspacio()" value=""  />
            </p>
            <br />
            <p id="Parrafo3">
                <input type="button" class="boton" id="bttn_D" runat="server" value="Desencriptar" onserverclick="bttn_D_click"  />
            </p>
            <br />
            <p id="Parrafo4">
                <input type="text" class="boton" id="txt_R" name="texto_R" runat="server" />
            </p>
        </div>
</form>
</asp:Content>
