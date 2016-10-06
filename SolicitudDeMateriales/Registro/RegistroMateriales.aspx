<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroMateriales.aspx.cs" Inherits="SolicitudDeMateriales.Registro.RegistroMateriales" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        ID:
        <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
    </p>
    <p>
        Razon:<asp:TextBox ID="TextBoxRazon" runat="server"></asp:TextBox>
    </p>
    <p>
        Material:&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownListTela" runat="server">
            <asp:ListItem>tela</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad:<asp:TextBox ID="TextBoxCantidad" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Agregar" />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click1" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
    </p>

</asp:Content>
