<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Incluir_Empleado.aspx.cs" Inherits="pg5_semana4.Incluir_Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; height: 90vh">
            <div style="display: flex; flex-direction: row; align-items: center; justify-content: center">
                <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; margin-right: 3rem">
                    <asp:HiddenField runat="server" ID="hf_Control" />
                    <div class="Jumbotron">
                        <h3>Agregar un Empleado</h3>
                    </div>
                    <p>Codigo</p>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                    <p>Nombre</p>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <p>Horas Laboradas</p>
                    <asp:TextBox ID="txtLabora" runat="server"></asp:TextBox>
                    <p>Salario / Hora</p>
                    <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
                    <div>
                        <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="handleSave" Style="margin-top: 1rem;" />
                    </div>
                </div>
                <div>
            </div>
        </div>
    </form>
</body>
</html>
