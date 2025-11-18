<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informe2.aspx.cs" Inherits="Vistas.Informe2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlInforme1" runat="server" NavigateUrl="~/Informes.aspx">Volver al primer informe</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlMenu" runat="server" NavigateUrl="~/MenuAdministrador.aspx">Volver al Menu Principal</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Informe 2"></asp:Label>
        </div>
    </form>
</body>
</html>
