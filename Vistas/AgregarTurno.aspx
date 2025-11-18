<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarTurno.aspx.cs" Inherits="Vistas.AgregarTurno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/ListadoTurnos.aspx">Listado de Turnos</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlMenu" runat="server" NavigateUrl="~/MenuAdministrador.aspx">Volver al menu principal</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="lblTurno" runat="server" Font-Size="XX-Large" Text="Agregar turno"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Especialidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlEspecialidad" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Medico:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMedico" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Día:"></asp:Label>
        <asp:Calendar ID="calDia" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Horario:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbHorario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="DNI Paciente:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPaciente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </form>
</body>
</html>
