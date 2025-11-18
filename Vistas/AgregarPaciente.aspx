<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="Vistas.AgregarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlListadoPacientes" runat="server" NavigateUrl="~/ListadoPacientes.aspx">Listado de Pacientes</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlMenu" runat="server" NavigateUrl="~/MenuAdministrador.aspx">Volver al menu principal</asp:HyperLink>
        </div>
        <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="Agregar Paciente"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDNI" runat="server" Text="DNI:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbDNI" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblSexo" runat="server" Text="Sexo:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlSexo" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblNacionalidad" runat="server" Text="Nacionalidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbNacionalidad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblFechadeNacimiento" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Calendar ID="calFechaNacimiento" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbDireccion" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLocalidad" runat="server" Text="Localidad:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlLocalidades" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlProvincias" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electronico:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
