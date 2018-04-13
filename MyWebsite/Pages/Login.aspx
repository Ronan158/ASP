<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyWebsite.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter Username and password"></asp:Label>
<br />
<asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
<asp:TextBox ID="TbxUser" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="TbxPass" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
<br />
</asp:Content>
