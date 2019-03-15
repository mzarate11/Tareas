<%@ Page Title="" Language="C#" MasterPageFile="~/wfrm_Menu.Master" AutoEventWireup="true" CodeBehind="wfrm_Calculadora.aspx.cs" Inherits="UI.wfrm_Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html; charset=uft-8" />
    <title>Calculadora</title>
    <link rel="stylesheet" href="Styles/Bootstrap/bootstrap.min.css"/>
    <script src="Styles/Bootstrap/bootstrap.min.js"></script>
    <script src="Styles/Bootstrap/jquery.min.js"></script>
    <script type="text/javascript" src="Scripts/Calcu.js"></script>
    <style>
        form {
    width:100%;
    max-width:400px;
    text-align:center;
    border:solid 1px #c2c2c2;
    padding-bottom: 10px;
    margin: auto;
    opacity:0.8;
    color:darkgreen;
            }
    
        .bttnR {
            background-image: url('Resources/boton1.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-position: center center;
            border-style: none;
            border-width: thick;
            border-radius: 69px 69px 69px 69px;
-moz-border-radius: 69px 69px 69px 69px;
-webkit-border-radius: 69px 69px 69px 69px;
border: 0px solid #000000;
        }
    
        .chckl {
            text-align: center;
        }
    
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
    <form id="form1" name="Calculadora" runat="server">
    <h1>Calculadora</h1>
        <br />
        <div>
        <p id="lb1" style="font-size:x-large" >Digito 1</p>    
        <input type="text" id="txt_dg1" name="txt_d1" runat="server" onkeypress="return ValidarNumero(event)" value=""/>
        <br />
        <p style="font-size:x-large">Digito 2</p>
        <input type="text" id="txt_dg2" name="txt_d2" runat="server" onkeypress="return ValidarNumero(event)" value="" />
        <br />
        <br />
            <h4>+</h4><input type="checkbox" title="+" id="suma" runat="server" name="c[]" value="Sumar"/>
            <h4>-<input type="checkbox" id="resta" runat="server" name="c[]" value="Restar" /></h4>
            <h4>*<input type="checkbox" id="multi" runat="server" name="c[]" value="Multiplicar" /></h4>
            <h4>/<input type="checkbox" id="divide" runat="server" name="c[]" value="Dividir" /></h4> 
        <br />
            <asp:Button ID="bttn_c" runat="server" Text="Calcular" OnClick="bttn_c_Click" CssClass="bttnR"/>

            <br />
            <br />
            <p style="font-size:x-large">Respuesta</p>
        <br />
        <asp:TextBox id="txt" runat="server"></asp:TextBox>
         </div>
    </form>
     
</asp:Content>
