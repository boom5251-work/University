<%@ Page Title="Личный кабинет студента" 
         Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="StudentAccount.aspx.cs"
         Inherits="University.Pages.Account.StudentAccount" %>


<%@ Register TagPrefix="common" TagName="MainHeader" Src="~/Controls/MainHeader.ascx" %>


<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="/Styles/Controls/Common/MainHeader.css" />
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <common:MainHeader runat="server" />


    <div>
        <h1>Личный кабинет студента</h1>
        <asp:Button ID="LogOutButton" Text="Выйти" OnClick="LogOutButton_Click" runat="server" />
        <h4 id="test" runat="server"></h4>
    </div>
</asp:Content>
