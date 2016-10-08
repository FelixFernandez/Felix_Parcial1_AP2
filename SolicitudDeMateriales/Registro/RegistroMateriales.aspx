<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroMateriales.aspx.cs" Inherits="SolicitudDeMateriales.Registro.RegistroMateriales" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        ID:
        <asp:TextBox ID="TextBoxId" runat="server" Width="63px"></asp:TextBox>
        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
    </p>
    <p>
        &nbsp;&nbsp;
        Razon: <asp:TextBox ID="TextBoxRazon" runat="server" Width="355px"></asp:TextBox>
    </p>
    <p>
        Material: <asp:TextBox ID="TextBoxMaterial" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;Cantidad: <asp:TextBox ID="TextBoxCantidad" runat="server" Width="93px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Agregar" />
    </p>
    <p style="margin-left: 98px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p style="margin-left: 98px">
        <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click1" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
    </p>

</asp:Content>
