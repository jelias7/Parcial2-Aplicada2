<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteTransacciones.aspx.cs" Inherits="Parcial2_UI.Reportes.ReporteTransacciones" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html,body,form,#div {
            height: 100%; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div">
            <asp:ScriptManager runat="server"></asp:ScriptManager> 
          <rsweb:ReportViewer ID="MyReportViewer" runat="server"  ProcessingMode="Remote" Height="100%" Width="100%">
          <ServerReport ReportServerUrl="" ReportPath="" />
          </rsweb:ReportViewer>
         </div>
    </form>
</body>
</html>
