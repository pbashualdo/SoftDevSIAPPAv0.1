<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Intranet_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate">
    </asp:Login>
</asp:Content>

