<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="Vistas.Informes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlInforme2" runat="server" NavigateUrl="~/Informe2.aspx">Mostrar el otro informe</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlMenu" runat="server" NavigateUrl="~/MenuAdministrador.aspx">Volver al menu principal</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Informe 1"></asp:Label>
        </div>
    </form>
</body>
</html>
