<%@ Page Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="Department.aspx.cs"
         Inherits="University.Pages.Department" %>


<%@ Register TagPrefix="common" TagName="MainHeader" Src="~/Controls/MainHeader.ascx" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="/Styles/Controls/Common/MainHeader.css" />
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <common:MainHeader runat="server" />


    <div id="test" runat="server"></div>
</asp:Content>