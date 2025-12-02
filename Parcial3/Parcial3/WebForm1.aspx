<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Parcial3.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Proyecto Bufete de Abogados</title>
    <style>
        body { 
            font-family: Arial, sans-serif; 
            margin: 20px; 
            background-color: #f9f9f9; 
            color: #333;
        }
        h1, h2 {
            text-align: center;
            color: #2c3e50;
        }
        .problema {
            background-color: #ecf0f1;
            padding: 15px;
            border-radius: 8px;
            margin-bottom: 30px;
            line-height: 1.6;
        }
        table {
            width: 80%;
            margin: auto;
            border-collapse: collapse;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }
        th, td {
            padding: 12px;
            border: 1px solid #ddd;
            vertical-align: top;
        }
        th {
            background-color: #3498db;
            color: white;
            text-align: left;
            width: 50%;
        }
        td {
            background-color: #fff;
        }
        tr:nth-child(even) td {
            background-color: #f7f7f7;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Problemas de Bufete de Abogados</h1>

        <div class="problema">
            <p>Un bufete de abogados de tamaño mediano está enfrentando serios problemas para gestionar sus registros de casos legales. Actualmente, los abogados y el personal administrativo están utilizando hojas de cálculo y documentos de texto para llevar el control de los casos. Este sistema manual es ineficiente y propenso a errores, lo que ha ocasionado retrasos en la presentación de informes, dificultades en el seguimiento de los plazos y confusión en el manejo de información importante.</p>

            <p>Algunos de los problemas específicos que enfrenta el bufete son los siguientes:</p>
            <ul>
                <li>Desorganización en el manejo de los detalles de los casos (fecha de inicio, fecha de vencimiento, abogado asignado, estado del caso, clientes, etc.).</li>
                <li>Pérdida de información importante sobre reuniones, audiencias y vencimientos de plazos legales.</li>
                <li>Confusión con los documentos asociados a los casos (documentos legales, evidencias, etc.), ya que no se encuentran fácilmente.</li>
                <li>Difusión de la información: el acceso a la información del caso no es centralizado, lo que provoca que algunos abogados o asistentes no tengan acceso a los datos más actualizados.</li>
                <li>Falta de seguimiento: muchos casos tienen plazos o fechas clave que se pasan por alto debido a la falta de un sistema de alertas o recordatorios.</li>
            </ul>
        </div>

        <!-- Aquí se cargan las preguntas y respuestas -->
        <asp:Literal ID="ltPreguntas" runat="server"></asp:Literal>
    </form>
</body>
</html>
