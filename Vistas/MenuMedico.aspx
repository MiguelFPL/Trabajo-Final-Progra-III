<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuMedico.aspx.cs" Inherits="Vistas.MenuMedico" %>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <title>Gestión de Turnos - Médico</title>
</head>
<body>
    <a href="#">Listado de Médicos</a> &nbsp;&nbsp;
    <a href="#">Volver al menú principal</a>
    
    <br><br>
    
    <h2>Gestión de Turnos Médicos</h2>
    
    <br>
    
    <h3>Filtros y Búsqueda:</h3>
    
    <table>
        <tr>
            <td>Buscar por Paciente:</td>
            <td><input type="text" placeholder="Nombre o DNI"></td>
            <td><button>Buscar</button></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha:</td>
            <td><input type="date"></td>
            <td><button>Filtrar</button></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Estado del Turno:</td>
            <td>
                <select>
                    <option>Sin enlazar</option>
                    <option>Todos</option>
                    <option>Pendientes</option>
                    <option>Presentes</option>
                    <option>Ausentes</option>
                </select>
            </td>
            <td><button>Limpiar Filtros</button></td>
        </tr>
    </table>
    
    <br><br>
    
    <table border="1" cellpadding="5" cellspacing="0" style="background-color: #6699CC; color: white;">
        <tr>
            <th>ID</th>
            <th>Fecha</th>
            <th>Horario</th>
            <th>Paciente</th>
            <th>DNI Paciente</th>
            <th>Estado</th>
            <th>Observación</th>
            <th>Acciones</th>
        </tr>
        <tr style="background-color: white; color: black;">
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
        </tr>
        <tr style="background-color: white; color: black;">
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
        </tr>
        <tr style="background-color: white; color: black;">
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
        </tr>
        <tr style="background-color: white; color: black;">
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
        </tr>
        <tr style="background-color: white; color: black;">
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
            <td>DataBound</td>
        </tr>
    </table>
    
    <br><br>
    
    <h3>Agregar Observación de la Consulta</h3>
    
    <table>
        <tr>
            <td>Paciente:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Observación:</td>
            <td><textarea rows="5" cols="50"></textarea></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <button>Guardar</button>
                <button>Cancelar</button>
            </td>
        </tr>
    </table>
    
</body>
</html>