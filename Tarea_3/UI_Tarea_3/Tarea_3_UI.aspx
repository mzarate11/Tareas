<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tarea_3_UI.aspx.cs" Inherits="UI_Tarea_3.Tarea_3_UI" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarea3</title>
    <meta name="viewport" content="width=device-width, user-scable=no, initial-scale=1.0, maximum-scale=1.0, minimum-sacle=1.0,"/>   
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css"/>
    <style>
        body {
                background-image:url(Resources/textura-fondo-gris.jpg);   
             }

        .form-control:focus {
                            border-width: 2px;    
                            border-color:black;
                            box-shadow:none;
                            background-color:transparent;

                            }
        .form-control {
                            border-width: 2px;
                            border-color:gray;
                            background-color:transparent;
                      }
        .form-control:disabled {
                            border-width: 2px;
                            border-color:gray;
                            background-color:transparent;
                                }
        .txt-title {
                text-align:center;
        
            }
        .lb_palabra {
                        font-size:large;
                    }
        .container {
                    text-align:center;
            margin-top: 0px;
                   }
    
    </style>
   
</head>
<body>
    <h1 class="txt-title">Tarea 3 Palíndromos</h1>
    <form id="form1" runat="server">
    <div class="container">
    <label class="lb_palabra" for="lb_Palabra">Palabra:</label>
    <input name="Palabra" id="txt_palabra" class="form-control" runat="server" type="text" maxlength="15" />
        <asp:RegularExpressionValidator ID="RegularEValidator1" runat="server" ErrorMessage="Solo se Permiten Letras" ControlToValidate="txt_palabra" ValidationExpression="^[a-zA-Z ]*$" ValidationGroup="letras" ForeColor="#cc0000"></asp:RegularExpressionValidator>
    </div>
    <div class="col-md-12">
        <br/>
    </div>
    <div class="container">
        <asp:Button ID="bttnPreguntar" runat="server" Text="Preguntar" CssClass="btn btn-dark" OnClick="bttn_preguntar_click" ValidationGroup="letras" />
        <asp:Button ID="BttnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-dark" OnClick="bttn_limpiar_click" />
    </div>
    <div class="col-12">
        <br />
    </div>
    <div class="container">
        <input class="form-control" id="txt_Respuesta" runat="server" type="text" name="Respuesta" disabled="disabled"/>


    </div>
    </form>
    <script type="text/javascript" src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"  ></script>
</body>
</html>
