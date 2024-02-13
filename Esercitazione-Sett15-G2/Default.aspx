<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Esercitazione_Sett15_G2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <form>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </form>
    </main>

</asp:Content>
